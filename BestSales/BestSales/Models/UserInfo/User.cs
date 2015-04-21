using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace BestSales.Models.UserInfo
{
    public class User
    {

        public string ThumbnailName { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }

        public string Department { get; set; }
        public List<string> HobbysList { get; set; }
        public List<string> SkillsList { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        
    }
}