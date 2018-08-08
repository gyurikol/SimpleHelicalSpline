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
        private HelicalSpline hs;
        private clockDirection direction;
        private double currentAngle;

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

            // intialize helical spline
            hs = new HelicalSpline(rotations);
        }

        /// <summary>
        /// Function to encapsulate the compile of Spline points
        /// </summary>
        private void CompileSplinePoints()
        {
            while( hs.NullPoints() != 0)
            {

            }
        }

        /// <summary>
        /// Get Current X coordinate based on current angle
        /// </summary>
        /// <param name="angle">Angle being currently assessed</param>
        /// <returns>Returns X coordinate</returns>
        private double GetXCoordinate(double angle)
        {
            return ( (diameter / 2) * Math.Cos(angle) );
        }

        /// <summary>
        /// Get Current Y coordinate based on current angle
        /// </summary>
        /// <param name="angle">Angle being currently assessed</param>
        /// <returns>Returns X coordinate</returns>
        private double GetYCoordinate(double angle)
        {
            return ((diameter / 2) * Math.Sin(angle) );
        }

        /// <summary>
        /// Progress Angle to align for next Point assessment.
        /// </summary>
        private void SetNextAngle()
        {

        }
    }
}
