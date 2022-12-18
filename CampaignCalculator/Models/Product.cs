using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignCalculator.Models
{
    public class Product
    {
        public string Id { get; set; }
        public decimal UnitPrice { get; set; }
        public Product(string id, decimal unitPrice)
        {
            Id = id;
            UnitPrice = unitPrice;
        }
    }
}
