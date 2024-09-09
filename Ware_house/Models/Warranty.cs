using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ware_house.Models
{
    public class Warranty
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        [MaxLength(12)]
        public string Mobile { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
