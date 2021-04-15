using System;
using System.Collections.Generic;
using System.Text;

namespace CarpetHandyMan.Core.Objects
{
    public class Installer
    {
        public Guid Id { get; set; }
        public Guid RetailerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal SquareYardPrice { get; set; }
        public decimal Area { get; set; }

    }
}
