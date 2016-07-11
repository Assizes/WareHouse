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
        public string getAllCustomers = "SELECT customer_ID AS ID, firstName AS `First Name`, lastName AS `Last Name`, address AS `Address`, phoneNumber AS `Phone Number` FROM s2016_user1.customers";
        public string addCustomer = "INSERT INTO s2016_user1.customers(firstName, lastName, address, phoneNumber) VALUES(@fName,@lName,@address,@phNumber)";
    }
}
