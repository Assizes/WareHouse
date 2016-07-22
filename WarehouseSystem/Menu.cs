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
    public partial class menuForm : Form
    {
        private WarehouseSystem warehouse = (WarehouseSystem)Application.OpenForms["WarehouseSystem"];
        private Form inventory = null;
        private Form customers = null;
        private Form users = null;
        private Form underConst = null;

        Form parent = (Form)Application.OpenForms["WarehouseSystem"];

        public menuForm(int id)
        {
            InitializeComponent();
            if (id != 1)
            {
                btnUsers.Enabled = false;
                btnWarehouse.Enabled = false;
            }
        }

        private void menuForm_Activated(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            inventory = new Inventory();
            openWindow("Inventory", inventory);
        }


        private void btnCustomers_Click(object sender, EventArgs e)
        {
            customers = new Customers();
            openWindow("Customers", customers);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            //  openWindow("Users",users);
            warehouse.openUser();
        }
        private void btnWarehouse_Click(object sender, EventArgs e)
        {

        }

        private void openUnderConst()
        {
            
        }

        private void openWindow(string formName, Form form)
        {
            if (((Form)Application.OpenForms[formName]) == null)
            {
                
                form.MdiParent = parent;
                form.Show();
            }
            else
            {
                form = (Form)Application.OpenForms[formName];
                form.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                warehouse.Connection.Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            warehouse.Close();
        }
    }
}
