using System;
using System.Collections.Generic;
using System.Text;

namespace CarpetHandyMan.Shared.Carpets
{
    public class CarpetListReponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Width { get; set; }
        public decimal Length { get; set; }
        public decimal SquareYardPrice { get; set; }
        public string Brand { get; set; }
        public string Style { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
