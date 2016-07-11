using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseSystem
{
    public partial class AddCustomers : Form
    {
        private WarehouseSystem warehouse = (WarehouseSystem)Application.OpenForms["WarehouseSystem"];
        private Customers customers = (Customers)Application.OpenForms["Customers"];
        MySqlConnection connection;
        MySqlCommand cmd = new MySqlCommand();
        DBqueries queries = new DBqueries();
        string fType = "Add";
        string query;

        public AddCustomers()
        {
            InitializeComponent();
            cmd.Parameters.Add("@fName", MySqlDbType.String);
            cmd.Parameters.Add("@lName", MySqlDbType.String);
            cmd.Parameters.Add("@address", MySqlDbType.String);
            cmd.Parameters.Add("@phNumber", MySqlDbType.String);
        }

        private void btnAddCustomerReset_Click(object sender, EventArgs e)
        {
            if (fType == "Add")
            {
                txtAddCustomerFName.Text = "";
                txtAddCustomerLName.Text = "";
                txtAddCustomerAddress.Text = "";
                txtAddCustomerPhone.Text = "";
                txtAddCustomerCity.Text = "";
                txtAddCustomerProvince.Text = "";
                txtAddCustomerPostalCode.Text = "";
            }
            else
            {
                Close();
            }
        }

        public void setType(string type)
        {
            if (type == "Edit")
            {
                grpbxNewCustomer.Text = "Edit Customer";
                btnAddCustomer.Text = "Save";
                btnAddCustomerReset.Text = "Cancel";
                fType = type;
            }
            else
            {
                grpbxNewCustomer.Text = "Add Customer";
                btnAddCustomer.Text = "Add Customer";
                btnAddCustomerReset.Text = "Reset";
                fType = type;
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            connection = warehouse.Connection;
            if (txtAddCustomerFName.Text != "" && txtAddCustomerLName.Text !="" && txtAddCustomerAddress.Text != "" && txtAddCustomerPhone.Text != "")
            {
                cmd.Parameters["@fName"].Value = txtAddCustomerFName.Text;
                cmd.Parameters["@lName"].Value = txtAddCustomerLName.Text;
                cmd.Parameters["@address"].Value = txtAddCustomerAddress.Text;
                cmd.Parameters["@phNumber"].Value = txtAddCustomerPhone.Text;
            }
            else
            {
                MessageBox.Show("Please, fill up required fields!");
                return;
            }

            if (fType == "Add")
            {
                try
                {
                    if (connection != null)
                    {
                        query = queries.addCustomer;
                        MySqlDataAdapter sqladapter = new MySqlDataAdapter();
                        cmd.CommandText = query;
                        cmd.Connection = connection;
                        cmd.ExecuteNonQuery();
                        customers.fillData();

                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Connection Lost");
                        this.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {

            }
        }
    }
}
