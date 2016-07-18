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
            cmd.Parameters.Add("@login", MySqlDbType.String);
            cmd.Parameters.Add("@fName", MySqlDbType.String);
            cmd.Parameters.Add("@lName", MySqlDbType.String);
            cmd.Parameters.Add("@pass", MySqlDbType.String);
            cmd.Parameters.Add("@roleID", MySqlDbType.String);

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
            cmbGroup.SelectedIndex = 0;
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
            
            if (txtFName.Text != "" && txtLName.Text != "" && txtLogin.Text != "")
            {
                cmd.Parameters["@login"].Value = txtLogin.Text;
                cmd.Parameters["@fName"].Value = txtFName.Text;
                cmd.Parameters["@lName"].Value = txtLogin.Text;
                cmd.Parameters["@roleID"].Value = cmbGroup.SelectedIndex + 1;
            }
            else
            {
                MessageBox.Show("Please, fill up required fields!");
                return;
            }
            if (txtPassword.Text != "")
            {
                PasswordEncription hash = new PasswordEncription(txtPassword.Text);
                cmd.Parameters["@pass"].Value = hash.getHash();
            }

            if (connection != null)
            {
                if (fType == "Add")
                {
                    if (txtPassword.Text != "")
                    {
                        try
                        {
                            cmd.CommandText = queries.addUser;
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            users.fillData();
                            Close();
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter password");
                    }
                }
                else
                {
                    try
                    {
                        cmd.CommandText = queries.updateUser;
                        cmd.Connection = connection;
                        cmd.ExecuteNonQuery();
                        if (txtPassword.Text != "")
                        {
                            cmd.CommandText = queries.updateUserPass;
                            cmd.ExecuteNonQuery();
                        }
                        users.fillData();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Connection Lost");
                this.Close();
            }
        }
    }
}
