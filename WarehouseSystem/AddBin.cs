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

        public AddBin()
        {
            InitializeComponent();
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

   //             string tmp = _bins.aisles.getAisleID;
   //             if (int.TryParse(tmp, out aisleID)) { }
  //              else { MessageBox.Show(tmp); }
            }
        }
    }
}
