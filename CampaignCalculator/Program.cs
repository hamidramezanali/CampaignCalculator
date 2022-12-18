
using CampaignCalculator.Campaigns;
using CampaignCalculator.Models;

namespace CampaignCalculator
{
    class myProgram
    {
        public static void Main()
        {
            //DATA
            ICampaign comboCampains = new ComboCampaign(CampaignFactory.FillCombineCampaign());
            ICampaign volumeCampaign = new VolumeCampaign(CampaignFactory.FillVolumeCampaign());

            List<Product> productsInStore=ProductFactory.FillStoreProducts();      
            List<ProductQuantity>  customerBasket = CustomerBasketFactory.FillCustomerBasket4();
           //******************************


            decimal totalFromComboCampain= comboCampains.GetTotalPrice(customerBasket,productsInStore);
            decimal totalVolumeCampain = volumeCampaign.GetTotalPrice(customerBasket, productsInStore);

            //Only one campaign will be selected with lowest price, mixed campaign was not specified in the problem description
            Console.WriteLine("Total value to pay is " + ((totalFromComboCampain > totalVolumeCampain) ? totalVolumeCampain : totalFromComboCampain));
        }




    }
}
