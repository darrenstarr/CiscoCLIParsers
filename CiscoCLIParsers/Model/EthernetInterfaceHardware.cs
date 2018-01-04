using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public class EthernetInterfaceHardware : InterfaceHardware
    {
        public EInterfaceType HardwareType { get; set; } = EInterfaceType.Null;
        public EEthernetChipType ChipType { get; set; } = EEthernetChipType.Unspecified;
        public PhysicalAddress MACAddress { get; set; }
        public PhysicalAddress BurnedInAddress { get; set; }
    }
}
