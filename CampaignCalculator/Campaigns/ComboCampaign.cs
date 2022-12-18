using CampaignCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignCalculator.Campaigns
{
    public class ComboCampaign : ICampaign
    {
        private readonly ComboCampaignProducts _comboCampaignProducts;

        public ComboCampaign(ComboCampaignProducts comboCampaignProducts)
        {
            _comboCampaignProducts = comboCampaignProducts;
        }

        public bool IsProductInCampaign(string productId)
        {
            return _comboCampaignProducts.ComboCampaignProductIds.Contains(productId);
        }
        public decimal GetTotalPrice(List<ProductQuantity> customerItems, List<Product> productsInStore)
        {
   
            List<ProductQuantity> productsNotInCampaign = new List<ProductQuantity>();
            List<ProductQuantity> productsInCampaign = new List<ProductQuantity>();
            foreach (var item in customerItems)
            {
                if (IsProductInCampaign(item.ProductID))
                    productsInCampaign.Add(item);
                else
                    productsNotInCampaign.Add(item);
            }

  
            decimal totalPriceForProductsInCampaign = CalculatePriceForProductsInCampaign(productsInStore, productsInCampaign);

            decimal totalPriceForProductNotInCampaign = CalculatePriceForProductsNotInCampaign(productsInStore, productsNotInCampaign);
            return totalPriceForProductsInCampaign + totalPriceForProductNotInCampaign;
        }

        private decimal CalculatePriceForProductsInCampaign(List<Product> productsInStore, List<ProductQuantity> productsInCampaign)
        {
            decimal totalPriceForProductsInCampaign = 0;
            if (productsInCampaign.Count % 2 == 0)
            {
                totalPriceForProductsInCampaign = (productsInCampaign.Count / 2) * _comboCampaignProducts.CampaignPrice;
            }
            else
            {
                totalPriceForProductsInCampaign = (productsInCampaign.Count / 2) * _comboCampaignProducts.CampaignPrice + productsInStore.Find(_ => _.Id == productsInCampaign.Last().ProductID).UnitPrice;

            }
            return totalPriceForProductsInCampaign;
        }

        private static decimal CalculatePriceForProductsNotInCampaign(List<Product> productsInStore, List<ProductQuantity> productsNotInCampaign)
        {
            decimal priceForProductsNotInCampaign = 0;
            foreach (var product in productsNotInCampaign)
            {
                priceForProductsNotInCampaign += productsInStore.Find(_ => _.Id == product.ProductID).UnitPrice * product.Quantity;
            }
            return priceForProductsNotInCampaign;
        }
    }

}
