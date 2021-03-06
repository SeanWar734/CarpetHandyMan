using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.Shared.Rooms
{
    public class RoomSingleResponse
    {
        public Guid Id { get; set; }
        public Guid BuildingId { get; set; }
        public Guid CarpetId { get; set; }
        public int ClosetCount { get; set; }
        public string CarpetName { get; set; }
        public decimal CarpetWidth { get; set; }
        public string RoomName { get; set; }
        public decimal Width { get; set; }
        public decimal Length { get; set; }
    }
}
