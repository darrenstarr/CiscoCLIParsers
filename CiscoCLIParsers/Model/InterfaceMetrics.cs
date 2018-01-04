using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public class Ratio
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
    }

    public class InterfaceMetrics
    {
        public int MTU { get; set; }
        public Int64 Bandwidth { get; set; }
        public int Delay { get; set; }
        public Ratio Reliability { get; set; }
        public Ratio TransmitLoad { get; set; }
        public Ratio ReceiveLoad { get; set; }
    }
}
