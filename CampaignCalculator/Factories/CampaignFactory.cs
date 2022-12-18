using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampaignCalculator.Campaigns;
using CampaignCalculator.Models;

namespace CampaignCalculator
{
    public static class CampaignFactory
    {
 

        internal static ComboCampaignProducts FillCombineCampaign()
        {
            ComboCampaignProducts comboCampaignProducts = new ComboCampaignProducts();
            List<string> ids = new List<string>(){ "5000112637922",
"5000112637939",
"7310865004703",
"7340005404261",
"7310532109090",
"7611612222105" };
            foreach (var id in ids)
            {
                comboCampaignProducts.ComboCampaignProductIds.Add(id);
            }
            comboCampaignProducts.CampaignPrice = 30;
            return comboCampaignProducts;
        }

        internal static List<VolumeCampaignProduct> FillVolumeCampaign()
        {
            List<VolumeCampaignProduct> volumeCampaignProducts= new List<VolumeCampaignProduct>();

            volumeCampaignProducts.Add(new VolumeCampaignProduct("8711000530085", 85, 2));
            volumeCampaignProducts.Add(new VolumeCampaignProduct("7310865004703", 20, 3));
            return volumeCampaignProducts;
        }
    }
}
