using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public class EthernetProtocolProperties : Layer2ProtocolProperties
    {
        public EDuplex Duplex { get; set; }
        public EthernetSpeed Speed { get; set; }
        public EEthernetLinkType LinkType { get; set; }
        public EEthernetMediaType MediaType { get; set; }
    }
}
