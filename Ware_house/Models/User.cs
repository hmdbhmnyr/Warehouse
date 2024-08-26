using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ware_house.Models;

namespace Ware_house.classes
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Family { get; set;}
        public string Username { get; set; }
        public string Password { get; set; }
        public string phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Usertype { get; set; }
        public string Nationcode { get; set; }
        public string PostalCode { get; set; }
        public string Image { get; set; }

        public ICollection<OutputFactor> OutputFactors { get; set; }
    }
}
