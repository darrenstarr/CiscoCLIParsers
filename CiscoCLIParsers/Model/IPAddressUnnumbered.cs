using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public class IPAddressUnnumbered
    {
        public System.Net.IPAddress Address { get; set; }
        public CiscoInterfaceId Interface { get; set; }
    }
}
