using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
namespace ExpressionParser
{
    class NDollarRecognizer
    {
        #region Parameters

        public Result result;

        #endregion

        //Constructor
        public NDollarRecognizer(String name, List<List<Point>> strokes, List<Multistroke> multistrokes, bool useBoundedRotationInvariance)
        {
            this.result = recognize(name, strokes, multistrokes, useBoundedRotationInvariance);
        }

        #region The $N Recognizer

        public Result recognize(String name, List<List<Point>> strokes, List<Multistroke> multistrokes, bool useBoundedRotationInvariance)
        {
            List<Point> points = CombineStrokes(strokes);
            Template newTemp = new Template(name, points, useBoundedRotationInvariance);
            points = newTemp.Points; 
            Point startv = newTemp.StartUnitVector;
            double angleRange = Deg2Rad(45.0);
            double anglePrecision = Deg2Rad(2.0);
            double angleSimilarityThreshold = Deg2Rad(30.0);
            double b = double.MaxValue;
            double squareSize = 250.0;
            double diagonal = Math.Sqrt((squareSize * squareSize) + (squareSize * squareSize));
            double halfDiagonal = 0.5 * diagonal;
            int u = -1;

            for (int i = 0; i < multistrokes.Count; i++) //foreach multi stroke
            {
                //if (strokes.Count == multiStroke.NumStrokes)// optional -- only attempt match when same # of component strokes
                //{
                for (int j = 0; j < multistrokes[i].temps.Count; j++)
                    {
                        // strokes start in the same direction
                        if (AngleBetweenUnitVectors(startv, multistrokes[i].temps[j].StartUnitVector) <= angleSimilarityThreshold)
                        {
                            // Golden Section Search
                            double d = DistanceAtBestAngle(points, multistrokes[i].temps[j], -angleRange, +angleRange, anglePrecision);
                            if (d < b)
                            {
                                b = d; // best (least) distance
                                u = i; // multistroke owner of unistroke
                            }
                        }
                        
                    }
                //}
            }
            return (u == -1) ? new Result("No match.", 0.0) : new Result(multistrokes[u].Name, 1.0 - b / halfDiagonal);
        }


        // gives acute angle between unit vectors from (0,0) to v1, and (0,0) to v2
        public double AngleBetweenUnitVectors(Point v1, Point v2)
        {
            double test = (v1.X * v2.X) + (v1.Y * v2.Y); // arc cosine of the vector dot product
            // sometimes these two cases can happen because of rounding error in the dot product calculation
            if (test < -1.0)
                test = -1.0; // truncate rounding errors
            if (test > 1.0)
                test = 1.0; // truncate rounding errors
            return Math.Acos(test);
        }

        public double DistanceAtBestAngle(List<Point> points, Template T, double a, double b, double threshold)
        {
            double Phi = 0.5 * (-1.0 + Math.Sqrt(5.0)); // Golden Ratio
            double x1 = (Phi * a) + ((1.0 - Phi) * b);
            double f1 = DistanceAtAngle(points, T, x1);
            double x2 = ((1.0 - Phi) * a) + (Phi * b);
            double f2 = DistanceAtAngle(points, T, x2);
            while (Math.Abs(b - a) > threshold)
            {
                if (f1 < f2)
                {
                    b = x2;
                    x2 = x1;
                    f2 = f1;
                    x1 = (Phi * a) + ((1.0 - Phi) * b);
                    f1 = DistanceAtAngle(points, T, x1);
                }
                else
                {
                    a = x1;
                    x1 = x2;
                    f1 = f2;
                    x2 = ((1.0 - Phi) * a) + (Phi * b);
                    f2 = DistanceAtAngle(points, T, x2);
                }
            }
            return Math.Min(f1, f2);
        }

        public double DistanceAtAngle(List<Point> points, Template T, double radians)
        {

            List<Point> newPoints = Template.RotateByRadians(points, radians);
            return Template.PathDistance(newPoints, T.Points);
        }

        public double Deg2Rad(double d) { return (d * Math.PI / 180.0); }

        public double Rad2Deg(double r) { return (r * 180.0 / Math.PI); }

        public List<Point> CombineStrokes(List<List<Point>> strokes)
        {
            List<Point> points = new List<Point>(); //list of point lists
            foreach (List<Point> stroke in strokes)
            {
                foreach (Point point in stroke)
                {
                    points.Add(point);
                }
            }
            return points;
        }

        #endregion

    }
}
