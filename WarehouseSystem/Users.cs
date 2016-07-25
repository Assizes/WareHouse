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
    public partial class Users : Form
    {
        //Reference to the MDI parent window
        private WarehouseSystem warehouse = (WarehouseSystem)Application.OpenForms["WarehouseSystem"];
        private AddEditUser user = null;
        //Reference to database connection
        MySqlConnection connection;
        MySqlCommand cmd = new MySqlCommand();
        DBqueries queries = new DBqueries();

        string query;

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

        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            connection = warehouse.Connection;
            cmd.Parameters.Add("@userID", MySqlDbType.String);
            fillData();
        }

        //Fill dataGridView with all Users from database
        public void fillData()
        {
            try
            {
                if (connection != null)
                {
                    query = queries.getAllUsers;
                    MySqlDataAdapter sqladapter = new MySqlDataAdapter();
                    cmd.CommandText = query;
                    cmd.Connection = connection;

                    sqladapter.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    BindingSource bindS = new BindingSource();

                    sqladapter.Fill(dt);

                    bindS.DataSource = dt;
                    dgvUsers.DataSource = bindS;
                    dgvUsers.Update();
                    dgvUsers.Refresh();
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

        private void addUser_Click(object sender, EventArgs e)
        {
            user = new AddEditUser();
            //Passing form name to identify already opened form to keep using of one form,
            //reference to object and type of form to switch between Add and Edit form view and behavior
            openWindow("AddEditUser", ref user, "Add");
            //Set customer ID to update customer information in the form
            user.setID(-1);
        }

        private void editUser_Click(object sender, EventArgs e)
        {
            //Customer id in database
            int id;
            int.TryParse(dgvUsers.Rows[dgvUsers.SelectedRows[0].Index].Cells[0].Value.ToString(), out id);
            user = new AddEditUser();
            openWindow("AddEditUser", ref user, "Edit");
            user.setID(id);
        }

        private void openWindow(string formName, ref AddEditUser form, string type)
        {
            //If form is not exists in application
            if (((Form)Application.OpenForms[formName]) == null)
            {
                form.MdiParent = (Form)Application.OpenForms["WarehouseSystem"];
                if (type == "Add") form.setType("Add");
                else form.setType("Edit");
                form.Show();
            }
            //If this form already opened
            else
            {
                form = (AddEditUser)Application.OpenForms[formName];
                if (type == "Add") form.setType("Add");
                else form.setType("Edit");
                form.Focus();
            }
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(dgvUsers.Rows[dgvUsers.SelectedRows[0].Index].Cells[0].Value.ToString(), out id);
            cmd.Parameters["@userID"].Value = id;
            if (id == 1)
            {
                MessageBox.Show("You cannot delete Default Admin account");
            }
            else
            {
                try
                {
                    if (connection != null)
                    {
                        cmd.CommandText = queries.deleteUser;
                        cmd.Connection = connection;
                        cmd.ExecuteNonQuery();
                        fillData();
                    }
                    else
                    {
                        MessageBox.Show("Connection Lost");
                    }
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Users_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Destroy the corresponding Tabpage when closing MDI child form
            this.tabPag.Dispose();

            //If no Tabpage left
            if (!tabCtrl.HasChildren)
            {
                tabCtrl.Visible = false;
            }
        }

        private void Users_Activated(object sender, EventArgs e)
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
    }
}
