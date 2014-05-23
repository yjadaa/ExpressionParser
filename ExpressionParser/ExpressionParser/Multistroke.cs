using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace ExpressionParser
{
    // Multistroke class: a container for unistroke templates
    class Multistroke
    {
        #region Parameters

        public string Name;
        public int NumStrokes = -1; // how many strokes this multistroke has
        public List<Template> temps;// all possible orderings/directions of this multistroke gesture 

        #endregion

        //Constructor
        public Multistroke(string name, bool useBoundedRotationInvariance, List<List<Point>> strokes)
        {
            this.Name = name;
            this.NumStrokes = strokes.Count;
            List<int> order = new List<int>(strokes.Count); // list of integer indices
            for (int i = 0; i < strokes.Count; i++)
            {
                order.Add(i); // initialize
            }
            List<List<int>> orders = new List<List<int>>(); // list of integer lists

            // HeapPermute operates on the indices
            HeapPermute(this.NumStrokes, order, orders);// now orders should contain all possible permutations of the stroke indices

            List<List<Point>> unistrokes = MakeUnistrokes(strokes, orders); // returns list of point lists

            this.temps = new List<Template>();  // unistrokes for this multistroke
            foreach (List<Point> entry in unistrokes)
            {
                Template newT = new Template(name, entry, useBoundedRotationInvariance);
                this.temps.Add(newT);
            }
        }

        #region Make Uni Stroke

        public List<List<Point>> MakeUnistrokes(List<List<Point>> originalStrokes, List<List<int>> allOrderings)
        {
            List<List<Point>> allUnistrokes = new List<List<Point>>(); //list of point lists
            foreach (List<int> ordering in allOrderings)
            {
                for (int b = 0; b < Math.Pow(2, ordering.Count); b++) // decimal value b
                {
                    List<Point> unistroke = new List<Point>(); // we're building a unistroke instead of multistroke now for ease of processing
                    for (int i = 0; i < ordering.Count; i++) // examine b's bits
                    {
                        // copy the correct unistroke
                        List<Point> stroke = new List<Point>(originalStrokes[(int)ordering[i]]);
                        if (((b >> i) & 1) == 1) // if (BitAt(b, i) == 1), i.e., is b's bit at index i on?
                        {
                            stroke.Reverse(); // reverse the strokes
                        }
                        unistroke.AddRange(stroke); // add stroke to current strokePermute
                    }
                    // add completed strokePermute to set of strokePermutes (aka Multistrokes)
                    allUnistrokes.Add(unistroke);
                }
            }
            return allUnistrokes;
        }
        
        #endregion

        #region Heap Permute

        public void HeapPermute(int n, List<int> currentOrder, List<List<int>> allOrders)
        {
            if (n == 1) // base case
            {
                // build return value to be an ArrayList containing 1 ArrayList (strokes) of ArrayLists (points)
                allOrders.Add(new List<int>(currentOrder)); // copy
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    // recurse here, building up set of lists
                    HeapPermute(n - 1, currentOrder, allOrders);
                    if ((n % 2) == 1)           // odd n
                    {
                        SwapStrokes(0, n - 1, currentOrder);
                    }
                    else                        // even n
                    {
                        SwapStrokes(i, n - 1, currentOrder);
                    }
                }
            }
        }

        // swap the strokes given by the indices "first" and "second" in the
        // "order" argument; this DOES change the ArrayList sent as an argument.
        private void SwapStrokes(int first, int second, List<int> order)
        {
            int temp = order[first];
            order[first] = order[second];
            order[second] = temp;
        }

        #endregion
    }
}
