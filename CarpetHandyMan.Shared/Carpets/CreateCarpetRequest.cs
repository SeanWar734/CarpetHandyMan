using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.Shared.Carpets
{
    public class CreateCarpetRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Width { get; set; }
        public decimal Length { get; set; }
        public decimal SquareYardPrice { get; set; }
        public string Brand { get; set; }
        public string Style { get; set; }
        public string Description { get; set; }
    }
}
