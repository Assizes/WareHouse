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
        private int _id;

        private TabControl tabCtrl;
        private TabPage tabPag;

        public TabPage TabPag
        {
            get { return tabPag; }
            set { tabPag = value; }
        }

        public TabControl TabCtrl
        {
            set { tabCtrl = value; }
        }

        public AddCustomers()
        {
            InitializeComponent();
            connection = warehouse.Connection;
            cmd.Parameters.Add("@fName", MySqlDbType.String);
            cmd.Parameters.Add("@lName", MySqlDbType.String);
            cmd.Parameters.Add("@address", MySqlDbType.String);
            cmd.Parameters.Add("@phNumber", MySqlDbType.String);
            cmd.Parameters.Add("@customerID", MySqlDbType.String);
            cmd.Parameters.Add("@city", MySqlDbType.String);
            cmd.Parameters.Add("@province", MySqlDbType.String);
            cmd.Parameters.Add("@postalCode", MySqlDbType.String);
        }

        public void setID(int id)
        {
            _id = id;
            if (_id != -1)
            {
                cmd.Parameters["@customerID"].Value = _id;
                try
                {
                    if (connection != null)
                    {
                        cmd.CommandText = queries.getCustomerInfo;
                        cmd.Connection = connection;
                        MySqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            txtAddCustomerFName.Text = dr[0].ToString();
                            txtAddCustomerLName.Text = dr[1].ToString();
                            txtAddCustomerAddress.Text = dr[2].ToString();
                            txtAddCustomerPhone.Text = dr[3].ToString();
                            txtAddCustomerCity.Text = dr[4].ToString();
                            txtAddCustomerProvince.Text = dr[5].ToString();
                            txtAddCustomerPostalCode.Text = dr[6].ToString();
                        }
                        dr.Close();

                    }
                    else
                    {
                        MessageBox.Show("Connection Lost");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnAddCustomerReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
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
                this.Text = "Edit Customer";
                grpbxNewCustomer.Text = "Edit Customer";
                btnAddCustomer.Text = "Save";
                btnAddCustomerReset.Text = "Cancel";
                fType = type;
            }
            else
            {
                this.Text = "Add Customer";
                grpbxNewCustomer.Text = "Add Customer";
                btnAddCustomer.Text = "Add Customer";
                btnAddCustomerReset.Text = "Reset";
                fType = type;
                reset();
             }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtAddCustomerFName.Text != "" && txtAddCustomerLName.Text !="" && txtAddCustomerAddress.Text != "" && txtAddCustomerPhone.Text != "")
            {
                cmd.Parameters["@fName"].Value = txtAddCustomerFName.Text;
                cmd.Parameters["@lName"].Value = txtAddCustomerLName.Text;
                cmd.Parameters["@address"].Value = txtAddCustomerAddress.Text;
                cmd.Parameters["@phNumber"].Value = txtAddCustomerPhone.Text;
                cmd.Parameters["@city"].Value = txtAddCustomerCity.Text;
                cmd.Parameters["@province"].Value = txtAddCustomerProvince.Text;
                cmd.Parameters["@postalCode"].Value = txtAddCustomerPostalCode.Text;
            }
            else
            {
                MessageBox.Show("Please, fill up required fields!");
                return;
            }

            if (connection != null)
            {
                if (fType == "Add")
                {
                    try
                    {
                        cmd.CommandText = queries.addCustomer;
                        cmd.Connection = connection;
                        cmd.ExecuteNonQuery();
                        customers.fillData();
                        Close();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    try
                    {
                        cmd.CommandText = queries.updateCustomerInfo;
                        cmd.Connection = connection;
                        cmd.ExecuteNonQuery();
                        customers.fillData();
                        Close();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Connection Lost");
                this.Close();
            }
        }

        private void AddCustomers_Activated(object sender, EventArgs e)
        {
            //Activate the corresponding Tabpage
            if (tabPag != null)
            {
                tabCtrl.SelectedTab = tabPag;

                if (!tabCtrl.Visible)
                {
                    tabCtrl.Visible = true;
                }
            }
        }

        private void AddCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Destroy the corresponding Tabpage when closing MDI child form
            this.tabPag.Dispose();

            //If no Tabpage left
            if (!tabCtrl.HasChildren)
            {
                tabCtrl.Visible = false;
            }
        }
    }
}
