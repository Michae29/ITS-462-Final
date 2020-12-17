using System;
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
    public partial class ProductData : Form
    {
        public ProductData()
        {
            InitializeComponent();
        }
        
        //This will load the database on load.
        private void ProductData_Load(object sender, EventArgs e)
        {
            //establish connection 
            SqliteConnection conn = new SqliteConnection();
            string connString = "Data Source=" + "C:\\Users\\Peter\\Downloads\\TestDatabase(1).db;";

            conn.ConnectionString = connString;

            SqliteCommand cmd = new SqliteCommand();
            //command that will give us a view of the database to textbox
            cmd.CommandText = "SELECT * FROM TEST";
            cmd.Connection = conn;

            conn.Open();
            SqliteDataReader dr = cmd.ExecuteReader();
            textBox1.Clear();
            //listView1.Clear();
            
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    //listView1.Items.Add(dr.GetString(0) + dr.GetString(1)+ "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n");
                    textBox1.Text += dr.GetString(0) + ": " + dr.GetString(1) + "\r\n";
                    //dataGridView1.Rows.Add(dr.GetString(1));
                }
            }
           
            else
            {
                textBox1.Text = "no data found";
            }
            dr.Close();
            conn.Close();
            
            
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

            //based on what is chosen in the radio button, it will conduct a search based on either item name or price
            if (RadioName.Checked)
            {
                SqliteConnection conn = new SqliteConnection();
                string connString = "Data Source=" + "C:\\Users\\Peter\\Downloads\\TestDatabase(1).db;";

                conn.ConnectionString = connString;

                SqliteCommand cmd = new SqliteCommand();
                //will check anything that starts with whatever is in the seacrh box
                cmd.CommandText = "SELECT * FROM TEST WHERE (`ItemName`) LIKE '" + SearchBox.Text + "%'";
                cmd.Connection = conn;

                conn.Open();
                SqliteDataReader dr = cmd.ExecuteReader();
                textBox1.Clear();
                //listView1.Clear();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        textBox1.Text += dr.GetString(0) + ": " + dr.GetString(1) + "\r\n";
                        //dataGridView1.Rows.Add(dr.GetString(1));
                    }
                }

                else
                {
                    textBox1.Text = "no data found";
                }
                dr.Close();
                conn.Close();
            }

            else if (RadioPrice.Checked)
            {
                SqliteConnection conn = new SqliteConnection();
                string connString = "Data Source=" + "C:\\Users\\Peter\\Downloads\\TestDatabase(1).db;";

                conn.ConnectionString = connString;

                SqliteCommand cmd = new SqliteCommand();
                //this will conduct a search where we look for the price on the number given or any lower values
                cmd.CommandText = "SELECT * FROM TEST WHERE (`Price`) <= '" + SearchBox.Text + "'";
                cmd.Connection = conn;

                conn.Open();
                SqliteDataReader dr = cmd.ExecuteReader();
                textBox1.Clear();
                //listView1.Clear();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        textBox1.Text += dr.GetString(0) + ": " + dr.GetString(1) + "\r\n";
                        //dataGridView1.Rows.Add(dr.GetString(1));
                    }
                }

                else
                {
                    textBox1.Text = "no data found";
                }
                dr.Close();
                conn.Close();
            }

            


           
        }
        //returns the user to the main screen
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main Primary = new Main();
            Primary.Show();
        }
    }
}
