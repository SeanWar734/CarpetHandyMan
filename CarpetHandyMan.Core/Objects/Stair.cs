using System;
using System.Collections.Generic;
using System.Text;

namespace CarpetHandyMan.Core.Objects
{
    public class Stair
    {
        public Guid Id { get; set; }
        public Guid StaircaseId { get; set; }
        public Guid CarpetId { get; set; }
        public decimal Width { get; set; }
        public decimal Length { get; set; }
        public decimal Height { get; set; }
        public decimal Price { get; set; }
    }
}
