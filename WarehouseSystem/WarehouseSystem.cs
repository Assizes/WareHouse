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
        MySqlConnection connection = null;
        ConnectDB dbinfo;
        MySqlCommand cmd;
        DBqueries queries = new DBqueries();
        
        string query;
        private string login = "admin";
        private string pass = "c7ad44cbad762a5da0a452f9e854fdc1e0e7a52a38015f23f3eab1d80b931dd472634dfac71cd34ebc35d16ab7fb8a90c81f975113d6c7538dc69dd8de9077ec";
        
        public WarehouseSystem()
        {
            InitializeComponent();
        }

        
        private void WarehouseSystem_Load(object sender, EventArgs e)
        {
            //Change the background color of Parent MDI panel
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

            cmd.Parameters.Add("@Continent", MySqlDbType.String);
            cmd.Parameters.Add("@Region", MySqlDbType.String);

            if (connection != null)
            {
                MessageBox.Show("Database Connected!");
                query = queries.q1;
                MySqlDataAdapter mcmd = new MySqlDataAdapter();
                cmd.CommandText = query;
                cmd.Connection = connection;

                mcmd.SelectCommand = cmd;
                DataSet ds = new DataSet();
                mcmd.Fill(ds);
                //     contBox.DataSource = ds.Tables[0];
                //     contBox.ValueMember = "Continent";
                //     contBox.DisplayMember = "Continent";
                mcmd.Dispose();
            }
            else
            {
                MessageBox.Show("Connection Failed");
                this.Close();
            }

        }

        private void signBtn_Click(object sender, EventArgs e)
        {
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

            if (loginInput.Text.Equals(login) && 0 == comparer.Compare(input, pass))
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
                //            openWelcomeScreen();
              


            }
            else
            {
                MessageBox.Show("Please enter valid user name and password");
            }
        }
    }
}
