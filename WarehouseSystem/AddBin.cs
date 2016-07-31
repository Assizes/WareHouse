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
    public partial class AddBin : Form
    {
        private WarehouseSystem warehouse;
        private AddEditBins _bins;
        private int shelfID;
        private int binID;
        MySqlConnection connection;
        DBqueries queries = new DBqueries();
        MySqlCommand cmd = new MySqlCommand();
        string _type;
        string query;

        internal WarehouseSystem WarehouseInstance
        {
            get { return warehouse; }
            set { warehouse = value; }
        }

        internal AddEditBins Bins
        {
            get { return _bins; }
            set { _bins = value; }
        }

        internal int shelf
        {
            set { shelfID = value; }
        }

        internal int Bin
        {
            set { binID = value; }
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

        public AddBin(int ID)
        {
            InitializeComponent();
            cmd.Parameters.Add("@binID", MySqlDbType.String);
            cmd.Parameters.Add("@shelf", MySqlDbType.String);
            cmd.Parameters.Add("@maxWeight", MySqlDbType.String);
            cmd.Parameters.Add("@maxHeight", MySqlDbType.String);
            cmd.Parameters.Add("@maxWidth", MySqlDbType.String);
            cmd.Parameters.Add("@maxLength", MySqlDbType.String);
            shelfID = ID;
        }

        private void AddBin_Activated(object sender, EventArgs e)
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

        private void AddBin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Destroy the corresponding Tabpage when closing MDI child form
            this.tabPag.Dispose();

            //If no Tabpage left
            if (!tabCtrl.HasChildren)
            {
                tabCtrl.Visible = false;
            }
            warehouse.AddBin = null;
            tabCtrl.SelectedTab = warehouse.previousWindow;
        }

        private void AddBin_Load(object sender, EventArgs e)
        {
            connection = warehouse.Connection;
            warehouse.AddBin = this;
        }

        internal void setType(string type)
        {
            _type = type;
            if (_type == "AddBin")
            {
                this.Text = "Add Bin";

                tabPag.Text = this.Text;
            }
            else if (_type == "EditBin")
            {
                this.Text = "Edit Bin";
                tabPag.Text = this.Text;
                fillData();
   //             string tmp = _bins.aisles.getAisleID;
   //             if (int.TryParse(tmp, out aisleID)) { }
  //              else { MessageBox.Show(tmp); }
            }
        }

        private void fillData()
        {
            try
            {
                if (connection != null)
                {
                    query = queries.getBin;
                    cmd.Parameters["@binID"].Value = binID;
                    cmd.CommandText = query;
                    cmd.Connection = connection;
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtMaxWeight.Text = dr[0].ToString();
                        txtHeight.Text = dr[1].ToString();
                        txtWidth.Text = dr[2].ToString();
                        txtLength.Text = dr[3].ToString();
                    }
                    dr.Close();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection != null)
                {
                    cmd.Parameters["@maxWeight"].Value = txtMaxWeight.Text;
                    cmd.Parameters["@maxHeight"].Value = txtHeight.Text;
                    cmd.Parameters["@maxWidth"].Value = txtWidth.Text;
                    cmd.Parameters["@maxLength"].Value = txtLength.Text;
                    
                    if (_type == "AddBin")
                    {
                        query = queries.addBin;
                        cmd.Parameters["@shelf"].Value = shelfID;
                    }
                    else if(_type == "EditBin")
                    {
                        query = queries.updateBin;
                        cmd.Parameters["@binID"].Value = binID;
                    }
                    cmd.CommandText = query;
                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();

                    _bins.fillBins();
                    this.Close();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
