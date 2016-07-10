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
    public partial class Customers : Form
    {
        private WarehouseSystem warehouse = (WarehouseSystem)Application.OpenForms["WarehouseSystem"];
        MySqlConnection connection;
        MySqlCommand cmd = new MySqlCommand();
        DBqueries queries = new DBqueries();

        string query;

        public Customers()
        {
            InitializeComponent();
        }

        private void btnAddCustomers_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCustomers_Click(object sender, EventArgs e)
        {

        }

        private void Customers_Load(object sender, EventArgs e)
        {
            connection = warehouse.getConnection();

            try
            {
                if (connection != null)
                {
                    query = queries.getAllCustomers;
                    MySqlDataAdapter sqladapter = new MySqlDataAdapter();
                    cmd.CommandText = query;
                    cmd.Connection = connection;

                    sqladapter.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    BindingSource bindS = new BindingSource();

                    sqladapter.Fill(dt);

                    bindS.DataSource = dt;
                    dgvCustomers.DataSource = bindS;
                    dgvCustomers.Update();
                    dgvCustomers.Refresh();
                }
                else
                {
                    MessageBox.Show("Connection Failed");
                    this.Close();
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
