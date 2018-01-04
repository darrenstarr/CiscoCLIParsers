using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public class CiscoInterfaceId
    {
        public EInterfaceType InterfaceType { get; set; }
        public CiscoInterfaceNumber InterfaceNumber { get; set; }

        public override string ToString()
        {
            return InterfaceType.ToString() + InterfaceNumber.ToString();
        }
    }
}
