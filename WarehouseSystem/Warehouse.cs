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
    public partial class Warehouse : Form
    {
        private WarehouseSystem warehouse = (WarehouseSystem)Application.OpenForms["WarehouseSystem"];
        MySqlConnection connection;
        DBqueries queries = new DBqueries();
        MySqlCommand cmd = new MySqlCommand();

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

        public Warehouse()
        {
            InitializeComponent();
            cmd.Parameters.Add("@aisleID", MySqlDbType.String);
        }

        private void btnAddAisle_Click(object sender, EventArgs e)
        {

        }

        private void Warehouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Destroy the corresponding Tabpage when closing MDI child form
            this.tabPag.Dispose();

            //If no Tabpage left
            if (!tabCtrl.HasChildren)
            {
                tabCtrl.Visible = false;
            }
        }

        private void Warehouse_Activated(object sender, EventArgs e)
        {
            //Activate the corresponding Tabpage
            tabCtrl.SelectedTab = tabPag;

            if (!tabCtrl.Visible)
            {
                tabCtrl.Visible = true;
            }
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            connection = warehouse.Connection;
            fillAisles();
        }
        public void fillAisles()
        {
            try
            {
                if (connection != null)
                {
                    query = queries.getAllAisles;
                    MySqlDataAdapter sqladapter = new MySqlDataAdapter();
                    cmd.CommandText = query;
                    cmd.Connection = connection;

                    sqladapter.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    BindingSource bindS = new BindingSource();

                    sqladapter.Fill(dt);

                    bindS.DataSource = dt;
                    dgvAisles.DataSource = bindS;
                    dgvAisles.Update();
                    dgvAisles.Refresh();
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

        private void dgvAisles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int aisle;
            if (int.TryParse(dgvAisles.SelectedRows[0].Cells[0].Value.ToString(), out aisle))
            {
                try
                {
                    if (connection != null)
                    {
                        query = queries.getShelves;
                        cmd.Parameters["@aisleID"].Value = aisle;
                        MySqlDataAdapter sqladapter = new MySqlDataAdapter();
                        cmd.CommandText = query;
                        cmd.Connection = connection;

                        sqladapter.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        BindingSource bindS = new BindingSource();

                        sqladapter.Fill(dt);

                        bindS.DataSource = dt;
                        dgvShelves.DataSource = bindS;
                        dgvShelves.Update();
                        dgvShelves.Refresh();
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
    }
}
