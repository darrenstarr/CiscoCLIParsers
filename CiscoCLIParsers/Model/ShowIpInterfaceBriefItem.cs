using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace CiscoCLIParsers.Model
{
    public class ShowIpInterfaceBriefItem
    {
        public CiscoInterfaceId InterfaceId { get; set; } = null;
        public IPAddress Address { get; set; } = null;
        public bool Ok { get; set; }
        public EAddressAssignmentMethod Method { get; set; }
        public EInterfaceStatus Status { get; set; }
        public EInterfaceStatus ProtocolStatus { get; set; }

        public override string ToString()
        {
            return
                InterfaceId.ToString() + " - " +
                (Address == null ? "unassigned" : Address.ToString()) + " - " +
                Ok.ToString() + " - " +
                Method.ToString() + " - " +
                Status.ToString() + " - " +
                ProtocolStatus.ToString();
        }
    }
}
