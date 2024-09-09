using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ware_house.classes;

namespace Ware_house.Models
{
    public class OutputFactor
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        
        public int EmployeeId { get; set; }
        public User User { get; set; }

    }
}
