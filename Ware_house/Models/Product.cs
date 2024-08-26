using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ware_house.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public string Price { get; set; }
        public int Quantity { get; set; }
        public string Model { get; set; }
        public string Image { get; set; }
        public string CreateDate { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public string Warranty { get; set; }
        public string Serial { get; set; }

        public ICollection<InputFactorItem> inputFactorItems { get; set; }
    }
}
