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
    public partial class AddCustomers : Form
    {
        public AddCustomers()
        {
            InitializeComponent();
        }

        private void btnAddCustomerReset_Click(object sender, EventArgs e)
        {
            txtAddCustomerFName.Text = "";
            txtAddCustomerLName.Text = "";
            txtAddCustomerAddress.Text = "";
            txtAddCustomerPhone.Text = "";
            txtAddCustomerCity.Text = "";
            txtAddCustomerProvince.Text = "";
            txtAddCustomerPostalCode.Text = "";
        }
    }
}
