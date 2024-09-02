using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ware_house.Models
{
    public class Product
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Category")]        
        public int soghrat { get; set; }
        public Category Category { get; set; }
        public string Price { get; set; }
        public int Quantity { get; set; }
        public string Model { get; set; }
        public string Image { get; set; }
        public string CreateDate { get; set; }
        public string Color { get; set; }

        [NotNull]
        [Required]
        public string Description { get; set; }
        public string Warranty { get; set; }
        [Index("SerialIndex",IsUnique =true)]
        public int Serial { get; set; }
        public ICollection<InputFactorItem> inputFactorItems { get; set; }
    }
}
