using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHelicalSpline.Classes
{
    /// <summary>
    /// Helical Spline class to Cater as a container for the points in space.
    /// </summary>
    class HelicalSpline
    {
        public const double ROTATION_FREQUENCY = 1/72; //((2 * Math.PI) / 72); 5 degrees
        private Point[] points;
        private int currentPointCount = 0;

        /// <summary>
        /// Helical Spline constructor
        /// </summary>
        /// <param name="rotations">Amount of rotations the spline will perform</param>
        public HelicalSpline(double rotations)
        {
            // initialize points array with size
            SetPointCount(rotations);
        }

        /// <summary>
        /// Sets the amount of points to occur in the helical spline
        /// </summary>
        /// <param name="rotations">Amount of rotations the spline will perform</param>
        private void SetPointCount(double rotations)
        {
            // get point occurence count
            double occuredPoints = (rotations * 360) / ROTATION_FREQUENCY;

            // set points array size
            points = new Point[Convert.ToInt32( Math.Floor(occuredPoints) )];
        }

        /// <summary>
        /// Adds a point to the Helical Spline
        /// </summary>
        /// <param name="p">Point in space to add to helical Spline</param>
        /// <returns>True if point was able to be added to Helical Spline</returns>
        public bool AddPoint(Point p)
        {
            if (currentPointCount <= (points.Length - 1))
            {
                points[currentPointCount] = p;
                currentPointCount++;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Outputs all points in sequential order
        /// </summary>
        /// <returns>List of points</returns>
        public override string ToString()
        {
            string fileOutput = String.Empty;
            foreach(Point p in points)
            {
                fileOutput += p.ToString() + Environment.NewLine;
            }
            return fileOutput;
        }

        /// <summary>
        /// Function that returns the amount of point spaces still requiring to be filled.
        /// </summary>
        /// <returns>Primitive Integer of remaining point slots to be filled</returns>
        public int NullPoints()
        {
            return points.Length - currentPointCount;
        }
    }
}
