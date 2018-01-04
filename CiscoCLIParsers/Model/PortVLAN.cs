using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public class PortVLAN
    {
        public ESwitchportMode Type { get; set; }
        public int VlanId { get; set; }
    }
}
