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
    public partial class Inventory : Form
    {
        private WarehouseSystem warehouse = (WarehouseSystem)Application.OpenForms["WarehouseSystem"];
        private AddEditInventory addEditInventory = null;
        MySqlConnection connection;
        MySqlCommand cmd = new MySqlCommand();
        DBqueries queries = new DBqueries();
        string query;

        public Inventory()
        {
            InitializeComponent();
        }


        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            addEditInventory = new AddEditInventory();
            openWindow("AddEditInventory", addEditInventory, "Add");
        }

        private void btnEditInventory_Click(object sender, EventArgs e)
        {
            addEditInventory = new AddEditInventory();
            openWindow("AddEditInventory", addEditInventory, "Edit");
        }

        private void openWindow(string formName, AddEditInventory form, string type)
        {
            if (((Form)Application.OpenForms[formName]) == null)
            {
                form.MdiParent = (Form)Application.OpenForms["WarehouseSystem"];
                if (type == "Add") form.setType("Add");
                else form.setType("Edit");
                form.Show();
            }
            else
            {
                form = (AddEditInventory)Application.OpenForms[formName];
                if (type == "Add") form.setType("Add");
                else form.setType("Edit");
                form.Focus();
            }
        }

        private void Customers_Load(object sender, EventArgs e)
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
                    query = queries.getAllCustomers;
                    MySqlDataAdapter sqladapter = new MySqlDataAdapter();
                    cmd.CommandText = query;
                    cmd.Connection = connection;

                    sqladapter.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    BindingSource bindS = new BindingSource();

                    sqladapter.Fill(dt);

                    bindS.DataSource = dt;
                    dgvInventory.DataSource = bindS;
                    dgvInventory.Update();
                    dgvInventory.Refresh();
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
