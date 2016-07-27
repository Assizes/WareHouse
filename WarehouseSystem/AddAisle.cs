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
    public partial class AddAisle : Form
    {
        private WarehouseSystem warehouse = (WarehouseSystem)Application.OpenForms["WarehouseSystem"];

        MySqlConnection connection;
        DBqueries queries = new DBqueries();
        MySqlCommand cmd = new MySqlCommand();

        internal Warehouse aisles
        {
            get { return aisles; }
            set { aisles = value; }
        }

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

        public AddAisle()
        {
            InitializeComponent();
            cmd.Parameters.Add("@aisleName", MySqlDbType.String);
            cmd.Parameters.Add("@aisleID", MySqlDbType.String);
            cmd.Parameters.Add("@shelf", MySqlDbType.String);
            cmd.Parameters.Add("@maxWeight", MySqlDbType.String);
            cmd.Parameters.Add("@maxHeight", MySqlDbType.String);
            cmd.Parameters.Add("@maxWidth", MySqlDbType.String);
            cmd.Parameters.Add("@maxLength", MySqlDbType.String);
        }

        private void AddAisle_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Destroy the corresponding Tabpage when closing MDI child form
            this.tabPag.Dispose();

            //If no Tabpage left
            if (!tabCtrl.HasChildren)
            {
                tabCtrl.Visible = false;
            }
        }

        private void AddAisle_Activated(object sender, EventArgs e)
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

        private void btnClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave(object sender, EventArgs e)
        {
            string id;
            int rows;
            try
            {
                if (connection != null)
                {
                    query = queries.addAisle;
                    cmd.CommandText = query;
                    cmd.Connection = connection;
                    cmd.Parameters["@aisleName"].Value = txtAisleName.Text;
                    id = cmd.ExecuteScalar().ToString();

                    if(txtShelvesNumber.Text != "")
                    {
                        query = queries.addShelf;
                        cmd.CommandText = query;
                        cmd.Connection = connection;
                        cmd.Parameters["@aisleID"].Value = id;

                        if(int.TryParse(txtShelvesNumber.Text, out rows))
                            for (int i = 0; i < rows; i++)
                                cmd.ExecuteNonQuery();

                        if(txtShelvesNumber.Text != "")
                        {

                        }
                    }
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
            aisles.fillAisles();
            this.Close();
        }

        private void AddAisle_Load(object sender, EventArgs e)
        {
            connection = warehouse.Connection;
        }
    }
}
