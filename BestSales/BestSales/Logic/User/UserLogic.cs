using System.Collections.Generic;
using BestSales.Interfaces;

namespace BestSales.Logic.User
{
    public class UserLogic : IUserLogic
    {
        public Dictionary<int, Models.UserInfo.User> GetUSers()
        {
            // todo call db to return all users

            //temp mock

            return GetUsersMock();
        }

        private Dictionary<int, Models.UserInfo.User> GetUsersMock()
        {
            Dictionary<int, Models.UserInfo.User> UsersCollection = new Dictionary<int, Models.UserInfo.User>();
 
            UsersCollection.Add(1, new Models.UserInfo.User()
            {
                Department = "DEVELOPERS",
                Email = "majkel@BestSales.com",
                HobbysList = new List<string>() { "Programowanie", "Bazy Danych" },
                Name = "Garbacz Michał",
                PhoneNumber = "987654321",
                Profession = "Junior Web Developer",
                SkillsList = new List<string>() { "ASP.NET MVC, JavaScript, SQL" },
                ThumbnailName = "mg.png",
            });

            UsersCollection.Add(2, new Models.UserInfo.User()
            {
                Department = "DEVELOPERS",
                Email = "majkel@BestSales.com",
                HobbysList = new List<string>() { "Technologie internetowe", "Programowanie" },
                Name = "Winkler Robert",
                PhoneNumber = "123456789",
                Profession = "Junior Web Developer",
                SkillsList = new List<string>() { "ASP.NET MVC, JavaScript, SQL" },
                ThumbnailName = "robson.jpeg",
            });

            return UsersCollection;
        }
    }
}