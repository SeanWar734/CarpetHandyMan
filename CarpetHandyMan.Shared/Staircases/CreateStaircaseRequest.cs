using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.Shared.Staircases
{
    public class CreateStaircaseRequest
    {
        public Guid Id { get; set; }
        public Guid BuildingId { get; set; }
        public Guid CarpetId { get; set; }
        public decimal CarpetPrice { get; set; }
        public decimal Total { get; set; }
        public int StairCount { get; set; }
        public bool IsCurved { get; set; }
        public decimal StairLength { get; set; }
        public decimal StairWidth { get; set; }
        public decimal StairHeight { get; set; }
    }
}
