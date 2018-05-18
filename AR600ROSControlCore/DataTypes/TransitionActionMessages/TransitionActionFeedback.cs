using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AR600ROSControlCore.DataTypes.ActionLibMessages;

namespace AR600ROSControlCore.DataTypes.TransitionActionMessages
{
    public class TransitionActionFeedback
    {
        //public GoalID goal_id { get; set; }
        public TransitionFeedback feedback { get; set; }

        public TransitionActionFeedback()
        {
            //goal_id = new GoalID();
            feedback = new TransitionFeedback();
        }
    }
}
