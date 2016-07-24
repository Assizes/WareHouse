using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseSystem
{
    public partial class WarehouseSystem : Form
    {
        private Form welcome = null;
        private Users users = null;
        private Inventory inventory = null;
        private Customers customers = null;
        private Warehouse warehouse = null;
        private static MySqlConnection connection = null;
        ConnectDB dbinfo;
        MySqlCommand cmd;
        DBqueries queries = new DBqueries();

        string query;
        private string login = "";


        public MySqlConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        public WarehouseSystem()
        {
            InitializeComponent();
        }
        
        private void WarehouseSystem_Load(object sender, EventArgs e)
        {
            //Change the background color of Parent MDI panel
            MdiClient ctlMDI = null;

            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;

                    
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }

               
            }
            dbinfo = new ConnectDB();
            cmd = new MySqlCommand();
            connect();
        }

        private void connect()
        {
            connection = new MySqlConnection(dbinfo.ToString());
            connection.Open();

            cmd.Parameters.Add("@Login", MySqlDbType.String);
            cmd.Parameters.Add("@Pass", MySqlDbType.String);
            if (connection != null)
            {
                MessageBox.Show("Data Base Connected!");
            }
            else
            {
                MessageBox.Show("Connection Failed");
                this.Close();
            }

        }

        private void signBtn_Click(object sender, EventArgs e)
        {
            login = loginInput.Text;

            PasswordEncription ps = new PasswordEncription(passInput.Text);

            string input = ps.getHash();
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            //Check a user in a database and retrive his hashed password
            if (connection != null)
            {
                query = queries.checkUserCredentials;
                MySqlDataAdapter mcmd = new MySqlDataAdapter();
                cmd.Parameters["@Login"].Value = login;
                cmd.CommandText = query;
                cmd.Connection = connection;

                mcmd.SelectCommand = cmd;
                DataTable dt = new DataTable();
                mcmd.Fill(dt);

                if (dt.Rows.Count > 0 && 0 == comparer.Compare(input, dt.Rows[0]["User_Password"].ToString()))
                {
                    // Hide and disable login screen
                    loginScreen.Visible = false;
                    loginScreen.Enabled = false;

                    int tmp;
                    int.TryParse(dt.Rows[0]["userRoleID"].ToString(), out tmp);
                    // Enable menu tabs
                    if (tmp == 1) //if user is admin enable menu for users
                    {
                        toolStripUsersMenu.Enabled = true;
                        warehouseToolStripMenuItem.Enabled = true;
                    }
                    clientsToolStripMenuItem.Enabled = true;
                    inventoryToolStripMenuItem.Enabled = true;
                    openWelcomeScreen(tmp);
                }
                else
                {
                    MessageBox.Show("Please enter valid user name and password");
                }

            }
            else
            {
                MessageBox.Show("Connection to DataBase Have Been Lost");
            }
        }

        private void openWelcomeScreen(int tmp)
        {
            if (((Form)Application.OpenForms["Menu"]) == null)
            {
                welcome = new menuForm(tmp);
                welcome.MdiParent = this;
                welcome.Show();
            }
            else
            {
                welcome.Focus();
            }
        }

        //change location of MenuMDI child screen when Parent screen resized
        private void WarehouseSystem_SizeChanged(object sender, EventArgs e)
        {
            if (welcome != null)
            {
                Point p = new Point(Location.X - this.Location.X - 10 + (this.Width - welcome.Width) / 2, Location.Y - this.Location.Y - 38 + (this.Height - Convert.ToInt32(welcome.Height)) / 2);
                welcome.Location = p;
            }
        }

        private void toolStripUsersMenu_Click(object sender, EventArgs e)
        {
            openUser();
        }
        public void openUser()
        {
            if (((Users)Application.OpenForms["Users"]) == null)
            {
                users = new Users();
                users.MdiParent = this;
                users.Show();
                users.TabCtrl = tabControl1;
                //Add a Tabpage and enables it
                TabPage tp = new TabPage();
                tp.Parent = tabControl1;
                tp.Text = users.Text;
                tp.Show();

                //child Form will now hold a reference value to a tabpage
                users.TabPag = tp;

                //Activate the MDI child form
                users.Show();

                //Activate the newly created Tabpage
                tabControl1.SelectedTab = tp;
                tabControl1.Visible = true;
            }
            else
            {
                users = (Users)Application.OpenForms["Users"];
                users.Focus();
            }
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openInventory();
        }
        public void openInventory()
        {
            if (((Inventory)Application.OpenForms["Inventory"]) == null)
            {
                inventory = new Inventory();
                inventory.MdiParent = this;
                inventory.Show();
                inventory.TabCtrl = tabControl1;
                //Add a Tabpage and enables it
                TabPage tp = new TabPage();
                tp.Parent = tabControl1;
                tp.Text = inventory.Text;
                tp.Show();

                //child Form will now hold a reference value to a tabpage
                inventory.TabPag = tp;

                //Activate the MDI child form
                inventory.Show();

                //Activate the newly created Tabpage
                tabControl1.SelectedTab = tp;
                tabControl1.Visible = true;
            }
            else
            {
                inventory = (Inventory)Application.OpenForms["Inventory"];
                inventory.Focus();
            }
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openCustomers();
        }

        public void openCustomers()
        {
            if (((Customers)Application.OpenForms["Customers"]) == null)
            {
                customers = new Customers();
                customers.MdiParent = this;
                customers.Show();
                customers.TabCtrl = tabControl1;
                //Add a Tabpage and enables it
                TabPage tp = new TabPage();
                tp.Parent = tabControl1;
                tp.Text = customers.Text;
                tp.Show();

                //child Form will now hold a reference value to a tabpage
                customers.TabPag = tp;

                //Activate the MDI child form
                customers.Show();

                //Activate the newly created Tabpage
                tabControl1.SelectedTab = tp;
                tabControl1.Visible = true;
            }
            else
            {
                customers = (Customers)Application.OpenForms["Customers"];
                customers.Focus();
            }
        }

        private void warehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openWarehouse();   
        }

        public void openWarehouse()
        {
            if (((Warehouse)Application.OpenForms["Warehouse"]) == null)
            {
                warehouse = new Warehouse();
                warehouse.MdiParent = this;
                warehouse.Show();
                warehouse.TabCtrl = tabControl1;
                //Add a Tabpage and enables it
                TabPage tp = new TabPage();
                tp.Parent = tabControl1;
                tp.Text = warehouse.Text;
                tp.Show();

                //child Form will now hold a reference value to a tabpage
                warehouse.TabPag = tp;

                //Activate the MDI child form
                warehouse.Show();

                //Activate the newly created Tabpage
                tabControl1.SelectedTab = tp;
                tabControl1.Visible = true;
            }
            else
            {
                warehouse = (Warehouse)Application.OpenForms["Warehouse"];
                warehouse.Focus();
            }
        }

        /*
        private void openWindow(string formName, Form form)
        {
            if (((Form)Application.OpenForms[formName]) == null)
            {
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                form = (Form)Application.OpenForms[formName];
                form.Focus();
            }
        }
        */

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (inventory.TabPag.Equals(tabControl1.SelectedTab))
                    inventory.Select();
            }
            catch { }
            try
            {
                if (users.TabPag.Equals(tabControl1.SelectedTab))
                    users.Select();
            }
            catch { }
            try
            {
                if (customers.TabPag.Equals(tabControl1.SelectedTab))
                    customers.Select();
            }
            catch { }
            try
            {
                if (warehouse.TabPag.Equals(tabControl1.SelectedTab))
                    warehouse.Select();
            }
            catch { }
        }

        private void databaseConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}
