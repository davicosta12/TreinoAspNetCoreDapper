using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreinoAspNetCore.Models
{
    public class Product
    {
        public int productId { get; set; }
        public string refId { get; set; }
        public string name { get; set; }
        public string releaseDate { get; set; }
        public string? cor { get; set; }
        public bool isActive { get; set; }
    }
}
