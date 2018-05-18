using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR600ROSControlCore.DataTypes.RobotMessages
{
    public class TypePid
    {
        public float p { get; set; }
        public float i { get; set; }
        public float d { get; set; }
        public float i_min { get; set; }
        public float i_max { get; set; }
    }
}
