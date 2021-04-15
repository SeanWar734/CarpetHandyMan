using System;
using System.Collections.Generic;
using System.Text;

namespace CarpetHandyMan.Core.Objects
{
    public class Closet
    {
        public Guid Id { get; set; }
        public Guid RoomId { get; set; }
        public decimal Width { get; set; }
        public decimal Length { get; set; }
    }
}
