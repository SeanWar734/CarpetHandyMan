using System;
using System.Collections.Generic;
using System.Text;

namespace CarpetHandyMan.Core.Objects
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid RetailerId { get; set; }
        public Guid InstallerId { get; set; }
        public Guid CarpetId { get; set; }
        public decimal Total { get; set; }
    }
}
