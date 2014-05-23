using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace ExpressionParser
{
    //Template class: a unistroke template
    public class Template
    {
        #region Parameters

        public string Name;
        public List<Point> Points;    // resampled points (for matching) -- done when loaded
        public Point StartUnitVector; 
        public int NumResamplePoints = 96;// options: 16, 64, 96
        public double OneDThreshold = 0.25; // customize to desired gesture set (usually 0.20-0.35)
        public double SquareSize = 250.0;
        public Point ResampleOrigin = new Point(0, 0);
        public int StartAngleIndex = 12; // (NumResamplePoints/8) eighth of gesture length

        #endregion

        //Constructor
        public Template(string name, List<Point> points, bool useBoundedRotationInvariance)
        {
            this.Name = name;
            // first, resample (influences calculation of centroid)
            this.Points = Resample(points, NumResamplePoints);
            // then, if we are rotation-invariant, rotate to a common reference angle
            // rotate so that the centroid-to-1st-point is at zero degrees
            double radians = IndicativeAngle(this.Points);
            this.Points = RotateByRadians(this.Points, -radians);
            // scale to a common (square) dimension
            // moved determination of scale method to within the scale() method for less branching here
            this.Points = ScaleDimTo(this.Points, OneDThreshold, SquareSize);
            // next, if NOT rotation-invariant, rotate back
            if (useBoundedRotationInvariance)
            {
                this.Points = RotateByRadians(this.Points, +radians); // undo angle
            }
            // next, translate to a common origin
            this.Points = TranslateTo(this.Points, ResampleOrigin);
            // finally, save the start angle
            // store the start unit vector after post-processing steps
            this.StartUnitVector = CalcStartUnitVector(this.Points, StartAngleIndex);
        }

        #region Calculating Start Unit Vector

        // start angle from points[0] to points[index] normalized as a unit vector
        public static Point CalcStartUnitVector(List<Point> points,int index) 
        {
	        Point v = new Point(points[index].X - points[0].X, points[index].Y - points[0].Y);
	        double len = Math.Sqrt(v.X * v.X + v.Y * v.Y);
	        return new Point(v.X / len, v.Y / len);
        }

        #endregion

        #region Translation

        //translates points' centroid
        public static List<Point> TranslateTo(List<Point> points, Point pt)
        {
            List<Point> newPoints = new List<Point>(points.Count);
            Point centroid = Centroid(points);
            foreach (Point p in points)
            {
                Point q = new Point();
                q.X = p.X + pt.X - centroid.X;
                q.Y = p.Y + pt.Y - centroid.Y;
                newPoints.Add(q);
            }
            return newPoints;
        }

        #endregion

        #region Scaling
        // scales bbox uniformly for 1D, non-uniformly for 2D
        public static List<Point> ScaleDimTo(List<Point> points, double oneDRatio, double size) 
        {
            Rect B = BoundingBox(points);
            bool uniformly = (Math.Min(B.Width / B.Height, B.Height / B.Width) <= oneDRatio); // 1D or 2D gesture test
            List<Point> newpoints = new List<Point>(points.Count);
            for (int i = 0; i < points.Count; i++)
            {
                double qx = uniformly ? (points[i]).X * (size / Math.Max(B.Width, B.Height)) : (points[i]).X * (size / B.Width);
                double qy = uniformly ? (points[i]).Y * (size / Math.Max(B.Width, B.Height)) : (points[i]).Y * (size / B.Height);
                newpoints.Add(new Point(qx, qy));
            }
            return newpoints;
        }

        public static Rect BoundingBox(List<Point> points)
        {
            double minX = double.MaxValue;
            double maxX = double.MinValue;
            double minY = double.MaxValue;
            double maxY = double.MinValue;

            foreach (Point p in points)
            {
                if (p.X < minX)
                    minX = p.X;
                if (p.X > maxX)
                    maxX = p.X;

                if (p.Y < minY)
                    minY = p.Y;
                if (p.Y > maxY)
                    maxY = p.Y;
            }

            return new Rect(minX, minY, maxX - minX, maxY - minY);
        }
        #endregion

        #region Rotate By Radians
        // rotate the points by the given radians about their centroid
        public static List<Point> RotateByRadians(List<Point> points, double radians)
        {
            List<Point> newPoints = new List<Point>(points.Count);
            Point c = Centroid(points);

            double cos = Math.Cos(radians);
            double sin = Math.Sin(radians);

            double cx = c.X;
            double cy = c.Y;

            for (int i = 0; i < points.Count; i++)
            {
                Point p = points[i];

                double dx = p.X - cx;
                double dy = p.Y - cy;

                Point q = new Point();
                q.X = dx * cos - dy * sin + cx;
                q.Y = dx * sin + dy * cos + cy;

                newPoints.Add(q);
            }
            return newPoints;
        }
        #endregion

        #region Angel in Radians
        // determines the angle, in radians, between two points. the angle is defined 
        // by the circle centered on the start point with a radius to the end point, 
        // where 0 radians is straight right from start (+x-axis) and PI/2 radians is
        // straight down (+y-axis).
        public static double IndicativeAngle(List<Point> points)
        {
            Point c = Centroid(points);
            return Math.Atan2(c.Y - points[0].Y, c.X - points[0].X);
        }

        // compute the centroid of the points given
        public static Point Centroid(List<Point> points)
        {
            double xsum = 0.0;
            double ysum = 0.0;

            foreach (Point p in points)
            {
                xsum += p.X;
                ysum += p.Y;
            }
            return new Point(xsum / points.Count, ysum / points.Count);
        }

        #endregion

        #region Path Sampling and Distance

        public static List<Point> Resample(List<Point> points, int n)
        {
            double I = PathLength(points) / (n - 1); // interval length
            double D = 0.0;
            List<Point> newPoints = new List<Point>();
            newPoints.Add(points[0]);
            for (int i = 1; i < points.Count; i++)
            {
                Point pt1 = points[i - 1];
                Point pt2 = points[i];

                double d = Distance(pt1, pt2);
                if ((D + d) >= I)
                {
                    double qx = pt1.X + ((I - D) / d) * (pt2.X - pt1.X);
                    double qy = pt1.Y + ((I - D) / d) * (pt2.Y - pt1.Y);
                    Point q = new Point(qx, qy);
                    newPoints.Add(q); // append new point 'q'
                    points.Insert(i, q); // insert 'q' at position i in points s.t. 'q' will be the next i
                    D = 0.0;
                }
                else
                {
                    D += d;
                }
            }
            // somtimes we fall a rounding-error short of adding the last point, so add it if so
            if (newPoints.Count == n - 1)
            {
                newPoints.Add(points[points.Count - 1]);
            }

            return newPoints;
        }

        public static double PathLength(List<Point> points)
        {
            double length = 0;
            for (int i = 1; i < points.Count; i++)
            {
                length += Distance(points[i - 1], points[i]);
            }
            return length;
        }

        public static double Distance(Point p1, Point p2)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        // computes the 'distance' between two point paths by summing their corresponding point distances.
        // assumes that each path has been resampled to the same number of points at the same distance apart.
        public static double PathDistance(List<Point> path1, List<Point> path2)
        {
            double distance = 0;
            int count = path1.Count;
            for (int i = 0; i < count; i++)
            {
                distance += Distance(path1[i], path2[i]);
            }
            return distance / count;
        }

        #endregion

    }
}
