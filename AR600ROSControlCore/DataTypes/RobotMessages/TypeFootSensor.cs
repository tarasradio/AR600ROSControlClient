using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR600ROSControlCore.DataTypes.RobotMessages
{
    public class TypeFootSensor
    {
        public float tx { get; set; }
        public float ty { get; set; }
        public float fz { get; set; }
        public float uch0 { get; set; }
        public float uch1 { get; set; }
        public float uch2 { get; set; }
        public float uch3 { get; set; }
    }
}
