using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public class InterfaceInputStatistics
    {
        public Int64 PacketsInput { get; set; }
        public Int64 PacketsInputNoBuffer { get; set; }
        public Int64 BroadcastsInput { get; set; }
        public Int64 MulticastsInput { get; set; }
        public Int64 Runts { get; set; }
        public Int64 Giants { get; set; }
        public Int64 Throttles { get; set; }
        public Int64 InputErrors { get; set; }
        public Int64 InputCRC { get; set; }
        public Int64 InputFrame { get; set; }
        public Int64 InputOverrun { get; set; }
        public Int64 InputIgnored { get; set; }
        public Int64 InputAbort { get; set; }
        public Int64 WatchDog { get; set; }
        public Int64 InputMulticast { get; set; }
        public Int64 PauseInput { get; set; }
        public Int64 InputDribbleCondition { get; set; }

    }
}
