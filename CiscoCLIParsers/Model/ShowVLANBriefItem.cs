using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public enum EVLANStatus
    {
        Active, // 'active'
        ActiveUnsupported, // 'act/unsup'
        Suspended, // 'suspended'
        ActiveLocallyShutdown, // 'act/lshut'
        SuspendedLocallyShutdown, // 'sus/lshut'
        ActiveInternallyShutdown, // 'act/ishut'
        SuspectedInternallyShutdown // 'sus/ishut'
    }

    public class ShowVLANBriefItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public EVLANStatus Status { get; set; }
        public List<CiscoInterfaceId> Ports { get; set; }
    }
}
