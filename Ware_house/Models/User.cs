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
    [Table("UserInfo",Schema ="user")]
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Column("FullName",TypeName ="nvarchar")]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Usertype { get; set; }
        public string Nationcode { get; set; }
        public string PostalCode { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public  string EmpoyeeID { get; set; }

        public ICollection<OutputFactor> OutputFactors { get; set; }
    }
}
