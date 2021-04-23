using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.Shared.Closets
{
    public class ClosetSingleResponse
    {
        public Guid Id { get; set; }
        public Guid RoomId { get; set; }
        public Guid BuildingId { get; set; }
        public Guid CarpetId { get; set; }
        public decimal CarpetPrice { get; set; }
        public decimal CarpetWidth { get; set; }
        public decimal Width { get; set; }
        public decimal Length { get; set; }
    }
}
