using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestSales.Interfaces
{
    public interface IUserLogic
    {
        Dictionary<int, Models.UserInfo.User> GetUSers();
    }
}
