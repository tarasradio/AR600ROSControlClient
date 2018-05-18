using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR600ROSControlCore.DataTypes.RobotMessages
{
    public class JointsSupplyState
    {
        public List<string> names { get; set; }
        public List<TypeSupplyState> states { get; set; }

        public JointsSupplyState()
        {
            names = new List<string>();
            states = new List<TypeSupplyState>();
        }
    }
}
