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
        //Reference to the MDI parent window
        private WarehouseSystem warehouse = (WarehouseSystem)Application.OpenForms["WarehouseSystem"];
        private AddCustomers addCustomer = null;
        //Reference to database connection
        MySqlConnection connection;
        MySqlCommand cmd = new MySqlCommand();
        DBqueries queries = new DBqueries();
        TabPage tp;

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

        public Customers()
        {
            InitializeComponent();
            cmd.Parameters.Add("@customerID", MySqlDbType.String);
        }

        private void btnAddCustomers_Click(object sender, EventArgs e)
        {
            addCustomer = new AddCustomers();
            //Passing form name to identify already opened form to keep using of one form,
            //reference to object and type of form to switch between Add and Edit form view and behavior
            openWindow("AddCustomers", ref addCustomer, "Add");
            //Set customer ID to update customer information in the form
            addCustomer.setID(-1);
        }

        private void btnEditCustomers_Click(object sender, EventArgs e)
        {
            //Customer id in database
            int id;
            int.TryParse(dgvCustomers.Rows[dgvCustomers.SelectedRows[0].Index].Cells[0].Value.ToString(),out id);
            addCustomer = new AddCustomers();
            openWindow("AddCustomers", ref addCustomer, "Edit");
            addCustomer.setID(id);
        }

        private void openWindow(string formName, ref AddCustomers form, string type)
        {
            //If form is not exists in application
            if (((Form)Application.OpenForms[formName]) == null)
            {
                form.MdiParent = (Form)Application.OpenForms["WarehouseSystem"];
                if (type == "Add") form.setType("Add");
                else form.setType("Edit");
                form.TabCtrl = warehouse.tabControl1;
                tp = new TabPage();
                //Add a Tabpage and enables it
                tp.Parent = warehouse.tabControl1;
                tp.Text = form.Text;
                tp.Show();

                //child Form will now hold a reference value to a tabpage
                form.TabPag = tp;

                //Activate the newly created Tabpage
                warehouse.tabControl1.SelectedTab = tp;
                warehouse.tabControl1.Visible = true;
                form.Show();
            }
            //If this form already opened
            else
            {
                form = (AddCustomers)Application.OpenForms[formName];
                if (type == "Add") form.setType("Add");
                else form.setType("Edit");
                form.Focus();
                tp.Text = form.Text;
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            connection = warehouse.Connection;
            fillData();
        }

        //Get Information about all customers and put it in DataGridView
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
                    dgvCustomers.DataSource = bindS;
                    dgvCustomers.Update();
                    dgvCustomers.Refresh();
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

        private void btnDeleteCustomers_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(dgvCustomers.Rows[dgvCustomers.SelectedRows[0].Index].Cells[0].Value.ToString(), out id);
            try
            {
                if (connection != null)
                {
                    cmd.CommandText = queries.deleteCustomer;
                    cmd.Parameters["@customerID"].Value = id;
                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();
                    fillData();
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

        private void Customers_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Destroy the corresponding Tabpage when closing MDI child form
            this.tabPag.Dispose();

            //If no Tabpage left
            if (!tabCtrl.HasChildren)
            {
                tabCtrl.Visible = false;
            }
        }

        private void Customers_Activated(object sender, EventArgs e)
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
    }
}
