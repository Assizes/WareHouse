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
        AddAisle addAisle;
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

        private void btnAddAisle_Click(object sender, EventArgs e)
        {
            addAisle = new AddAisle();
            if (((AddAisle)Application.OpenForms["AddAisle"]) == null)
            {
                addAisle.MdiParent = warehouse;
                addAisle.Show();
                addAisle.TabCtrl = warehouse.tabControl1;
                //Add a Tabpage and enables it
                TabPage tp = new TabPage();
                tp.Parent = warehouse.tabControl1;
                tp.Text = addAisle.Text;
                tp.Show();

                //child Form will now hold a reference value to a tabpage
                addAisle.TabPag = tp;

                //Activate the newly created Tabpage
                warehouse.tabControl1.SelectedTab = tp;
                warehouse.tabControl1.Visible = true;
            }
            //If this form already opened
            else
            {
                addAisle = (AddAisle)Application.OpenForms["AddAisle"];
                addAisle.Focus();
            }
        }

        private void btnDeleteAisle_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnAddShelf_Click(object sender, EventArgs e)
        {
            //TODO
        }
        private void btnEditShelf_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnDeleteShelf_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}
