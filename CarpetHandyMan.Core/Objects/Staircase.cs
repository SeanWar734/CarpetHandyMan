using System;
using System.Collections.Generic;
using System.Text;

namespace CarpetHandyMan.Core.Objects
{
    public class Staircase
    {
        public Guid Id { get; set; }
        public Guid BuildingId { get; set; }
        public Guid CarpetId { get; set; }
        public virtual List<Stair> Stairs { get; set; }
        public decimal Total { get; set; }
        public int StairCount { get; set; }
        public bool IsCurved { get; set; }
    }
}
