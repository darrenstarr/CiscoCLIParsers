using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public class ShowIPARPEntry
    {
        public EProtocolAddressFamily Protocol { get; set; }
        public IPAddress L3Address { get; set; }
        public PhysicalAddress L2Address { get; set; }
        public TimeSpan Age { get; set; }
        // TODO : Is Type in this context encapsulation or L2 address type?
        public ELayer2Encapsulation L2AddressType { get; set; }
        public CiscoInterfaceId Interface { get; set; }
    }
}
