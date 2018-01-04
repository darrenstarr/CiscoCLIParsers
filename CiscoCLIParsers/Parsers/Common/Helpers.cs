using CiscoCLIParsers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Parsers.Common
{
    class Helpers
    { 
        public static CiscoInterfaceId ToCiscoInterfaceId(EInterfaceType interfaceType, CiscoInterfaceNumber interfaceNumber, IList<int> channelNumber, IList<int> subinterfaceNumber)
        {
            var result = new CiscoInterfaceId
            {
                InterfaceType = interfaceType,
                InterfaceNumber = interfaceNumber
            };

            if (channelNumber.Count > 0)
                result.InterfaceNumber.Channel = channelNumber[0];

            if (subinterfaceNumber.Count > 0)
                result.InterfaceNumber.Subinterface = subinterfaceNumber[0];

            return result;
        }
    }
}
