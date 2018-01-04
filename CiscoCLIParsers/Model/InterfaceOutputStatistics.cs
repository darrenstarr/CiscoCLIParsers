using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public class InterfaceOutputStatistics
    {
        public Int64 PacketsOutput { get;  set; }
        public Int64 PacketsOutputBytes { get; set; }
        public Int64 Underruns { get; set; }
        public Int64 OutputErrors { get; set; }
        public Int64 Collisions { get; set; }
        public Int64 InterfaceResets { get; set; }
        public Int64 UnknownProtocolDrops { get; set; }
        public Int64 Babbles { get; set; }
        public Int64 LateCollisions { get; set; }
        public Int64 Deferred { get; set; }
        public Int64 LostCarrier { get; set; }
        public Int64 NoCarrier { get; set; }
        public Int64 PauseOutput { get; set; }
        public Int64 OutputBufferFailures { get; set; }
        public Int64 OutputBuffersSwappedOut { get; set; }
        public Int64 CarrierTransitions { get; set; }
    }
}
