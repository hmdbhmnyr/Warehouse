using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ware_house.Models
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set;}

    }
}
