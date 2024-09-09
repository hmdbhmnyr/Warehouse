using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ware_house.Models
{
    public class Corporate
    {
        public int Id { get; set; }
        public string CorporateName { get; set; }
        [MaxLength(12)]
        public string CorporatePhone { get; set; }
        public string CorporateAddress { get; set; }
        public ICollection<InputFactor> InputFactors { get; set; }
        public ICollection<Product> Products { get; set; }


    }
}
