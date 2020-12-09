using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS_462_Final
{
    public class ScrapeItem
    {
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public Decimal ItemPrice { get; set; }
        public string ItemSpec { get; set; }


        public bool TestPrice(int PriceSelector, Decimal TestPrice)
        {
            if(PriceSelector==0 && TestPrice <= 400 && TestPrice >=100)
            {
                return true;
            }
            else if (PriceSelector == 1 && TestPrice <= 700 && TestPrice >= 400)
            {
                return true;
            }
            else if (PriceSelector == 2 && TestPrice <= 1000 && TestPrice >= 700)
            {
                return true;
            }

            else if (PriceSelector == 3 && TestPrice <=1300 && TestPrice>=1000)
            {
                return true;
            }
            else if (PriceSelector == 4 && TestPrice >= 1300)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
