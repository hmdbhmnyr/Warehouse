using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ware_house.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string ProfileName { get; set; }
        [MaxLength(12)]
        public string ProfilePhone { get; set; }
        public string profileAddress { get; set; }
        public string ProfileSetting { get; set; }
    }
}
