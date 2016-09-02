using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem
{
    class DBqueries
    {
        internal string checkUserCredentials = "SELECT DISTINCT User_Login, User_Password, userRoleID FROM sql3134099.users WHERE User_Login = @Login";

        internal string getAllCustomers = "SELECT customer_ID AS ID, firstName AS `First Name`, lastName AS `Last Name`, address AS `Address`, phoneNumber AS `Phone Number`, city AS City, province AS Province, postalCode AS `Postal Code` FROM sql3134099.customers";
        internal string addCustomer = "INSERT INTO sql3134099.customers(firstName, lastName, address, phoneNumber,city,province,postalCode) VALUES(@fName,@lName,@address,@phNumber,@city,@province,@postalCode)";
        internal string getCustomerInfo = "SELECT firstName, lastName, address, phoneNumber, city, province, postalCode FROM sql3134099.customers WHERE customer_ID=@customerID";
        internal string updateCustomerInfo = "UPDATE sql3134099.customers SET firstName=@fName, lastName=@lName, address=@address, phoneNumber=@phNumber, city=@city,province=@province,postalCode=@postalCode WHERE customer_ID=@customerID";
        internal string deleteCustomer = "DELETE FROM sql3134099.customers WHERE customer_ID=@customerID";

        internal string getAllUsers = "SELECT UserID AS `User ID`, User_Login AS `Login`, User_FName AS `First Name`, User_LName AS `Last Name`, roleName AS `Group` FROM sql3134099.users AS US INNER JOIN sql3134099.userRole AS UR ON US.userRoleID = UR.userRoleID";
        internal string addUser = "INSERT INTO sql3134099.users(User_Login,User_FName,User_LName,User_Password,userRoleID) VALUES(@login,@fName,@lName,@pass,@roleID)";
        internal string updateUser = "UPDATE sql3134099.users SET User_Login=@login, User_FName=@fName, User_LName=@lName, userRoleID=@roleID WHERE UserID=@userID";
        internal string updateUserPass = "UPDATE sql3134099.users SET User_Password=@pass WHERE UserID=@userID";
        internal string getUserInfo = "SELECT User_Login, User_FName, User_LName, roleName FROM sql3134099.users AS US INNER JOIN sql3134099.userRole AS UR ON US.userRoleID = UR.userRoleID WHERE UserID = @userID";
        internal string getUserGroups = "SELECT roleName FROM sql3134099.userRole";
        internal string deleteUser = "DELETE FROM sql3134099.users WHERE UserID=@userID";

        internal string getAllAisles = "SELECT aisle_ID AS `Aisle ID`, aisle_Name AS `Aisle Name` FROM sql3134099.aisles";
        internal string getAllShelves = "SELECT shelf_ID as selfID FROM sql3134099.shelves";
        internal string getAllBins = "SELECT bin_ID AS `ID` FROM sql3134099.bins";
        internal string getShelfBins = "SELECT bin_ID AS `ID`, availableWidth AS `Available Width`, availableWeight AS `Available Weight`, COUNT(item_ID) AS `Number of items stored` FROM sql3134099.bins AS BI LEFT JOIN sql3134099.item AS IT ON BI.bin_ID = IT.FK_bin WHERE FK_shelf=@shelf GROUP BY bin_ID " +
                                        "UNION SELECT bin_ID AS `ID`, availableWidth AS `Available Width`, availableWeight AS `Available Weight`, COUNT(item_ID)AS `Number of items stored` FROM sql3134099.bins AS BI RIGHT JOIN sql3134099.item AS IT ON BI.bin_ID = IT.FK_bin WHERE FK_shelf=@shelf GROUP BY bin_ID";

        internal string getShelves = "SELECT shelf_ID AS `Shelf ID` FROM sql3134099.shelves WHERE FK_aisle=@aisleID";

        internal string addAisle = "INSERT INTO sql3134099.aisles VALUES(DEFAULT,@aisleName); SELECT LAST_INSERT_ID();";
        internal string deleteaisle = "DELETE FROM sql3134099.aisles WHERE aisle_ID=@aisleID";
        internal string addShelf = "INSERT INTO sql3134099.shelves VALUES(DEFAULT, @aisleID); SELECT LAST_INSERT_ID();";
        internal string deleteShelf = "DELETE FROM sql3134099.shelves WHERE shelf_ID=@shelf";
        internal string addBin = "INSERT INTO sql3134099.bins VALUES(DEFAULT, @shelf, @maxWeight, @maxHeight, @maxWidth, @maxLength, @maxWidth, @maxWeight)";
        internal string deleteBin = "DELETE FROM sql3134099.bins WHERE bin_ID=@binID";
        internal string getBin = "SELECT maxWeight, maxHeight, maxWidth, maxLength FROM sql3134099.bins WHERE bin_ID = @binID";
        internal string updateBin = "UPDATE sql3134099.bins SET maxWeight = @maxWeight, maxHeight = @maxHeight, maxWidth = @maxWidth, maxLength = @maxLength WHERE bin_ID = @binID AND availableWidth-(maxWidth-@maxWidth) >= 0 AND availableWeight-(maxWeight-@maxWeight) >= 0";

        //adding queries

        internal string getCustomer = "SELECT customer_ID, firstName , lastName FROM sql3134099.customers";
        internal string getMeasurements = "SELECT type, unit_ID FROM sql3134099.unitOfMeasurement";


        /*internal string addInvetory = "INSERT INTO sql3134099.item(FK_Customer_ID,itemDescription,length,width,height,weight,quantity,expirationDate,FK_Customers )" +
                                    "FROM sql3134099.customers AS C " + "INNER JOIN bins AS b ON b.bin_ID = C.FK_bin " + "INNER JOIN shelves AS s ON s.shelf_ID = C.FK_shelf " + "INNER JOIN aisles AS a ON a.aisle_ID = FK_aisle";*/

        //Honestly could have just done INSERT INTO s2016 meaning select all instead of writing them all out//oh well
        internal string addInv = "INSERT INTO sql3134099.item(itemName,length,width,height,weight,quantity,itemDescription,FK_bin,FK_Customers,FK_measurerment, expirationDate)" +
            " VALUES(@itemName, @length, @width, @height, @weight, @quantity, @itemDescription, @binID, @custID, @unitOfMeasurement, @expirationDate)";

        internal string editInv = "UPDATE sql3134099.item SET itemName=@itemName, length=@length, width=@width, height=@height, weight=@weight, quantity=@quantity, itemDescription=@itemDescription," +
            " FK_bin=@binID, FK_Customers=@custID, FK_measurerment=@unitOfMeasurement, expirationDate=@expirationDate WHERE item_id=@itemID ";
        //one gets all bins not taken//Other gets all bins for that customer and bin is not full
        internal string getBinsNotTaken = "SELECT b.bin_ID FROM sql3134099.bins as b LEFT OUTER JOIN sql3134099.item as i ON i.FK_bin = b.bin_ID WHERE i.FK_bin IS NULL";
        internal string getBinsForThisCustomer = "SELECT i.FK_bin, b.availableWidth, SUM(i.width) as count FROM sql3134099.item AS i INNER JOIN sql3134099.bins AS b ON i.FK_bin= b.bin_ID WHERE FK_customers = @custID GROUP BY i.FK_bin HAVING b.availableWidth > SUM(i.width)";

        internal string deleteInv = "DELETE FROM sql3134099.item WHERE item_id=@itemID";
        //testfor first one
        /*SELECT b.bin_ID FROM sql3134099.bins as b LEFT OUTER JOIN sql3134099.item as i ON i.FK_bin = b.bin_ID
WHERE i.FK_bin IS NULL*/

        //test data for getbinsfromcutomer - works
        /*SELECT i.FK_bin, b.availableWidth, SUM(i.width) as count
        FROM sql3134099.item AS i
        INNER JOIN bins AS b ON i.FK_bin=b.bin_ID
        WHERE FK_customers= 1
        GROUP BY i.FK_bin
        HAVING b.availableWidth > SUM(i.width)*/




        internal string getAllInv = "SELECT item_ID AS ID, itemName AS Item, itemDescription AS Description, CONCAT(firstName, ' ', lastName) AS Customer, " +
            "quantity AS Quantity FROM sql3134099.item INNER JOIN sql3134099.customers ON sql3134099.item.FK_customers = sql3134099.customers.customer_ID";

        //neeed a where statement to get all items associated with particular customer
        internal string getCustInv = "SELECT CONCAT(firstName, ' ', lastName) AS Customer, itemName AS Item, itemDescription AS Description, " +
            "FROM sql3134099.item INNER JOIN sql3134099.customers ON sql3134099.item.FK_customers = sql3134099.customers.customer_ID";


        internal string getItemID = "SELECT * FROM sql3134099.item WHERE FK_customers= @custID";

        /*internal string addInvWithSub = "INSERT INTO sql3134099.item(itemName,length,width,height,weight,quantity,itemDescription,expirationDate,FK_bin,FK_Customers,FK_measurerment)" +
            " SELECT @itemName, @length, @width, @height, @weight, @quantity, @itemDescription, @expirationDate, @binID, @custID, @unitOfMeasurement FROM sql3134099.item WHERE (Select 1 FROM sql3134099.item WHERE @expirationDate != null)";*/


        /* INSERT INTO sql3134099.item(itemName,length,width,height,weight,quantity,itemDescription,expirationDate,FK_bin,FK_Customers,FK_measurerment)
Select 'A',1, 2, 3, 4, 5,'B', '2016-01-01',1 , 1, 1
from dual
where exists (Select 1 from sql3134099.bins where bin_id =1)*/

        /*FROM sql3134099.item AS i FK_measurerment,

        INNER JOIN bins AS b ON b.bin_ID = i.FK_bin

        INNER JOIN shelves AS s ON s.shelf_ID = b.FK_shelf

        INNER JOIN aisles AS a ON a.aisle_ID = s.FK_aisle"*/
    }
}
