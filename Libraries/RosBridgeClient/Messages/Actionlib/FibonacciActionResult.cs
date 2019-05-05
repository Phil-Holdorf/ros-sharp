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
    public class FibonacciActionResult : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "actionlib_tutorials/FibonacciActionResult";

        public Header header;
        public GoalStatus status;
        public FibonacciResult result;

        public FibonacciActionResult()
        {
            header = new Header();
            status = new GoalStatus();
            result = new FibonacciResult();
        }
    }
}

