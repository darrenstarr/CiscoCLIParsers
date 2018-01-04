using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public class ShowInterfaceStatusItem
    {
        public CiscoInterfaceId Interface { get; set; }
        public string Description { get; set; }
        public EConnectionState ConnectionState { get; set; }
        public ESwitchportMode Type { get; set; }
        public int VlanId { get; set; }
        public bool AutoDuplex { get; set; }
        public EDuplex Duplex { get; set; }
        public bool AutoSpeed { get; set; }
        public Int64 Speed { get; set; }
        public EEthernetMediaType MediaType { get; set; }
    }
}
