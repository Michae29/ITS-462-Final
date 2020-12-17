using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace ITS_462_Final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //establish data table 
        public DataTable StackedInfo = new DataTable();

        //Stack of information is being passed along with what should be associated with each object inside the stack
        public Form2( int Incoming_Selector,Stack<ScrapeItem> IncomingStack)
        {

            InitializeComponent();
            
            

            //This means that incoming stack has objects that only have an item name
            if (Incoming_Selector==0)
            
            {
                // when scraped and incoming selector is 0, a column for Product Desc is created
                StackedInfo.Columns.Add("Product Desc");
                while(IncomingStack.Count!=0)
                {
                    ScrapeItem S1 = IncomingStack.Pop();
                    //adds all info to the datagrid row row
                    StackedInfo.Rows.Add(S1.ItemName.ToString());
                    //makes the options to save data viewable
                    SaveDB.Visible = false;
                    button1.Visible = false;
                    SaveDBDesc.Visible = true;
                }

            }
            //this incoming stack only has item specifications
            else if(Incoming_Selector == 1)
            {
                StackedInfo.Columns.Add("Product Spec");
                while (IncomingStack.Count != 0)
                {
                    ScrapeItem S1 = IncomingStack.Pop();
                    Console.WriteLine(S1.ItemSpec);

                    StackedInfo.Rows.Add(S1.ItemSpec.ToString());
                    SaveDB.Visible = false;
                    button1.Visible = true;
                    SaveDBDesc.Visible = false;

                }
            }
            //this incoming stack has both item name and item price
            else if(Incoming_Selector == 2)
            {
                StackedInfo.Columns.Add("Product Name");
                StackedInfo.Columns.Add("Product Price");
                while (IncomingStack.Count != 0)
                {
                    ScrapeItem S1 = IncomingStack.Pop();
                    Console.WriteLine(S1.ItemName+" " + S1.ItemPrice);
                    StackedInfo.Rows.Add(S1.ItemName.ToString(), S1.ItemPrice.ToString());
                    //StackedInfo.Rows.Add(S1.ItemPrice.ToString());
                    SaveDB.Visible = true;
                    button1.Visible = false;
                    SaveDBDesc.Visible = false;
                }
            }



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // ScrapeItem S1 = IncomingStack.Pop();
            ScrapedData.ClearSelection();

            ScrapedData.DataSource = StackedInfo;

        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            //button is used to navigate back and forth between the 2 forms
            this.Hide();
            Main Primary = new Main();
            Primary.Show();

        }

        private void SaveDB_Click(object sender, EventArgs e)
        {
            //var x = ScrapedData.Rows.ToString();
           
            try
            {
                //this will go through the DataGrid rows
                for (int i = 0; i < ScrapedData.Rows.Count; i++)
                {
                    var connection = new SqliteConnection(@"Data Source= C:\\Users\\Peter\\Downloads\\TestDatabase(1).db;");

                    //for each row in the datagrid, this will place the values in the databse
                    string statement = "INSERT INTO Test (ItemName, Price) VALUES(" + "'" + ScrapedData.Rows[i].Cells["Product Name"].Value + "'," + "'" + ScrapedData.Rows[i].Cells["Product Price"].Value + "'" + ")";
                    connection.Open();
                    var cmd = new SqliteCommand(statement, connection);
                    SqliteDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ScrapedData.Rows.Add("NULL", "NULL", dr.GetString(0));
                        }
                    }
                    
                    connection.Close();

                }
                //if the SQL successfully saves to the database, this message box will display
                MessageBox.Show("Item Name and Price Saved");

            }
            catch
            {
                //if the SQL syntax fails
                MessageBox.Show("Unsuccessful");
            }
            //goes back to the main form
            this.Hide();
            Main Primary = new Main();
            Primary.Show();
            
        }

        private void CDbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductData f3 = new ProductData();
            f3.ShowDialog();
        }
        //this will put data when the user wants to place item specification
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < ScrapedData.Rows.Count; i++)
                {
                    var connection = new SqliteConnection(@"Data Source= C:\\Users\\Peter\\Downloads\\TestDatabase(1).db;");

                    string statement = "INSERT INTO Test (ItemName, Price) VALUES(" + "'" + ScrapedData.Rows[i].Cells["Product Spec"].Value + "'," + "' '" + ")";
                    connection.Open();
                    var cmd = new SqliteCommand(statement, connection);
                    SqliteDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ScrapedData.Rows.Add("NULL", "NULL", dr.GetString(0));
                        }
                    }
                    
                    connection.Close();

                }
                MessageBox.Show("Product Specification Successful");

            }
            catch
            {
                MessageBox.Show("Unsuccesful");
            }
            this.Hide();
            Main Primary = new Main();
            Primary.Show();
        }

        private void SaveDBDesc_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < ScrapedData.Rows.Count; i++)
                {
                    var connection = new SqliteConnection(@"Data Source= C:\\Users\\Peter\\Downloads\\TestDatabase(1).db;");

                    string statement = "INSERT INTO Test (ItemName, Price) VALUES(" + "'" + ScrapedData.Rows[i].Cells["Product Desc"].Value + "'," + "' '" + ")";
                    connection.Open();
                    var cmd = new SqliteCommand(statement, connection);
                    SqliteDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ScrapedData.Rows.Add("NULL", "NULL", dr.GetString(0));
                        }
                    }
                    connection.Close();

                }
                MessageBox.Show("Product Description Saved");

            }
            catch
            {
                MessageBox.Show("Unsuccesful");
            }
            this.Hide();
            Main Primary = new Main();
            Primary.Show();
        }
    }
}
