using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using Rosbridge.Client;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using AR600ROSControlCore.DataTypes.RobotMessages;
using AR600ROSControlCore.DataTypes.SensorMessages;


namespace AR600ROSControlCore
{
    public class RobotDriverClient : IBridgeClient
    {
        public delegate void JointsParamsDelegate(JointsParams jointsParams);
        public event JointsParamsDelegate updateJointParams;

        public delegate void SourcesStateDelegate(SourcesSupplyState sourcesState);
        public event SourcesStateDelegate updateSourcesState;

        public delegate void JointStateDelegate(JointState jointState);
        public event JointStateDelegate updateJointState;
        
        MessageDispatcher dispatcher;
        public JointsParams jointsParams_ = new JointsParams();

        Subscriber subscriber_joints_params;
        Subscriber subscriber_joints_state;
        Subscriber subscriber_sources_state;

        public RobotDriverClient()
        {

        }

        public async Task ConnectAsync(Uri uri)
        {
            dispatcher = new MessageDispatcher(new Socket(uri), new MessageSerializerV2_0());
            await dispatcher.StartAsync();

            subscriber_joints_params = 
                new Subscriber("joints/get_params/", "robot_msgs/JointsParams", dispatcher);
            subscriber_joints_params.MessageReceived += Subscriber_joints_params_MessageReceived;
            await subscriber_joints_params.SubscribeAsync();

            subscriber_sources_state = 
                new Subscriber("power/sources_state/", "robot_msgs/SourcesSupplyState", dispatcher);
            subscriber_sources_state.MessageReceived += Subscriber_sources_state_MessageReceived;
            await subscriber_sources_state.SubscribeAsync();

            subscriber_joints_state =
                new Subscriber("joints/state/", "sensor_msgs/JointState", dispatcher);
            subscriber_joints_state.MessageReceived += Subscriber_joints_state_MessageReceived;
            await subscriber_joints_state.SubscribeAsync();
        }

        public async Task DisconnectAsync()
        {
            await subscriber_joints_params.UnsubscribeAsync();
            await subscriber_sources_state.UnsubscribeAsync();
            await subscriber_joints_state.UnsubscribeAsync();
            await dispatcher.StopAsync();
        }
        
        private void Subscriber_joints_state_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            var message = e.Message;
            updateJointState(message["msg"].ToObject<JointState>());
        }

        private void Subscriber_sources_state_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            var message = e.Message;
            updateSourcesState(message["msg"].ToObject<SourcesSupplyState>());
        }
        
        private void Subscriber_joints_params_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            var message = e.Message;
            jointsParams_ = message["msg"].ToObject<JointsParams>();
            updateJointParams(jointsParams_);
        }
    }
}
