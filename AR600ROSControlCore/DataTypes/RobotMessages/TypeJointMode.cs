using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR600ROSControlCore.DataTypes.RobotMessages
{
    public class TypeJointMode
    {
        public enum JointMode
        {
            BREAK,
            STOP,
            RELAX,
            TRACE
        };

        public JointMode mode { get; set; }
    }
}
