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
using System.Globalization;
using System.Net;
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
            //here for quickening the debugging process
            Item_Deter.SelectedIndex = 0;
            Price_Deter.SelectedIndex = 2;
            Scrape_Box.SelectedIndex = 2;
            Manufacturer_Deter.SelectedIndex = 4;
        }

        private void Scrape_Deter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sets the visibilty of price component only if price option is selected

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
            string url;

            //setes the scraping URL depending on what was selected
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

           //Sets the required variables for scraping information
            var web = new HtmlWeb();
            var doc = web.Load(url);

            //Pulls the selected information necessary to scrape the proper info
            string itemType = Item_Deter.SelectedItem.ToString();
            string Manu = Manufacturer_Deter.SelectedItem.ToString();
            string price = Price_Deter.SelectedItem.ToString();
            string selector = Scrape_Box.SelectedItem.ToString();

            //Stack item that uses the scrape item to send back and forth info that has been scrapped
            Stack<ScrapeItem> ItemStack = new Stack<ScrapeItem>();

            //This scrapes the product title/description from the webpage
            if (Scrape_Box.SelectedIndex==0)
            {
                HtmlNode[] Nodes = doc.DocumentNode.SelectNodes(" //div [@class='caption']/h4/a [text()[contains(.,'" + Manu + "')]] ").ToArray();

                foreach (HtmlNode Current in Nodes)
                {
                    ScrapeItem NewItem = new ScrapeItem
                    {
                        ItemName = Current.InnerText
                    };

                    ItemStack.Push(NewItem);

                }
                //regardless of any option chosen it will hid the current form, pass the selected scrape index, and the item stack
                this.Hide();
                Form2 Scraped_Form = new Form2(0,ItemStack);
                Scraped_Form.Show();

            }

            //this scrapes the title and the specs from the webpage
            //Retrieving title string  //div [@class='caption']/h4/a[text()[contains(.,'" + Manu + "')]] |
            if (Scrape_Box.SelectedIndex == 1)
            {
                HtmlNode[] Nodes = doc.DocumentNode.SelectNodes("//div [@class='caption']/h4/a[text()[contains(.,'" + Manu + "')]]/../../p [@class='description']").ToArray();
                foreach (HtmlNode Current in Nodes)
                {
                    ScrapeItem NewItem = new ScrapeItem();

                    NewItem.ItemSpec = Current.InnerText;

                    //This decodes the hyperlink that is returned from the Xpath query
                    NewItem.ItemSpec= WebUtility.HtmlDecode(NewItem.ItemSpec);

                    ItemStack.Push(NewItem);

                }
                //regardless of any option chosen it will hid the current form, pass the selected scrape index, and the item stack
                this.Hide();
                Form2 Scraped_Form = new Form2(1,ItemStack);
                Scraped_Form.Show();

            }


            //scrapes the title, and price from the webpage, required some intensive workaround
            if (Scrape_Box.SelectedIndex == 2)
            {
              
                HtmlNode[] Nodes = doc.DocumentNode.SelectNodes(" //div [@class='caption']/h4/a[text()[contains(.,'" + Manu + "')]] | //div [@class='caption']/h4/a[text()[contains(.,'" + Manu + "')]]/../../h4 [@class='pull-right price'] ").ToArray();
                bool CorrectName = false;
                //this additional scrapeItem is needed to take the price and the name into object to be added to the stack.
                ScrapeItem FullItem = new ScrapeItem(); ;

                foreach (HtmlNode Current in Nodes)
                {
                    //this checks that the incoming string can be parsed as a decimal if it removes any currency symbols like $, in this case all incoming price strings have one
                    if (Decimal.TryParse(Current.InnerText, NumberStyles.AllowCurrencySymbol | NumberStyles.Number , NumberFormatInfo.CurrentInfo ,  out _) == true)
                    {
                        ScrapeItem NewItem = new ScrapeItem();
                        //if it can be parsed as a decimal i then is and sent to testprice
                        Decimal TestPrice= Decimal.Parse(Current.InnerText, NumberStyles.AllowCurrencySymbol | NumberStyles.Number);
                        //test price takes what price index was selected, then using that to determing the range the price has to be inbetween, if true it gets added to the object 
                        if (NewItem.TestPrice(Price_Deter.SelectedIndex, TestPrice)==true)
                        {
                            NewItem.ItemPrice = TestPrice;
                            //correct name is needed, otherwise names and pricing would not be accurate
                            CorrectName = true;
                            FullItem = NewItem;
                            continue;
                        }

                    }
                    //this used to associate the correct item name with its relative item price
                    if (CorrectName == true)
                    {
                        FullItem.ItemName = Current.InnerText;
                        CorrectName = false;

                        ItemStack.Push(FullItem);

                    }

                }
                //regardless of any option chosen it will hid the current form, pass the selected scrape index, and the item stack
                this.Hide();
                Form2 Scraped_Form = new Form2(2,ItemStack);
                Scraped_Form.Show();

            }

            

        }

        private void Item_Deter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this section clears out the selectable items from the combo box to only show the relevant ones, clears any section if another is selected
            Manufacturer_Deter.Text = "";

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductData Primary = new ProductData();
            Primary.Show();
        }
    }
}
