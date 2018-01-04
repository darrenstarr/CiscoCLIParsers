using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIParsers.Model
{
    public class ShowInventoryItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProductId { get; set; }
        public string VendorId { get; set; }
        public string SerialNumber { get; set; }
    }
}
