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
        private Warehouse _aisles;

        internal Warehouse aisles
        {
            get { return _aisles; }
            set { _aisles = value; }
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
            int aisleID;
            int shelfID;
            int shelvesNum;
            int binsNum = 0;
            bool bins = false;
            try
            {
                if (connection != null)
                {
                    query = queries.addAisle;
                    cmd.CommandText = query;
                    cmd.Connection = connection;
                    cmd.Parameters["@aisleName"].Value = txtAisleName.Text;
                    aisleID = int.Parse(cmd.ExecuteScalar().ToString());

                    if(txtShelvesNumber.Text != "")
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
                                MessageBox.Show(""+shelfID);

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
