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
        private AddBin addBin;
        DBqueries queries = new DBqueries();
        MySqlCommand cmd = new MySqlCommand();
        string query;
        int binID;
        int shelf;

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
            cmd.Parameters.Add("@binID", MySqlDbType.String);
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

        internal void fillBins()
        {
            if (int.TryParse(_aisles.getShelfID, out shelf))
            {
                try
                {
                    if (connection != null)
                    {
                        query = queries.getShelfBins;
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
            warehouse.Bins = this;
            fillBins();
        }

        private void btnAddBin_Click(object sender, EventArgs e)
        {
            openAddBin("AddBin");
        }

        private void btnEditBin_Click(object sender, EventArgs e)
        {
            openAddBin("EditBin");
        }

        private void openAddBin(string type)
        {
            if (warehouse.AddBin == null)
            {
                addBin = new AddBin(shelf);
                addBin.WarehouseInstance = warehouse;
                addBin.MdiParent = warehouse;
                addBin.Bins = this;
                
                addBin.Show();
                addBin.TabCtrl = warehouse.tabControl1;
                //Add a Tabpage and enables it
                TabPage tp = new TabPage();
                tp.Parent = warehouse.tabControl1;
                tp.Text = addBin.Text;
                
                tp.Show();

                //child Form will now hold a reference value to a tabpage
                addBin.TabPag = tp;
                addBin.Bin = int.Parse(dgvBins.SelectedRows[0].Cells[0].Value.ToString());
                addBin.setType(type);

                //Activate the newly created Tabpage
                warehouse.tabControl1.SelectedTab = tp;
                warehouse.tabControl1.Visible = true;
            }
            //If this form already opened
            else
            {
                addBin = warehouse.AddBin;
                addBin.Bin = int.Parse(dgvBins.SelectedRows[0].Cells[0].Value.ToString());
                addBin.setType(type);
                addBin.shelf = shelf;
                addBin.Focus();
            }
            warehouse.previousWindow = tabPag;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(_aisles.getShelfID, out binID))
            {
                try
                {
                    if (connection != null)
                    {
                        query = queries.deleteBin;
                        cmd.Parameters["@binID"].Value = binID;
                        cmd.CommandText = query;
                        cmd.Connection = connection;
                        cmd.ExecuteNonQuery();
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
    }
}
