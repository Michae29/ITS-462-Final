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

namespace ITS_462_Final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Stack of information is being passed along with what should be associated with each object inside the stack
        public Form2( int Incoming_Selector,Stack<ScrapeItem> IncomingStack)
        {

            InitializeComponent();

            //This means that incoming stack has objects that only have an item name
            if(Incoming_Selector==0)
            {
                while(IncomingStack.Count!=0)
                {
                    ScrapeItem S1 = IncomingStack.Pop();
                    Console.WriteLine(S1.ItemName);
                }
            }
            //this incoming stack only has item specifications
            else if(Incoming_Selector == 1)
            {
                while (IncomingStack.Count != 0)
                {
                    ScrapeItem S1 = IncomingStack.Pop();
                    Console.WriteLine(S1.ItemSpec);
                }
            }
            //this incoming stack has both item name and item price
            else if(Incoming_Selector == 2)
            {
                while (IncomingStack.Count != 0)
                {
                    ScrapeItem S1 = IncomingStack.Pop();
                    Console.WriteLine(S1.ItemName+" " + S1.ItemPrice);
                }
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            //button is used to navigate back and forth between the 2 forms
            this.Hide();
            Main Primary = new Main();
            Primary.Show();

        }
    }
}
