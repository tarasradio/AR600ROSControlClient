using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR600ROSControlCore.DataTypes.TransitionActionMessages
{
    public class TransitionGoal
    {
        public List<string> names { get; set; }
        public List<float> positions { get; set; }

        public TransitionGoal()
        {
            names = new List<string>();
            positions = new List<float>();
        }
    }
}
