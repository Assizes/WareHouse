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

            //hide this
            /* datetimeItemExpiration.Hide();
               lblExpirationDate.Hide();*/
            //Gray out instrad
            lblExpirationDate.Enabled = false;
            datetimeItemExpiration.Enabled = false;
            //====

            cmd.Parameters.Add("@itemName", MySqlDbType.String);
            cmd.Parameters.Add("@weight", MySqlDbType.String);
            cmd.Parameters.Add("@height", MySqlDbType.String);
            cmd.Parameters.Add("@width", MySqlDbType.String);
            cmd.Parameters.Add("@length", MySqlDbType.String);
            cmd.Parameters.Add("@quantity", MySqlDbType.String);
            cmd.Parameters.Add("@itemDescription", MySqlDbType.String);
            cmd.Parameters.Add("@expirationDate", MySqlDbType.String);
            cmd.Parameters.Add("@unitOfMeasurement", MySqlDbType.String);
            cmd.Parameters.Add("@custID", MySqlDbType.String);
            //========two seperate inserts will happen//One for^^ ours other for FK
            cmd.Parameters.Add("@aisleID", MySqlDbType.String);
            cmd.Parameters.Add("@binID", MySqlDbType.String);
            cmd.Parameters.Add("@selfID", MySqlDbType.String);

            //added stuff
            connection = warehouse.Connection;
          
            
            //retrive data to put in dropmenu

            //retrieve customers
            cmd.CommandText = queries.getCustomer;


            cmd.Connection = connection;

            //retrieve aisle,shelf,bin? - generate button does a where?
            dr = cmd.ExecuteReader();


            //DataSet ds = new DataSet();

            while (dr.Read())
            {
              //  tempList.Add(dr[0].ToString());
                cmbItemCustomer.Items.Add("ID:"+dr[0].ToString()+"Name:"+ dr[1].ToString() +" "+dr[2].ToString());
                
            }
            //FINISHED LATER
            cmd.CommandText = queries.getAllAisles;
            cmd.CommandText = queries.getShelves;



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
                datetimeItemExpiration.Text = "";

                //by the way//if we don't add data to combo box this will crash when run since index 0 doesnt exsist
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
                 && txtItemQuantity.Text != "" && cmbItemCustomer.SelectedIndex != 0
                  && cmbUnitofMeasurement.SelectedIndex != 0 && cmbItemAisle.SelectedIndex != 0 && cmbItemShelf.SelectedIndex != 0
                   && cmbItemBin.SelectedIndex != 0)
            {
                //takes all text values and assigns them to parameters
                cmd.Parameters["@itemName"].Value = txtItemName.Text;
                cmd.Parameters["@weight"].Value = txtItemWeight.Text;
                cmd.Parameters["@height"].Value = txtItemHeight.Text;
                cmd.Parameters["@width"].Value = txtItemWidth.Text;
                cmd.Parameters["@length"].Value = txtItemLength.Text;
                cmd.Parameters["@quantity"].Value = txtItemQuantity.Text;
                cmd.Parameters["@itemDescription"].Value = txtItemDescription.Text;

                cmd.Parameters["@unitOfMeasurement"].Value = cmbUnitofMeasurement.Text;
                cmd.Parameters["@custID"].Value = cmbItemCustomer.Text;
                //============FK
                cmd.Parameters["@aisleID"].Value = cmbItemAisle.Text;
                cmd.Parameters["@binID"].Value = cmbItemBin.Text;
                cmd.Parameters["@selfID"].Value = cmbItemShelf.Text;

                //If radio 'expired' is true
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
//finsih this //Meaning they are going to add
            if (fType == "Add")
            {
                try
                {   
                    //in our case we are maintaing connection from the first time we connected
                    if (connection != null)
                    {
                        //calling query //we intialized in field already
                        query = queries.addInvetory;
                        cmd.CommandText = query;
                        cmd.Connection = connection;
                        //Insert/delete command
                        cmd.ExecuteNonQuery();
                       //closes form
                        Close();

                       // cmd.CommandText = queries.getUserInfo;
                       // dr = cmd.ExecuteReader();
                        
                       /* while (dr.Read())
                        {
                            txtLogin.Text = dr[0].ToString();
                            txtFName.Text = dr[1].ToString();
                            txtLName.Text = dr[2].ToString();
                            cmbGroup.SelectedItem = dr[3].ToString();
                        }
                        dr.Close();*/
                        
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
            else//its going to be edit
            {

            } 
        }

        private void rdoExpirationNo_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoExpirationNo.Checked)
            {
                //lblExpirationDate.Hide();
                //datetimeItemExpiration.Hide();

                lblExpirationDate.Enabled = false;
                datetimeItemExpiration.Enabled = false;
            }
            else
            {
               // lblExpirationDate.Show();
                //datetimeItemExpiration.Show();

                lblExpirationDate.Enabled = true;
                datetimeItemExpiration.Enabled = true;
            }
        }
    }
}
