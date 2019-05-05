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
    public class FibonacciResult : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "actionlib_tutorials/FibonacciResult";

        public int[] sequence;

        public FibonacciResult()
        {
            sequence = new int[0];
        }
    }
}

