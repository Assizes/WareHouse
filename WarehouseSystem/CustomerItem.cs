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
    

    public partial class CustomerItem : Form
    {
       

        //NOTE we never really close Connection since login so we using that
        string query;
        DBqueries queries = new DBqueries();
        MySqlConnection connection;
        MySqlCommand cmd = new MySqlCommand();
        private WarehouseSystem warehouse = (WarehouseSystem)Application.OpenForms["WarehouseSystem"];
        MySqlDataReader dr;

        public string ourData;
        String whatID;

        AddEditInventory firstformRef;





        public CustomerItem(ref AddEditInventory form1handel)
        {
            InitializeComponent();
            firstformRef = form1handel;
        }

        private void CustomerItem_Load(object sender, EventArgs e)
        {
           // cmd.Parameters.Add("@custID", MySqlDbType.String);
            

            int x = 0;


            connection = warehouse.Connection;

            query = queries.getItemID;
            cmd.CommandText = query;
           // MessageBox.Show(ourData);

           // dr = cmd.ExecuteReader();

           /* while(dr.Read())
            { 
                c.Items.Add(dr[0].ToString());
                x++;
            }*/

            passMqSqlArgue(query, dataGridView1, "s2016_user1.item");

            //Insert/delete command


           // Close();
        }

        public void passMqSqlArgue(string query, DataGridView dgv, String tableName)
        {
            DataSet dataset = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);//Query statement + connection
            adapter.SelectCommand.Parameters.AddWithValue("@custID", ourData);
            adapter.Fill(dataset, tableName); //meaning what TABLE name im getting it from FROM EMPLOYESS
            dgv.DataSource = dataset.Tables[tableName]; //I actually forgot to add this part....
            //Put in method so I don't have to spam this in every line
            //adapter.Dispose();
        }

        private void btnCustomerItemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //If double clicked
            whatID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //MessageBox.Show(whatID.ToString());
            // AddEditInventory adds = new AddEditInventory();
            // adds.itemIdData = whatID;

            firstformRef.itemIdData = whatID;

            MessageBox.Show("Item Selected ID: "+whatID);
            
            
        

            this.Close();
        }


    }
}
