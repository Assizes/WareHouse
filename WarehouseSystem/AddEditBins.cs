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
    public partial class AddEditBins : Form
    {
        private WarehouseSystem warehouse;
        MySqlConnection connection;
        private Warehouse _aisles;
        DBqueries queries = new DBqueries();
        MySqlCommand cmd = new MySqlCommand();
        string query;

        internal Warehouse aisles
        {
            get { return _aisles; }
            set { _aisles = value; }
        }

        internal WarehouseSystem WarehouseInstance
        {
            get { return warehouse; }
            set { warehouse = value; }
        }

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

        public AddEditBins()
        {
            InitializeComponent();
            cmd.Parameters.Add("@shelf", MySqlDbType.String);
        }

        private void AddEditBins_Activated(object sender, EventArgs e)
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

        private void AddEditBins_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Destroy the corresponding Tabpage when closing MDI child form
            this.tabPag.Dispose();

            //If no Tabpage left
            if (!tabCtrl.HasChildren)
            {
                tabCtrl.Visible = false;
            }
            warehouse.Bins = null;
        }

        private void fillBins()
        {
            int shelf;
            if (int.TryParse(_aisles.getShelfID, out shelf) && _aisles.getShelfID != "0")
            {
                try
                {
                    if (connection != null)
                    {
                        query = queries.getAllBins;
                        cmd.Parameters["@shelf"].Value = shelf;
                        MySqlDataAdapter sqladapter = new MySqlDataAdapter();
                        cmd.CommandText = query;
                        cmd.Connection = connection;

                        sqladapter.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        BindingSource bindS = new BindingSource();

                        sqladapter.Fill(dt);

                        bindS.DataSource = dt;
                        dgvBins.DataSource = bindS;
                        dgvBins.Update();
                        dgvBins.Refresh();
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
                MessageBox.Show("Please, Select Aisle first");
            }
        }

        private void AddEditBins_Load(object sender, EventArgs e)
        {
            connection = warehouse.Connection;
            fillBins();
        }
    }
}
