using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public enum ERoutingProtocol
    {
        Unspecified,
        Local,
        Connected,
        Static,
        RIP,
        Mobile,
        BGP,
        EIGRP,
        OSPF,
        ISIS,
        ODR,
        PeriodicDownloadStatic,
        NHRP,
        LISP,
        PerUserStatic,
        EIGRPExternal,
        OSPFInterarea,
        OSPFNSSAType1External,
        OSPFNSSAType2External,
        OSPFType1External,
        OSPFType2External,
        ISISSummary,
        ISISLevel1,
        ISISLevel2,
        ISISInterarea
    }
}
