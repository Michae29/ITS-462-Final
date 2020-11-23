using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using HtmlAgilityPack;

namespace ITS_462_Final
{
    public partial class Main : Form
    {
        
        
        public Main()
        {
            InitializeComponent();

        }

        private void Main_Load(object sender, EventArgs e)
        {

            Item_Deter.SelectedIndex = 0;
            Price_Deter.SelectedIndex = 2;
            Scrape_Box.SelectedIndex = 1;
            Manufacturer_Deter.SelectedIndex = 4;
        }

        private void Scrape_Deter_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Scrape_Box.SelectedIndex == 2)
            {
                Price_Deter.Visible=true;
                label2.Visible = true;
            }
            else
            {
                Price_Deter.Visible = false;
                label2.Visible = false;
            }

        }

        private void Scrape_Button_Click(object sender, EventArgs e)
        {
            string url = "https://webscraper.io/test-sites/e-commerce/allinone";


            if (Item_Deter.SelectedItem.ToString() == "Computer")
            {
                url = "https://webscraper.io/test-sites/e-commerce/allinone/computers/laptops";
            }
            else if (Item_Deter.SelectedItem.ToString() == "Tablet")
            {
                url = "https://webscraper.io/test-sites/e-commerce/allinone/computers/tablets";
            }
            else
            {
                url = "https://webscraper.io/test-sites/e-commerce/allinone/phones/touch";
            }

           
            var web = new HtmlWeb();
            var doc = web.Load(url);

            string itemType = Item_Deter.SelectedItem.ToString();
            string Manu = Manufacturer_Deter.SelectedItem.ToString();
            string price = Price_Deter.SelectedItem.ToString();
            string selector = Scrape_Box.SelectedItem.ToString();

  

            HtmlNode[] Nodes = doc.DocumentNode.SelectNodes(" //div [@class='caption']/h4/a[text()[contains(.,'" + Manu + "')]] | //div [@class='caption']/h4/a[text()[contains(.,'" + Manu + "')]]/../../h4 [@class='pull-right price'] ").ToArray();


            foreach (HtmlNode Current in Nodes)
            {
                Console.WriteLine(Current.InnerText);

            }
            
            
        }

        private void Item_Deter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Item_Deter.SelectedItem.ToString()=="Computer")
            {
                Manufacturer_Deter.Items.Clear();
                Manufacturer_Deter.Items.Add("Asus");
                Manufacturer_Deter.Items.Add("Acer");
                Manufacturer_Deter.Items.Add("Apple");
                Manufacturer_Deter.Items.Add("Dell");
                Manufacturer_Deter.Items.Add("Lenovo");
                Manufacturer_Deter.Items.Add("HP");
                Manufacturer_Deter.Items.Add("Toshiba");
                Manufacturer_Deter.Items.Add("ThinkPad");
            }
            else if(Item_Deter.SelectedItem.ToString() == "Tablet")
            {
                Manufacturer_Deter.Items.Clear();
                Manufacturer_Deter.Items.Add("Acer");
                Manufacturer_Deter.Items.Add("Amazon");
                Manufacturer_Deter.Items.Add("Apple");
                Manufacturer_Deter.Items.Add("Galaxy");
                Manufacturer_Deter.Items.Add("IdeaTab");
                Manufacturer_Deter.Items.Add("Lenovo");
                Manufacturer_Deter.Items.Add("Memo");
            }
            else
            {
                Manufacturer_Deter.Items.Clear();
                Manufacturer_Deter.Items.Add("Iphone");
                Manufacturer_Deter.Items.Add("Nokia");
                Manufacturer_Deter.Items.Add("LG");
                Manufacturer_Deter.Items.Add("Sony");
            }
        }

    }
}
