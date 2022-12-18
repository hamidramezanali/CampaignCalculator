using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignCalculator
{
    public class ProductQuantity
    {
 
        public ProductQuantity(string product, int quantity)
        {
            ProductID = product;
            this.Quantity = quantity;
        }

        public string ProductID { get; set; }

        public int Quantity { get; set; }
    }
}
