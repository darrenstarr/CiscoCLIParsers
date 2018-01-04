using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public class ShowInterfacesItem
    {
        public CiscoInterfaceId InterfaceId { get; set; }
        public EInterfaceStatus LineStatus { get; set; }
        public EInterfaceStatus ProtocolStatus { get; set; }
        public NetworkPrefix IPv4Address { get; set; }
        public InterfaceHardware Hardware { get; set; }
        public string Description { get; set; }
        public InterfaceMetrics Metrics { get; set; }
        public ELayer2Encapsulation Layer2Encapsulation { get; set; }
        public ELoopbackSetting LoopbackSetting { get; set; }
        public InterfaceKeepaliveSettings Keepalive { get; set; }
        public Layer2ProtocolProperties ProtocolProperties { get; set; }
        public EFlowControlType InputFlowControl { get; set; }
        public EFlowControlType OutputFlowControl { get; set; }
        public List<CiscoInterfaceId> PortChannelMembers { get; set; }
        public ARPStatistics ARPStats { get; set; }
        public InterfaceStatistics Statistics { get; set; }
    }
}
