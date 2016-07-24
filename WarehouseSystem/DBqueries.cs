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
        public string addUser = "INSERT INTO s2016_user1.users(User_Login,User_FName,User_LName,User_Password,userRoleID) VALUES(@login,@fName,@lName,@pass,@roleID)";
        public string updateUser = "UPDATE s2016_user1.users SET User_Login=@login, User_FName=@fName, User_LName=@lName, userRoleID=@roleID WHERE UserID=@userID";
        public string updateUserPass = "UPDATE s2016_user1.users SET User_Password=@pass WHERE UserID=@userID";
        public string getUserInfo = "SELECT User_Login, User_FName, User_LName, roleName FROM s2016_user1.users AS US INNER JOIN s2016_user1.userRole AS UR ON US.userRoleID = UR.userRoleID WHERE UserID = @userID";
        public string getUserGroups = "SELECT roleName FROM s2016_user1.userRole";
        public string deleteUser = "DELETE FROM s2016_user1.users WHERE UserID=@userID";

        public string getAllAisles = "SELECT aisle_ID AS `Aisle ID` FROM s2016_user1.aisles";
        public string getShelves = "SELECT shelf_ID AS `Shelf ID` FROM s2016_user1.shelves WHERE FK_aisle=@aisleID";

        //adding queries
       // public string getCustomer = "SELECT concat('firstName' , 'lastName' , 'customer_ID') FROM s2016_user1.customers";
        public string getCustomer = "SELECT firstName , lastName , customer_ID as temp FROM s2016_user1.customers";
        //public string getCustomer = "SELECT * FROM s2016_user1.customers";

        public string addInvetory = "INSERT INTO s2016_user1.item(FK_Customer_ID,itemDescription,length,width,height,weight,quantity,expirationDate,FK_Customers)" +
                                    "FROM s2016_user1.customers AS C" + "INNER JOIN bins AS b ON b.bin_ID = C.FK_bin" + "INNER JOIN shelves AS s ON s.shelf_ID = C.FK_shelf" + "INNER JOIN aisles AS a ON a.aisle_ID = FK_aisle";
        
    }
}
