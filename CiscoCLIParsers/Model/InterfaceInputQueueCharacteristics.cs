using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public class InterfaceInputQueueCharacteristics
    {
        public InterfaceQueueCounters InputQueue { get; set; }
        public Int64 OutputDrops { get; set; }
        public EQueueingStrategyType Strategy { get; set; }
    }
}
