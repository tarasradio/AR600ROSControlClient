using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR600ROSControlCore.DataTypes.RobotMessages
{
    public class JointsMode
    {
        public List<string> names { get; set; }
        public List<TypeJointMode> modes { get; set; }

        public JointsMode()
        {
            names = new List<string>();
            modes = new List<TypeJointMode>();
        }
    }
}
