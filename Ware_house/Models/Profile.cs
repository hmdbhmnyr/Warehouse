using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ware_house.Models
{
    public class Profile
    {
        public long Id { get; set; }
        public string ProfileName { get; set; }
        public string ProfilePhone { get; set; }
        public string profileAddress { get; set; }
        public string ProfileSetting { get; set; }
    }
}
