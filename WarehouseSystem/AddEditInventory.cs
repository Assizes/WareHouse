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
    public partial class AddEditInventory : Form
    {
        private WarehouseSystem warehouse = (WarehouseSystem)Application.OpenForms["WarehouseSystem"];
        private Inventory inventory = (Inventory)Application.OpenForms["Inventory"];
        MySqlConnection connection;
        MySqlCommand cmd = new MySqlCommand();
        DBqueries queries = new DBqueries();
        string fType = "Add";
        string query;
        //addedstuff
        MySqlDataReader dr;

        public AddEditInventory()
        {
            InitializeComponent();
            cmd.Parameters.Add("@itemName", MySqlDbType.String);
            cmd.Parameters.Add("@weight", MySqlDbType.String);
            cmd.Parameters.Add("@height", MySqlDbType.String);
            cmd.Parameters.Add("@width", MySqlDbType.String);
            cmd.Parameters.Add("@length", MySqlDbType.String);
            cmd.Parameters.Add("@quantity", MySqlDbType.String);
            cmd.Parameters.Add("@itemDescription", MySqlDbType.String);
            cmd.Parameters.Add("@expirationDate", MySqlDbType.String);

            //added stuff
            connection = warehouse.Connection;
          
            cmd.Parameters.Add("@custID", MySqlDbType.String);

            cmd.CommandText = queries.getCustomer;
            cmd.Connection = connection;

          
            dr = cmd.ExecuteReader();

           // Array temp= new Array[5];

           // List<String> tempList = new List<String>();
            DataSet ds = new DataSet();
            
            while (dr.Read())
            {
              //  tempList.Add(dr[0].ToString());
                cmbItemCustomer.Items.Add(dr[0].ToString());
                
            }

           
            
            dr.Close();
        }

        private void btnItemReset_Click(object sender, EventArgs e)
        {
            if (fType == "Add")
            {
                txtItemName.Text = "";
                txtItemDescription.Text = "";
                txtItemLength.Text = "";
                txtItemWidth.Text = "";
                txtItemHeight.Text = "";
                txtItemWeight.Text = "";
                txtItemQuantity.Text = "";

                cmbItemCategory.SelectedIndex = 0;
                cmbItemCustomer.SelectedIndex = 0;
                cmbUnitofMeasurement.SelectedIndex = 0;
                cmbItemAisle.SelectedIndex = 0;
                cmbItemShelf.SelectedIndex = 0;
                cmbItemBin.SelectedIndex = 0;

                rdoExpirationYes.Checked = false;
                rdoExpirationNo.Checked = true;

                datetimeItemExpiration.Value = DateTime.Today;
            }
            else
            {
                Close();
            }
        }

        public void setType(string type)
        {
            if (type == "Edit")
            {
                btnItemAddSave.Text = "Save";
                btnItemResetCancel.Text = "Cancel";
                fType = type;
            }
            else
            {
                btnItemAddSave.Text = "Add Item";
                btnItemResetCancel.Text = "Reset";
                fType = type;
            }
        }

        private void btnItemAddSave_Click(object sender, EventArgs e)
        {
            connection = warehouse.Connection;
            if (txtItemName.Text != "" && txtItemDescription.Text != "" && txtItemLength.Text != "" &&
                txtItemWidth.Text != "" && txtItemHeight.Text != "" && txtItemWeight.Text != ""
                 && txtItemQuantity.Text != "" && cmbItemCategory.SelectedIndex != 0 && cmbItemCustomer.SelectedIndex != 0
                  && cmbUnitofMeasurement.SelectedIndex != 0 && cmbItemAisle.SelectedIndex != 0 && cmbItemShelf.SelectedIndex != 0
                   && cmbItemBin.SelectedIndex != 0)
            {
                cmd.Parameters["@itemName"].Value = txtItemName.Text;
                cmd.Parameters["@weight"].Value = txtItemWeight.Text;
                cmd.Parameters["@height"].Value = txtItemHeight.Text;
                cmd.Parameters["@width"].Value = txtItemWidth.Text;
                cmd.Parameters["@length"].Value = txtItemLength.Text;
                cmd.Parameters["@quantity"].Value = txtItemQuantity.Text;
                cmd.Parameters["@itemDescription"].Value = txtItemDescription.Text;

                if (rdoExpirationYes.Checked == true)
                {
                    cmd.Parameters["@expirationDate"].Value = datetimeItemExpiration.Text;
                }
                else
                {
                    cmd.Parameters["@expirationDate"].Value = null;
                }

            }
            else
            {
                MessageBox.Show("Please, fill up required fields!");
                return;
            }
//finsih this
         /*  if (fType == "Add")
            {
                try
                {
                    if (connection != null)
                    {
                       /* query = queries.addCustomer;
                        MySqlDataAdapter sqladapter = new MySqlDataAdapter();
                        cmd.CommandText = query;
                        cmd.Connection = connection;
                        cmd.ExecuteNonQuery();
                        customers.fillData();

                        Close();*/

                     /*   cmd.CommandText = queries.getUserInfo;
                        dr = cmd.ExecuteReader();
                        
                        while (dr.Read())
                        {
                            txtLogin.Text = dr[0].ToString();
                            txtFName.Text = dr[1].ToString();
                            txtLName.Text = dr[2].ToString();
                            cmbGroup.SelectedItem = dr[3].ToString();
                        }
                        dr.Close();
                        
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
            else
            {

            } */
        } 
    }
}
