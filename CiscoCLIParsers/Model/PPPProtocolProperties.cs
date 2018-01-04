using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public class PPPProtocolProperties : Layer2ProtocolProperties
    {
        public ELinkControlProtocolState LCPState { get; set; }
        public EMultilinkState MultilinkState { get; set; }
    }
}
