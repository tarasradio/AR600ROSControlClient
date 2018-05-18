using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AR600ROSControlCore.DataTypes.RobotMessages;

namespace AR600ROSControlCore.TypeConverters
{
    public class TypeJointModeConverter
    {
        static string[] names = { "BREAK", "STOP", "RELAX", "TRACE" };

        public static string getString(TypeJointMode mode)
        {
            return names[(int)mode.mode];
        }
    }
}
