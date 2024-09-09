using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ware_house.Models
{
    public class InputFactorItem
    {
        public int Id { get; set; }
        public InputFactor Factor { get; set; }
        public Product Product { get; set; }
        public int  InputFactorItemQuntity { get; set;} 
        public int  InputFactorItemPrice { get; set;} 
        public int  InputFactorItemDiscount { get; set;} 


    }
}
