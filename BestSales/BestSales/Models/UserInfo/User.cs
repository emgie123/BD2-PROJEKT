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
        public Dictionary<string, string> Details { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }

        public User(string thumbnail, string name, string profession)
        {
            ThumbnailName = thumbnail;
            Name = name;
            Profession = profession;

            Details = new Dictionary<string, string>();
        }

        public void SetDetails(string department, string phone, string email, List<string> hobbysList,
            List<string> skillsList)
        {
            StringBuilder sb = new StringBuilder();

            Details.Add("DZIAŁ:", department);
            Details.Add("TELEFON:", phone);
            Details.Add("EMAIL:", email);

            foreach (var hobby in hobbysList)
            {
                sb.Append(hobby + "\n");
            }
            Details.Add("ZAINTERESOWANIA:", sb.ToString());

            sb.Clear();
            foreach (var skill in skillsList)
            {
                sb.Append(skill + "\n");
            }
            Details.Add("UMIEJĘTNOŚCI:", sb.ToString());

        }
    }
}