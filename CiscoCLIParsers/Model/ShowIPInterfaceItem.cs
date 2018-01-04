using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public class ShowIPInterfaceItem
    {
        public CiscoInterfaceId InterfaceId { get; set; }
        public EInterfaceStatus LineStatus { get; set; }
        public EInterfaceStatus ProtocolStatus { get; set; }
        public EEnabledState InternetProtocolParsing { get; set; }
        public NetworkPrefix InternetAddress { get; set; }
        public IPAddressUnnumbered InternetAddressUnnumbered { get; set; }
        public IPAddress BroadcastAddress { get; set; }
        public EAddressAssignmentMethod AddressDeterminedBy { get; set; }
        public int MTU { get; set; }
        public IPAddress HelperAddress { get; set; }
        public EEnabledState DirectedBroadcastForwarding { get; set; }
        public List<IPAddress> MulticastReservedGroupsJoined { get; set; }
        public string OutgoingAccessList { get; set; }
        public string InboundAccessList { get; set; }
        public EEnabledState ProxyARP { get; set; }
        public EEnabledState LocalProxyARP { get; set; }
        public EIPSecurityLevelSetting SecurityLevel { get; set; }
        public EEnabledState SplitHorizon { get; set; }
        public ESentWhen ICMPRedirects { get; set; }
        public ESentWhen ICMPUnreachables { get; set; }
        public ESentWhen ICMPMaskReplies { get; set; }
        public EEnabledState IPFastSwitching { get; set; }
        public EEnabledState IPFastSwitchingOnSameInterface { get; set; }
        public EEnabledState IPFlowSwitching { get; set; }
        public EEnabledState IPCEFSwitching { get; set; }
        public EEnabledState IPCEFSwitchingTurboVector { get; set; }
        public EEnabledState IPNullTurboVector { get; set; }
        public EEnabledState IPMulticastFastSwitching { get; set; }
        public EEnabledState IPMulticastDistributedFastSwitching { get; set; }
        public List<EIPRouteCacheFlag> IPRouteCacheFlags { get; set; }
        public EEnabledState RouterDiscovery { get; set; }
        public EEnabledState IPOutputPacketAccounting { get; set; }
        public EEnabledState IPAccessViolationAccounting { get; set; }
        public EEnabledState TCPIPHeaderCompression { get; set; }
        public EEnabledState RTPIPHeaderCompression { get; set; }
        public EEnabledState ProbeProxyNames { get; set; }
        public EEnabledState PolicyRouting { get; set; }
        public EEnabledState NetworkAddressTranslation { get; set; }
        public EEnabledState BGPPolicyMapping { get; set; }
        public List<EInterfaceIPInputFeature> InputFeatures { get; set; }
        public List<EInterfaceIPOutputFeature> OutputFeatures { get; set; }
        public EEnabledState WCCPRedirectOutbound { get; set; }
        public EEnabledState WCCPRedirectInbound { get; set; }
        public EEnabledState WCCPRedirectExclude { get; set; }
    }
}

