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
        MySqlConnection connection = null;
        ConnectDB dbinfo;
        MySqlCommand cmd;
        DBqueries queries = new DBqueries();
        string query;
        private string login = "";

        public WarehouseSystem()
        {
            InitializeComponent();
        }

        
        private void WarehouseSystem_Load(object sender, EventArgs e)
        {
            //Change the background color of Parant MDI panel
            MdiClient ctlMDI;

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

            //Build hash strin from entered password
            byte[] hash;
            HashAlgorithm sha = new SHA512CryptoServiceProvider();
            hash = sha.ComputeHash(Encoding.Default.GetBytes(passInput.Text));

            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < hash.Length; i++)
            {
                sBuilder.Append(hash[i].ToString("x2"));
            }

            string input = sBuilder.ToString();
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            //Check user in database and retrive his hashed password
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
                    // Enable menu tabs
                    //           toolsMenu.Enabled = true;
                    //           buildingsToolStripMenuItem.Enabled = true;
                    //           tennantsToolStripMenuItem.Enabled = true;
                    //            employeeToolStripMenuItem.Enabled = true;
                    //            usersToolStripMenuItem1.Enabled = true;
                    openWelcomeScreen();
                }
                else
                {
                    MessageBox.Show("Please enter valid user name and password");
                }

                /*
                DataSet ds = new DataSet();
                mcmd.Fill(ds);
                     contBox.DataSource = ds.Tables[0];
                     contBox.ValueMember = "Continent";
                     contBox.DisplayMember = "Continent";
                mcmd.Dispose();
                */
            }
            else
            {
                MessageBox.Show("Connection to DataBase Have Been Lost");
            }
        }

        private void openWelcomeScreen()
        {
            if (((Form)Application.OpenForms["Menu"]) == null)
            {
                welcome = new menuForm();
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
                Point p = new Point(Location.X - this.Location.X - 10 + (this.Width - welcome.Width) / 2, Location.Y - this.Location.Y - 10 + (this.Height - Convert.ToInt32(welcome.Height)) / 2);
                welcome.Location = p;
            }
        }
    }
}
