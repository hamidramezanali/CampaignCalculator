using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignCalculator
{
    public class ComboCampaignProducts
    {
        public List<string> ComboCampaignProductIds { get; set; }

        public decimal CampaignPrice { get; set; }
        public ComboCampaignProducts()
        {
            ComboCampaignProductIds=new List<string>();
        }
    }
}
