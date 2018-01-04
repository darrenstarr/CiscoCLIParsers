using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public class InterfaceTimers
    {
        public TimeSpan LastInputTime { get; set; }
        public TimeSpan LastOutputTime { get; set; }
        public TimeSpan OutputHangTime { get; set; }
        public TimeSpan LastCounterClearing { get; set; }
    }
}
