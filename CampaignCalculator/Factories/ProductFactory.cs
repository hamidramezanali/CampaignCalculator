using CampaignCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignCalculator
{
    public class ProductFactory
    {
        public List<Product> products { get; set; }
        public static List<Product> FillStoreProducts()
        {
            var products = new List<Product>();
            products.AddRange(new List<Product>() {
                new Product("5000112637922", 50),
                 new Product("5000112637939", 50),
                  new Product("7310865004703", 50),
                   new Product("7340005404261", 50),
                    new Product("7310532109090", 50),
                     new Product("7611612222105", 50),
                      new Product("8711000530085", 50),
                      new Product("7310865004703", 50),
                      new Product("123", 32),
                      new Product("345", 42)

            }

                );
            return products;
        }

    }
}
