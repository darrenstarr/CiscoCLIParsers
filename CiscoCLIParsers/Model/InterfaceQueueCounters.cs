using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public class InterfaceQueueCounters
    {
        // TODO : Consider making one for Input and one for Output
        public Int64 Size { get; set; }
        public Int64 Max { get; set; }
        public Int64 Drops { get; set; }
        public Int64 Flushed { get; set; }
        public Int64 Threshold { get; set; }
    }
}
