using CampaignCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignCalculator
{
    public interface ICampaign
    {
        decimal GetTotalPrice(List<ProductQuantity> customerItems, List<Product> productsInStore);
    }
}
