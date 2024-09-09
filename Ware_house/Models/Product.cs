using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ware_house.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public string Price { get; set; }
        public int Quantity { get; set; }
        public string Model { get; set; }
        public string Image { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime CreateDate { get; set; }
        [MaxLength(20)]
        public string Color { get; set; }
        public string Description { get; set; }
        public Warranty warranty { get; set; }
        public string Serial { get; set; }
        public Corporate Corporate { get; set; }
        public ICollection<InputFactorItem> inputFactorItems { get; set; }
        public ICollection<OutputFactorItem> outputFactorItems { get; set; }

    }
}
