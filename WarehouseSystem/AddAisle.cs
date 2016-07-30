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
        private WarehouseSystem warehouse;

        MySqlConnection connection;
        DBqueries queries = new DBqueries();
        MySqlCommand cmd = new MySqlCommand();
        private Warehouse _aisles;
        private string _type;
        string query;
        int aisleID;

        internal WarehouseSystem WarehouseInstance
        {
            get { return warehouse; }
            set { warehouse = value; }
        }

        internal Warehouse aisles
        {
            get { return _aisles; }
            set { _aisles = value; }
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
            warehouse.AddAisle = null;
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
            int shelfID;
            int shelvesNum;
            int binsNum = 0;
            bool bins = false;
            try
            {
                if (connection != null)
                {
                    if (_type == "AddAisle")
                    {
                        query = queries.addAisle;
                        cmd.CommandText = query;
                        cmd.Connection = connection;
                        cmd.Parameters["@aisleName"].Value = txtAisleName.Text;
                        aisleID = int.Parse(cmd.ExecuteScalar().ToString());

                        if (txtShelvesNumber.Text != "")
                        {
                            cmd.Parameters["@aisleID"].Value = aisleID;

                            if (txtBinsNumber.Text != "" && txtHeight.Text != "" && txtLength.Text != ""
                                && txtMaxWeight.Text != "" && txtWidth.Text != "")
                            {
                                int.TryParse(txtBinsNumber.Text, out binsNum);
                                cmd.Parameters["@maxLength"].Value = txtLength.Text;
                                cmd.Parameters["@maxWeight"].Value = txtMaxWeight.Text;
                                cmd.Parameters["@maxHeight"].Value = txtHeight.Text;
                                cmd.Parameters["@maxWidth"].Value = txtWidth.Text;
                                bins = true;
                            }

                            if (int.TryParse(txtShelvesNumber.Text, out shelvesNum))
                            {
                                for (int s = 0; s < shelvesNum; s++)
                                {
                                    query = queries.addShelf;
                                    cmd.CommandText = query;
                                    shelfID = int.Parse(cmd.ExecuteScalar().ToString());

                                    if (bins)
                                    {
                                        query = queries.addBin;
                                        cmd.CommandText = query;
                                        cmd.Parameters["@shelf"].Value = shelfID;
                                        for (int b = 0; b < binsNum; b++)
                                        {
                                            cmd.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if(_type == "AddShelf")
                    {
                        query = queries.addShelf;
                        cmd.CommandText = query;
                        cmd.Connection = connection;
                        cmd.Parameters["@aisleID"].Value = aisleID;
                        shelfID = int.Parse(cmd.ExecuteScalar().ToString());

                        if (txtBinsNumber.Text != "" && txtHeight.Text != "" && txtLength.Text != ""
                                && txtMaxWeight.Text != "" && txtWidth.Text != "")
                        {
                            if (int.TryParse(txtBinsNumber.Text, out binsNum))
                            {
                                cmd.Parameters["@maxLength"].Value = txtLength.Text;
                                cmd.Parameters["@maxWeight"].Value = txtMaxWeight.Text;
                                cmd.Parameters["@maxHeight"].Value = txtHeight.Text;
                                cmd.Parameters["@maxWidth"].Value = txtWidth.Text;

                                query = queries.addBin;
                                cmd.CommandText = query;
                                cmd.Parameters["@shelf"].Value = shelfID;
                                for (int b = 0; b < binsNum; b++)
                                {
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Enter numeric value for bins number");
                            }
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
            warehouse.AddAisle = this;
        }

        internal void setType(string type)
        {
            _type = type;
            if(_type == "AddAisle")
            {
                this.Text = "Add Aisle";
                txtAisleName.Enabled = true;
                txtAisleName.Text = "";
                txtShelvesNumber.Enabled = true;
                txtShelvesNumber.Text = "";
                label3.Text = "Number of Bins on Each Shelf";
                tabPag.Text = this.Text;
            }
            else if(_type == "AddShelf")
            {
                this.Text = "Add Shelf";
                txtAisleName.Enabled = false;
                txtAisleName.Text = _aisles.getAisleName;
                txtShelvesNumber.Enabled = false;
                txtShelvesNumber.Text = "1";
                label3.Text = "Number of Bins on the Shelf";
                tabPag.Text = this.Text;

                string tmp = _aisles.getAisleID;
                if (int.TryParse(tmp, out aisleID)) {  }
                else { MessageBox.Show(tmp); }
            }
        }
    }
}
