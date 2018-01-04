using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public class CiscoInterfaceNumber
    {
        public int Chassis { get; set; } = -1;
        public int LineCard { get; set; } = -1;
        public int Module { get; set; } = -1;
        public int Port { get; set; } = -1;
        public int Subinterface { get; set; } = -1;
        public int Channel { get; set; } = -1;

        public override string ToString()
        {
            if (Chassis >= 0)
                return Chassis.ToString() + "/" + LineCard.ToString() + "/" + Module.ToString() + "/" + Port.ToString() + ((Channel >= 0) ? "." + Channel.ToString() : "") + ((Subinterface >= 0) ? "." + Subinterface.ToString() : "");
            if (LineCard >= 0)
                return LineCard.ToString() + "/" + Module.ToString() + "/" + Port.ToString() + ((Channel >= 0) ? "." + Channel.ToString() : "") + ((Subinterface >= 0) ? "." + Subinterface.ToString() : "");
            if (Module >= 0)
                return Module.ToString() + "/" + Port.ToString() + ((Channel >= 0) ? "." + Channel.ToString() : "") + ((Subinterface >= 0) ? "." + Subinterface.ToString() : "");
            if (Port >= 0)
                return Port.ToString() + ((Subinterface >= 0) ? "." + ((Channel >= 0) ? "." + Channel.ToString() : "") + Subinterface.ToString() : "");

            return "#Unassigned#";
        }
    }
}
