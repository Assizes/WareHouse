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
            warehouse.openInventory();
        }


        private void btnCustomers_Click(object sender, EventArgs e)
        {
            warehouse.openCustomers();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            warehouse.openUser();
        }
        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            warehouse.openWarehouse();
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
