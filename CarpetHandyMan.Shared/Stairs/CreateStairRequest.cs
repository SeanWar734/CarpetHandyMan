using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.Shared.Stairs
{
    public class CreateStairRequest
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
