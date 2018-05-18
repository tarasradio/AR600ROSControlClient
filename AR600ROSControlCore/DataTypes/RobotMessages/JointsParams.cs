using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR600ROSControlCore.DataTypes.RobotMessages
{
    public class JointsParams
    {
        public List<string> names { get; set; }
        public List<bool> enabled { get; set; }
        public List<float> lower_limit { get; set; }
        public List<float> upper_limit { get; set; }
        public List<float> offset { get; set; }
        public List<bool> reverse { get; set; }
        public List<TypeJointMode> mode { get; set; }
        public List<TypePid> pids { get; set; }

        public JointsParams()
        {
            names = new List<string>();
            enabled = new List<bool>();
            lower_limit = new List<float>();
            upper_limit = new List<float>();
            offset = new List<float>();
            reverse = new List<bool>();
            mode = new List<TypeJointMode>();
            pids = new List<TypePid>();
        }
    }
}
