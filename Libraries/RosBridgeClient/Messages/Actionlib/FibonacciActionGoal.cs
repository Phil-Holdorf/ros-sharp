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
    public class FibonacciActionGoal : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "actionlib_tutorials/FibonacciActionGoal";

        public Header header;
        public GoalID goal_id;
        public FibonacciGoal goal;

        public FibonacciActionGoal()
        {
            header = new Header();
            goal_id = new GoalID();
            goal = new FibonacciGoal();
        }
    }
}

