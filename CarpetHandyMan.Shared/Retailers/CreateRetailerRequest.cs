using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.Shared.Retailers
{
    public class CreateRetailerRequest
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
    }
}
