using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rosbridge.Client;

using AR600ROSControlCore.DataTypes.TransitionActionMessages;
using AR600ROSControlCore.DataTypes.ActionLibMessages;
using Newtonsoft.Json.Linq;

namespace AR600ROSControlCore
{
    public class TransitionControllerClient : IBridgeClient
    {
        public delegate void TransitionFeedbackDelegate(TransitionActionFeedback transitionFeedback);
        public event TransitionFeedbackDelegate updateTransitionFeedback;

        MessageDispatcher dispatcher;

        Publisher publisher_transition_goal;
        Publisher publisher_transition_cancel;
        Subscriber subscriber_transition_feedback;

        public TransitionControllerClient()
        {

        }

        public async Task ConnectAsync(Uri uri)
        {
            dispatcher = new MessageDispatcher(new Socket(uri), new MessageSerializerV2_0());
            await dispatcher.StartAsync();

            publisher_transition_goal = 
                new Publisher("transition_controller/goal", "robot_controllers/TransitionActionGoal", dispatcher);
            await publisher_transition_goal.AdvertiseAsync();

            publisher_transition_cancel = 
                new Publisher("transition_controller/cancel", "actionlib_msgs/GoalID", dispatcher);
            await publisher_transition_cancel.AdvertiseAsync();

            subscriber_transition_feedback =
                new Subscriber("transition_controller/feedback/", "robot_controllers/TransitionActionFeedback", dispatcher);
            subscriber_transition_feedback.MessageReceived += subscriber_transition_feedback_MessageReceived;
            await subscriber_transition_feedback.SubscribeAsync();
        }

        private void subscriber_transition_feedback_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            var message = e.Message;
            updateTransitionFeedback(message["msg"].ToObject<TransitionActionFeedback>());
        }

        public async Task DisconnectAsync()
        {
            await publisher_transition_goal.UnadvertiseAsync();
            await publisher_transition_cancel.UnadvertiseAsync();
            await subscriber_transition_feedback.UnsubscribeAsync();
            await dispatcher.StopAsync();
        }

        public void startTransition(string goal_id, List<string> jointNames)
        {
            TransitionActionGoal goal = new TransitionActionGoal();
            goal.goal_id.id = goal_id;
            goal.goal.names = jointNames;
            for (int i = 0; i < jointNames.Count; i++)
                goal.goal.positions.Add(0.0f);

            JObject goalMsg = JObject.FromObject(goal);

            publisher_transition_goal.PublishAsync(goalMsg);
        }

        public void cancelTransition(string goal_id)
        {
            GoalID cancel = new GoalID();
            cancel.id = goal_id;
            JObject cancelMsg = JObject.FromObject(cancel);
            publisher_transition_cancel.PublishAsync(cancelMsg);
        }
    }
}
