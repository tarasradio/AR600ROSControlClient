using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR600ROSControlCore.DataTypes.RobotMessages
{
    public class FeetSensors
    {
        public TypeFootSensor left { get; set; }
        public TypeFootSensor right { get; set; }

        public FeetSensors()
        {
            left = new TypeFootSensor();
            right = new TypeFootSensor();
        }
    }
}
