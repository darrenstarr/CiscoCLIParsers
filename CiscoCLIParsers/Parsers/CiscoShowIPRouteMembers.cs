using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CiscoCLIParsers.Model;

namespace CiscoCLIParsers.Parsers
{
    public partial class CiscoShowIpRoute
    {
        List<ShowIPRouteEntryItem> MergeRoutes(IList<List<ShowIPRouteEntryItem>> lists)
        {
            List<ShowIPRouteEntryItem> result = new List<ShowIPRouteEntryItem>();
            foreach (var list in lists)
                result.AddRange(list);

            return result;
        }

        List<ShowIPRouteEntryItem> ApplyPrefixLength(List<ShowIPRouteEntryItem> routes, NetworkPrefix prefix)
        {
            foreach (var route in routes)
            {
                route.Prefix.Length = prefix.Length;
            }

            return routes;
        }

        DateTime UptimeToDateTime(IList<int>seconds)
        {
            int total = seconds.Sum();
            return DateTime.Now.AddSeconds(-(total));
        }

        int UptimeToSeconds(int x, string units)
        {
            switch (units)
            {
                case "y":
                    return 31536000 * x;
                case "w":
                    return 86400 * 7 * x;
                case "d":
                    return 86400 * x;
                case "h":
                    return 3600 * x;
                case "m":
                    return 60 * x;
                case "s":
                    return x;
            }
            throw new Exception("Unrecognized time unit '" + units + "'");
        }
    }
}
