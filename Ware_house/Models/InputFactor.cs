using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ware_house.Models
{
    public class InputFactor
    {
        public int Id { get; set; }

        public DateTime InputDate { get; set; }
        public string LoadId { get; set; }
        public string Weight { get; set; }
        public string CorporateName { get; set; }
        public string DriverPhone { get; set; }
        public string DriverName { get; set; }
        public int EmployeeId { get; set; }
        public string Pelak { get; set; }

    }
}
