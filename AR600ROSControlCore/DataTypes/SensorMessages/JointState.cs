using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR600ROSControlCore.DataTypes.SensorMessages
{
    public class JointState
    {
        public List<string> name { get; set; }
        public List<double> position { get; set; }
        public List<double> velocity { get; set; }
        public List<double> effort { get; set; }

        public JointState()
        {
            name = new List<string>();
            position = new List<double>();
            velocity = new List<double>();
            effort = new List<double>();
        }
    }
}
