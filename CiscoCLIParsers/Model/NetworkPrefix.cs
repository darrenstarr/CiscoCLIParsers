using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public class NetworkPrefix
    {
        public IPAddress NetworkAddress { get; set; }
        public int Length { get; set; }

        public static int ClassfulPrefixLength(IPAddress address)
        {
            var bytes = address.GetAddressBytes();
            if ((bytes[0] & 0x80) == 0)
                return 8;
            if ((bytes[0] & 0x40) == 0)
                return 16;
            if ((bytes[0] & 0x20) == 0)
                return 24;
            throw new Exception("Not a valid classful address");
        }

        public override string ToString()
        {
            return NetworkAddress.ToString() + "/" + Length.ToString();
        }

        public static NetworkPrefix FromClassful(IPAddress networkAddress)
        {
            return new NetworkPrefix
            {
                NetworkAddress = networkAddress,
                Length = ClassfulPrefixLength(networkAddress)
            };
        }
    }

}
