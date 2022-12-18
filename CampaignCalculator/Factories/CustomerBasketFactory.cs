using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignCalculator
{
    public static class CustomerBasketFactory
    {
        public static List<ProductQuantity> FillCustomerBasket1()
        {
            return new List<ProductQuantity>(){
              new ProductQuantity( "5000112637922",1),
               new ProductQuantity(  "7340005404261",1)
};
        }
        public static List<ProductQuantity> FillCustomerBasket2()
        {
            return new List<ProductQuantity>(){
              new ProductQuantity( "7340005404261",1),
               new ProductQuantity(  "7310532109090",1),
                  new ProductQuantity( "5000112637922",1),
               new ProductQuantity(  "7310865004703",3)
};
        }
        public static List<ProductQuantity> FillCustomerBasket3()
        {
            return new List<ProductQuantity>(){
              new ProductQuantity( "7340005404261",1),
               new ProductQuantity(  "7310532109090",1),
                  new ProductQuantity( "5000112637922",1),
                       new ProductQuantity( "123",1),
               new ProductQuantity(  "7310865004703",1)
};
        }
        public static List<ProductQuantity> FillCustomerBasket4()
        {
            return new List<ProductQuantity>(){
              new ProductQuantity( "8711000530085",3),
               new ProductQuantity(  "123",1)
};
        }

    }
}
