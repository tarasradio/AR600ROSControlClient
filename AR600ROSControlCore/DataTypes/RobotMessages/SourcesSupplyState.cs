using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR600ROSControlCore.DataTypes.RobotMessages
{
    public class SourcesSupplyState
    {
        public TypeSupplyState S48 { get; set; }
        public TypeSupplyState S12 { get; set; }
        public TypeSupplyState S8_1 { get; set; }
        public TypeSupplyState S8_2 { get; set; }
        public TypeSupplyState S6_1 { get; set; }
        public TypeSupplyState S6_2 { get; set; }

        public SourcesSupplyState()
        {
            S48 = new TypeSupplyState();
            S12 = new TypeSupplyState();
            S8_1 = new TypeSupplyState();
            S8_2 = new TypeSupplyState();
            S6_1 = new TypeSupplyState();
            S6_2 = new TypeSupplyState();
        }
    }
}
