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
    public partial class CustomerItem : Form
    {
        private WarehouseSystem warehouse = (WarehouseSystem)Application.OpenForms["WarehouseSystem"];
        MySqlConnection connection;
        MySqlCommand cmd = new MySqlCommand();
        DBqueries queries = new DBqueries();
        string query;

        public CustomerItem()
        {
            InitializeComponent();
        }

        private void btnCustomerItemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerItem_Load(object sender, EventArgs e)
        {
            connection = warehouse.Connection;
            fillData();
        }

        public void fillData()
        {
            try
            {
                if (connection != null)
                {
                    //need to change query
                    query = queries.getAllInv;
                    MySqlDataAdapter sqladapter = new MySqlDataAdapter();
                    cmd.CommandText = query;
                    cmd.Connection = connection;

                    sqladapter.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    BindingSource bindS = new BindingSource();

                    sqladapter.Fill(dt);

                    bindS.DataSource = dt;
                    dgvCustomerItem.DataSource = bindS;
                    dgvCustomerItem.Update();
                    dgvCustomerItem.Refresh();
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
    }
}
