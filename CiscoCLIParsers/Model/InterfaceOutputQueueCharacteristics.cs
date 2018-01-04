using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public class InterfaceOutputQueueCharacteristics
    {
        public InterfaceQueueCounters OutputQueue { get; set; }
        public InterfaceOutputQueueConversations Conversations { get; set; }
        public InterfaceOutputQueueReservedConversations ReservedConversations { get; set; }
        public Int64 AvailableBandwidth { get; set; }
    }
}
