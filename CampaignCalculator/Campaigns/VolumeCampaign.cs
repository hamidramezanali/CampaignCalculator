using CampaignCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignCalculator
{
    public class VolumeCampaign : ICampaign
    {
        private List<VolumeCampaignProduct> _volumeCampainProducts { get; set; }

        public VolumeCampaign(List<VolumeCampaignProduct> volumeCampaignProducts)
        {
            _volumeCampainProducts = volumeCampaignProducts;
        }

        private bool IsProductInCampaign(string productId)
        {
            return _volumeCampainProducts.Any(_=>_.ProductId== productId);
        }

        public decimal GetTotalPrice(List<ProductQuantity> customerItems, List<Product> productsInStore)
        {
            decimal total = 0;
            foreach (var item in customerItems)
            {
                if (IsProductInCampaign(item.ProductID))
                    total += GetPricePerProduct(item.ProductID, item.Quantity, productsInStore.Find(_ => _.Id == item.ProductID).UnitPrice);
                else
                    total += item.Quantity * productsInStore.Find(_ => _.Id == item.ProductID).UnitPrice;
            }
            return total;
        }
        public decimal GetPricePerProduct(string productId,int quantity, decimal unitPrice)
        {
            VolumeCampaignProduct productInCampaign= _volumeCampainProducts.Find(_ => _.ProductId == productId);
            int inCampaign =(int) (quantity / productInCampaign.MinimumPurchaseQuantity);
            decimal inCampainPrice = inCampaign * productInCampaign.Price;
            int notInCampaign = (int)(quantity % productInCampaign.MinimumPurchaseQuantity);
            decimal notInCampainPrice = notInCampaign * unitPrice;
            return inCampainPrice + notInCampainPrice;
        }

    }
}
