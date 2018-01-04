using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    

    
    public class ShowIPRouteLastResort
    {
        public IPAddress Gateway { get; set; }
        public IPAddress Network { get; set; }
    }

    public class ShowIPRouteCode
    {
        public bool NextHopOverride { get; set; }
        public ERoutingProtocol Protocol { get; set; }
        public ERoutingProtocol Suffix { get; set; }
        public bool Candidate { get; set; }
        public bool Replicated { get; set; }
    }

    public class NetworkRouteMetric
    {
        public bool DirectlyConnected { get; set; }
        public Int64 AdministrativeDistance { get; set; }
        public Int64 Metric { get; set; }
    }

    public class ShowIPRouteNextHop
    {
        public bool NextHopOverride { get; set; }
        public NetworkRouteMetric RouteMetric { get; set; }
        public IPAddress Via { get; set; }
        public DateTime Uptime { get; set; }
        public CiscoInterfaceId OutgoingInterface { get; set; }
    }

    public class ShowIPRouteEntryItem
    {
        public ShowIPRouteCode Code { get; set; }
        public NetworkPrefix Prefix { get; set; }
        public List<ShowIPRouteNextHop> NextHops { get; set; }
    }

    public class ShowIPRouteEntry
    {
        public ShowIPRouteLastResort LastResort { get; set; }
        public List<ShowIPRouteEntryItem> Routes { get; set; }
    }
}
