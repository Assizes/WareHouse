using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem
{
    class DBqueries
    {
       
       public string checkUserCredentials = "SELECT DISTINCT User_Login, User_Password, userRoleID FROM s2016_user1.users WHERE User_Login = @Login";

    }
}
