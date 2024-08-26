using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ware_house.Models
{
    public class OutputFactor
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        
        public int EmployeeId { get; set; }
    }
}
