using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR600ROSControlGUI.Utils
{
    public class AngleConverter
    {
        public static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }

        public static double RadianToDegrees(double radian)
        {
            return radian * 180.0 / Math.PI;
        }
    }
}
