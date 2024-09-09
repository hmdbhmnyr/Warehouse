using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ware_house.classes;

namespace Ware_house.Models
{
    public class InputFactor
    {
        public int Id { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime InputDate { get; set; }
        public string LoadId { get; set; }
        [MaxLength(10)]
        public string Weight { get; set; }
        public Corporate corporate { get; set; }
        [MaxLength(12)]
        public string DriverPhone { get; set; }
        public string DriverName { get; set; }
        public User user { get; set; }
        public string Pelak { get; set; }

    }
}
