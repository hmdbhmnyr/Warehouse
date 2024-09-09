using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ware_house.Models;

namespace Ware_house.classes
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Family { get; set;}
        public string Username { get; set; }
        public string Password { get; set; }
        [MaxLength(12)]
        public string phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        [MaxLength(20)]
        public string Usertype { get; set; }
        [MaxLength(10)]
        public string Nationcode { get; set; }
        [MaxLength(10)]
        public string PostalCode { get; set; }
        public string Image { get; set; }

        public ICollection<OutputFactor> OutputFactors { get; set; }
        public ICollection<InputFactor> InputFactors { get; set; }
        public ICollection<OutputFactor> outputFactors { get; set; }
    }
}
