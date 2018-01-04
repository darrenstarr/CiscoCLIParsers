using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public class InterfaceQueueCharacteristics
    {
        public InterfaceInputQueueCharacteristics Input { get; set; }
        public InterfaceOutputQueueCharacteristics Output { get; set; }
    }
}
