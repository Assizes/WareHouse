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
        MySqlDataReader dr;
        string fType = "Add";
        private int _id;

        public AddEditUser()
        {
            InitializeComponent();
            connection = warehouse.Connection;
            cmd.Parameters.Add("@userID", MySqlDbType.String);

            cmd.CommandText = queries.getUserGroups;
            cmd.Connection = connection;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbGroup.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        public void setID(int id)
        {
            _id = id;
            if (_id != -1)
            {
                cmd.Parameters["@userID"].Value = _id;
                if (_id == 1)
                    cmbGroup.Enabled = false;
                try
                {
                    if (connection != null)
                    {
                        cmd.CommandText = queries.getUserInfo;
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            txtLogin.Text = dr[0].ToString();
                            txtFName.Text = dr[1].ToString();
                            txtLName.Text = dr[2].ToString();
                            cmbGroup.SelectedItem = dr[3].ToString();
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
                reset();
            }
            else
            {
                Close();
            }
        }

        private void reset()
        {
            txtLogin.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtPassword.Text = "";
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
                reset();
                this.Text = "Add User";
                groupBox1.Text = "Add User";
                btnAddUser.Text = "Add User";
                btnReset.Text = "Reset";
                fType = type;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //TODO
            if (fType == "Edit")
            {
                
            }
            else
            {
                
            }
        }
    }
}
