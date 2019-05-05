/*
This message class is generated automatically with 'SimpleMessageGenerator' of ROS#
*/

using Newtonsoft.Json;
using RosSharp.RosBridgeClient.Messages.geometry_msgs;
using RosSharp.RosBridgeClient.Messages.nav_msgs;
using RosSharp.RosBridgeClient.Messages.sensor_msgs;
using RosSharp.RosBridgeClient.Messages.std_msgs;
using RosSharp.RosBridgeClient.Messages.actionlib_msgs;

namespace RosSharp.RosBridgeClient.Messages.actionlib_tutorials
{
    public class FibonacciActionFeedback : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "actionlib_tutorials/FibonacciActionFeedback";

        public Header header;
        public GoalStatus status;
        public FibonacciFeedback feedback;

        public FibonacciActionFeedback()
        {
            header = new Header();
            status = new GoalStatus();
            feedback = new FibonacciFeedback();
        }
    }
}

