using System;
using System.Collections.Generic;
using System.Text;

namespace CarpetHandyMan.Core.Objects
{
    public class Room
    {
        public Guid Id { get; set; }
        public Guid BuildingId { get; set; }
        public Guid CarpetId { get; set; }
        public string RoomName { get; set; }
        public decimal Width { get; set; }
        public decimal Length { get; set; }
        public virtual List<Closet> Closets { get; set; }
    }
}
