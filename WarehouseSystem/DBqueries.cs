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
        public string getAllCustomers = "SELECT customer_ID AS ID, firstName AS `First Name`, lastName AS `Last Name`, address AS `Address`, phoneNumber AS `Phone Number`, city AS City, province AS Province, postalCode AS `Postal Code` FROM s2016_user1.customers";
        public string addCustomer = "INSERT INTO s2016_user1.customers(firstName, lastName, address, phoneNumber,city,province,postalCode) VALUES(@fName,@lName,@address,@phNumber,@city,@province,@postalCode)";
        public string getCustomerInfo = "SELECT firstName, lastName, address, phoneNumber, city, province, postalCode FROM s2016_user1.customers WHERE customer_ID=@customerID";
        public string updateCustomerInfo = "UPDATE s2016_user1.customers SET firstName=@fName, lastName=@lName, address=@address, phoneNumber=@phNumber, city=@city,province=@province,postalCode=@postalCode WHERE customer_ID=@customerID";
        public string deleteCustomer = "DELETE FROM s2016_user1.customers WHERE customer_ID=@customerID";
        public string getAllUsers = "SELECT UserID AS `User ID`, User_Login AS `Login`, User_FName AS `First Name`, User_LName AS `Last Name`, roleName AS `Group` FROM s2016_user1.users AS US INNER JOIN s2016_user1.userRole AS UR ON US.userRoleID = UR.userRoleID";
        public string getUserInfo = "SELECT User_Login, User_FName, User_LName, roleName FROM s2016_user1.users AS US INNER JOIN s2016_user1.userRole AS UR ON US.userRoleID = UR.userRoleID WHERE UserID = @userID";
        public string getUserGroups = "SELECT roleName FROM s2016_user1.userRole";
        
    }
}
