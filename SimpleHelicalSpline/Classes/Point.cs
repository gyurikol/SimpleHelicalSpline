using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHelicalSpline.Classes
{
    /// <summary>
    /// Point class for a simple assignment of x, y and z coordinates with the intent for output strategies.
    /// </summary>
    class Point
    {
        private double x, y, z;

        /// <summary>
        /// Constructor for the point class
        /// </summary>
        /// <param name="X">Value of coordinate X</param>
        /// <param name="Y">Value of coordinate Y</param>
        /// <param name="Z">Value of coordinate Z</param>
        public Point(double X, double Y, double Z)
        {
            this.x = X;
            this.y = Y;
            this.z = Z;
        }
        
        /// <summary>
        /// To String overide for the purpose of computer aided design software
        /// </summary>
        /// <returns>Series of XYZ prefix and their Values for a point in 3d space</returns>
        public override string ToString()
        {
            return String.Format("X{0}Y{1}Z{2}",
                    ToThreeDecimalPlaces(this.x),
                    ToThreeDecimalPlaces(this.y),
                    ToThreeDecimalPlaces(this.z)
                );
        }

        /// <summary>
        /// Returns string of value in forced three decimal place form
        /// </summary>
        /// <param name="value">Double value to be converted to three decimal place strixng</param>
        /// <returns>Three Decimal place double as string</returns>
        private string ToThreeDecimalPlaces(double value)
        {
            return String.Format("{F3}", value);
        }
    }
}
