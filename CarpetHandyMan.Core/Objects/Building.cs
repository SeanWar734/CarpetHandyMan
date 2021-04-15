using System;
using System.Collections.Generic;
using System.Text;

namespace CarpetHandyMan.Core.Objects
{
    public class Building
    {
        public Guid Id { get; set; }
        public virtual List<Room> Rooms { get; set; }
        public virtual List<Staircase> Staircases { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
