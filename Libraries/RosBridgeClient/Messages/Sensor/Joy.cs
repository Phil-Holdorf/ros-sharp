﻿/*
© Siemens AG, 2017-2018
Author: Dr. Martin Bischoff (martin.bischoff@siemens.com)

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
<http://www.apache.org/licenses/LICENSE-2.0>.
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.sensor_msgs
{
    public class Joy : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "sensor_msgs/Joy";
        public std_msgs.Header header;
        public float[] axes;
        public int[] buttons;

        public Joy()
        {
            header = new std_msgs.Header();
            axes = new float[0];
            buttons = new int[0];
        }
    }
}