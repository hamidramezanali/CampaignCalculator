namespace CampaignCalculator.Models
{
    public class VolumeCampaignProduct
    {
        public string ProductId { get; set; }
        public decimal Price { get; set; }
        public decimal MinimumPurchaseQuantity { get; set; }
        public VolumeCampaignProduct(string eAN, decimal price, decimal minimumPurchaseQuantity)
        {
            ProductId = eAN;
            Price = price;
            MinimumPurchaseQuantity = minimumPurchaseQuantity;
        }
    }
}
