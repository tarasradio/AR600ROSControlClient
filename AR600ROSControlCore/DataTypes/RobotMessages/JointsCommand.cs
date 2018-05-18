using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR600ROSControlCore.DataTypes.RobotMessages
{
    public class JointsCommand
    {
        public List<string> names { get; set; }
        public List<float> positions { get; set; }
        public List<TypePid> pids { get; set; }

        public JointsCommand()
        {
            names = new List<string>();
            positions = new List<float>();
            pids = new List<TypePid>();
        }
    }
}
