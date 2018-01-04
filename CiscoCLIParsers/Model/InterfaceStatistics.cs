using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public class InterfaceStatistics
    {
        public InterfaceDataRate InputRate { get; set; }
        public InterfaceDataRate OutputRate { get; set; }
        public InterfaceInputStatistics InputStatistics { get; set; }
        public InterfaceOutputStatistics OutputStatistics { get; set; }
    }
}
