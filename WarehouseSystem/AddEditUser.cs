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
    public partial class AddEditUser : Form
    {
        private WarehouseSystem warehouse = (WarehouseSystem)Application.OpenForms["WarehouseSystem"];
        private Users users = (Users)Application.OpenForms["Users"];
        MySqlConnection connection;
        MySqlCommand cmd = new MySqlCommand();
        DBqueries queries = new DBqueries();
        string fType = "Add";
        private int _id;

        public AddEditUser()
        {
            InitializeComponent();
            connection = warehouse.Connection;
            cmd.Parameters.Add("@userID", MySqlDbType.String);
        }

        public void setID(int id)
        {
            _id = id;
            if (_id != -1)
            {
                cmd.Parameters["@userID"].Value = _id;
                try
                {
                    if (connection != null)
                    {
        //                cmd.CommandText = queries.getCustomerInfo;
                        cmd.Connection = connection;
                        MySqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            txtLogin.Text = dr[0].ToString();
                            txtFName.Text = dr[1].ToString();
                            txtLName.Text = dr[2].ToString();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (fType == "Add")
            {
                txtLogin.Text = "";
                txtFName.Text = "";
                txtLName.Text = "";
                txtPassword.Text = "";
                cmbGroup.Items.Clear();
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
                this.Text = "Edit User";
                groupBox1.Text = "Edit User";
                btnAddUser.Text = "Save";
                btnReset.Text = "Cancel";
                fType = type;
            }
            else
            {
                this.Text = "Add User";
                groupBox1.Text = "Add User";
                btnAddUser.Text = "Add Customer";
                btnReset.Text = "Reset";
                fType = type;
            }
        }
    }
}
