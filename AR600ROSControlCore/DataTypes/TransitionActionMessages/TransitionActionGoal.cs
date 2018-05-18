using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AR600ROSControlCore.DataTypes.ActionLibMessages;

namespace AR600ROSControlCore.DataTypes.TransitionActionMessages
{
    public class TransitionActionGoal
    {
        public GoalID goal_id { get; set; }

        public TransitionGoal goal { get; set; }

        public TransitionActionGoal()
        {
            goal_id = new GoalID();
            goal = new TransitionGoal();
        }
    }
}
