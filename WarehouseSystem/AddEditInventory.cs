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
        List<String> customerIDList = new List<String>();
        List<String> unitIDList = new List<String>();
        private int _id;

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
                customerIDList.Add(dr[0].ToString());
                
            }

            dr.Close();

            //FINISHED LATER//EDIT QUERIES LATER//they should only show ones that are not occupied
            cmd.CommandText = queries.getAllAisles;
            doQueries(cmbItemAisle);

            cmd.CommandText = queries.getMeasurements;
            doQueries(cmbUnitofMeasurement);
            

            cmd.CommandText = queries.getAllShelves;
            doQueries(cmbItemShelf);

            cmd.CommandText = queries.getAllBins;
            doQueries(cmbItemBin);


            //FOR TESTING
            /*txtItemName.Text = "a";
            txtItemDescription.Text = "a";
            txtItemLength.Text = "1";
            txtItemWidth.Text = "1";
            txtItemHeight.Text = "1";
            txtItemWeight.Text = "1";
            txtItemQuantity.Text = "1";
            cmbItemCustomer.SelectedIndex = 0;
            cmbUnitofMeasurement.SelectedIndex = 0;
            cmbItemAisle.SelectedIndex = 0;
            cmbItemShelf.SelectedIndex = 0;
            cmbItemBin.SelectedIndex = 0;*/

        }

        public void setID(int id)
        {
            _id = id;
            if (_id != -1)
            {
                cmd.Parameters["@customerID"].Value = _id;
                try
                {
                    if (connection != null)
                    {
                        cmd.CommandText = queries.getCustomerInfo;
                        cmd.Connection = connection;
                        MySqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            //txtItemName.Text = dr[0].ToString();
                            txtItemName.Text = dr[1].ToString();
                            txtItemWeight.Text = dr[2].ToString();
                            txtItemHeight.Text = dr[3].ToString();
                            txtItemWidth.Text = dr[4].ToString();
                            txtItemLength.Text = dr[5].ToString();
                            txtItemQuantity.Text = dr[6].ToString();
                            txtItemDescription.Text = dr[7].ToString();

                        }
                        dr.Close();

                    }
                    else
                    {
                        MessageBox.Show("Connection Lost");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }


        


        public void doQueries(ComboBox c)
        {
            //String q = query  +"."+ querieName;
            //cmd.CommandText = q;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                c.Items.Add(dr[0].ToString());
            }

            if (c == cmbUnitofMeasurement)
            {
                unitIDList.Add(dr[1].ToString());
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
                datetimeItemExpiration.Text = "";

                //by the way//if we don't add data to combo box this will crash when run since index 0 doesnt exsist

                //if (cmbItemCustomer.Items.Count > 0)

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
            if 
                (txtItemName.Text != "" && txtItemDescription.Text != "" && txtItemLength.Text != "" &&
                txtItemWidth.Text != "" && txtItemHeight.Text != "" && txtItemWeight.Text != ""
                 && txtItemQuantity.Text != "" && cmbItemCustomer.SelectedIndex != -1
                  && cmbUnitofMeasurement.SelectedIndex != -1 && cmbItemAisle.SelectedIndex != -1 && cmbItemShelf.SelectedIndex != -1
                   && cmbItemBin.SelectedIndex != -1)
            {
                //takes all text values and assigns them to parameters
                cmd.Parameters["@itemName"].Value = txtItemName.Text;
                cmd.Parameters["@weight"].Value = txtItemWeight.Text;
                cmd.Parameters["@height"].Value = txtItemHeight.Text;
                cmd.Parameters["@width"].Value = txtItemWidth.Text;
                cmd.Parameters["@length"].Value = txtItemLength.Text;
                cmd.Parameters["@quantity"].Value = txtItemQuantity.Text;
                cmd.Parameters["@itemDescription"].Value = txtItemDescription.Text;

                int idPlace = cmbUnitofMeasurement.SelectedIndex;
                cmd.Parameters["@unitOfMeasurement"].Value = customerIDList[idPlace];
               // MessageBox.Show(idPlace.ToString());
                int place = cmbItemCustomer.SelectedIndex;
                cmd.Parameters["@custID"].Value = customerIDList[place];
               // MessageBox.Show(place.ToString());
                //============FK
                cmd.Parameters["@aisleID"].Value= cmbItemAisle.Text;
                cmd.Parameters["@binID"].Value = cmbItemBin.Text;
                cmd.Parameters["@selfID"].Value = cmbItemShelf.Text;

                //If radio 'expired' is true
                if (rdoExpirationYes.Checked == true)
                {
                    // datetimeItemExpiration.Format = DateTimePickerFormat.Custom;
                    //datetimeItemExpiration.CustomFormat = "yyyy MM dd";
                    String thisDate = Convert.ToDateTime(datetimeItemExpiration.Text).ToString("yyyy-MM-dd");
                    cmd.Parameters["@expirationDate"].Value = thisDate;

                    

                    MessageBox.Show(thisDate);
                }
                else
                {
                    cmd.Parameters["@expirationDate"].Value = 0000-00-00;
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
                        
                        //MessageBox.Show("@binID");
                        
                        //calling query //we intialized in field already
                        query = queries.addInv;
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
