using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ware_house.Models.TestModel
{
    public class Student
    {
        
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public ICollection<StudentAddress> Address { get; set; }
    }

}
