using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHelicalSpline.Classes
{
    /// <summary>
    /// Class used to build helical Spline.
    /// </summary>
    class HSBuilder
    {
        /// <summary>
        /// Enum specifying for Clockwise or Counter-Clockwise rotations
        /// </summary>
        public enum clockDirection
        {
            CW,
            CCW
        }

        // Helical Spline variables
        private double diameter, rotations, pitch;
        private double zChangePerPoint;
        private HelicalSpline hs;
        private clockDirection direction;
        private double currentAngle;
        private int directionFlag;

        /// <summary>
        /// Constructor for the Helical Spline builder
        /// </summary>
        /// <param name="diameter">Diameter of the spline</param>
        /// <param name="rotations">Amount of rotations for the spline to perform</param>
        /// <param name="pitch">Pitch of the Spline</param>
        /// <param name="direction">Clock like direction of the spline</param>
        public HSBuilder(double Diameter, double Rotations, double Pitch, clockDirection Direction )
        {
            // set helical spline variables
            diameter = Diameter;
            rotations = Rotations;
            pitch = Pitch;
            direction = Direction;

            // set helical spline direction
            if(Direction == clockDirection.CW)
            { directionFlag = -1; }
            else
            { directionFlag = 1; }

            // set the change in z per point
            SetZChangeValue();

            // intialize helical spline
            hs = new HelicalSpline(rotations);

            // create helical spline
            CompileSplinePoints();
        }

        /// <summary>
        /// Function to encapsulate the compile of Spline points
        /// </summary>
        private void CompileSplinePoints()
        {
            while( hs.NullPoints() != 0)
            {
                hs.AddPoint( CreateCurrentPoint() );    // add point to helical spline
                SetNextAngle();     // progress to next angle
            }
        }

        /// <summary>
        /// Get Current X coordinate based on current angle
        /// </summary>
        /// <param name="angle">Angle being currently assessed</param>
        /// <returns>X coordinate</returns>
        private double GetXCoordinate(double angle)
        {
            return ( (diameter / 2) * Math.Cos(angle * directionFlag) );
        }

        /// <summary>
        /// Get Current Y coordinate based on current angle
        /// </summary>
        /// <param name="angle">Angle being currently assessed</param>
        /// <returns>X coordinate</returns>
        private double GetYCoordinate(double angle)
        {
            return ((diameter / 2) * Math.Sin(angle * directionFlag) );
        }

        /// <summary>
        /// Get the z coordinate for the current point based on angular progress
        /// </summary>
        /// <param name="angle">Angle being currently assessed</param>
        /// <returns>Z coordinate</returns>
        private double GetZCoordinate(double angle)
        {
            return hs.CurrentPoint * zChangePerPoint;
        }

        /// <summary>
        /// Set the change in z axis per point
        /// </summary>
        private void SetZChangeValue()
        {
            zChangePerPoint = pitch * HelicalSpline.ROTATION_FREQUENCY * -1;
        }

        /// <summary>
        /// Progress Angle to align for next Point assessment.
        /// </summary>
        private void SetNextAngle()
        {
            currentAngle += ((2 * Math.PI) * HelicalSpline.ROTATION_FREQUENCY);
        }

        /// <summary>
        /// Function to create Current Point based on current assessment.
        /// </summary>
        /// <returns>Returns Current Point</returns>
        private Point CreateCurrentPoint()
        {
            return new Point(
                GetXCoordinate(currentAngle),
                GetYCoordinate(currentAngle),
                GetZCoordinate(currentAngle)
                );
        }

        /// <summary>
        /// Uses helical sline toString to return full helical spline
        /// </summary>
        /// <returns>String of total helical Spline</returns>
        public string GetHelicalSplineFileData()
        {
            return hs.ToString();
        }
    }
}
