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
        private Form buildings = null;
        private Form tenants = null;
        private Form underConst = null;
        Form parent = (Form)Application.OpenForms["MainScreen"];

        public menuForm()
        {
            InitializeComponent();
        }

        private void menuForm_Activated(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openBuildings();
        }

        private void imgBuildings_Click(object sender, EventArgs e)
        {
            openBuildings();
        }

        private void openBuildings()
        {
            if (((Form)Application.OpenForms["buildingsForm"]) == null)
            {
    //            buildings = new buildingsForm();
    //            buildings.MdiParent = parent;
    //            buildings.Show();
            }
            else
            {
                buildings = (Form)Application.OpenForms["buildingsForm"];
                buildings.Focus();
            }
        }

        private void imgTenant_Click(object sender, EventArgs e)
        {
            openTenats();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openTenats();
        }
        private void openTenats()
        {
            if (((Form)Application.OpenForms["tenantsForm"]) == null)
            {
 //               tenants = new tenantsForm();
 //               tenants.MdiParent = parent;
 //               tenants.Show();
            }
            else
            {
                tenants = (Form)Application.OpenForms["tenantsForm"];
                tenants.Focus();
            }
        }
        private void openUnderConst()
        {
            if (((Form)Application.OpenForms["UnderConstruction"]) == null)
            {
 //               underConst = new UnderConstruction();
 //               underConst.MdiParent = parent;
 //               underConst.Show();
            }
            else
            {
                underConst = (Form)Application.OpenForms["UnderConstruction"];
                underConst.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openUnderConst();
        }

        private void imgLockers_Click(object sender, EventArgs e)
        {
            openUnderConst();
        }

        private void imgParking_Click(object sender, EventArgs e)
        {
            openUnderConst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openUnderConst();
        }

        private void imgWaiting_Click(object sender, EventArgs e)
        {
            openUnderConst();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openUnderConst();
        }

        private void imgChanges_Click(object sender, EventArgs e)
        {
            openUnderConst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openUnderConst();
        }

    }
}
