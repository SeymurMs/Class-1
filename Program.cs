using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product()
            {
                name = "tide",
                BrandName = "tide1",
                price = 1.2,
            };
            Product product2 = new Product()
            {
                name = "snickers",
                BrandName = "snickers1",
                price = 2.32,
            };
            Product product3 = new Product()
            {
                name = "oreo",
                BrandName = "oreo1",
                price = 0.75,
            };
            Product product4 = new Product()
            {
                name = "axe",
                BrandName = "axe1",
                price = 1.6,
            }; 
            Product[] allProduct = { product1, product2, product3, product4 };
            
            foreach (Product p in allProduct)
            {
                Console.WriteLine($"{p.name}  {p.BrandName} {p.price}");
            }

            Product[] Search = getFilter(0.6, 2.5,allProduct);
            foreach (Product item in Search)
            {
                Console.WriteLine(item.GetInfo());
            }



            static Product[] getFilter(double minPrice, double maxPrice, Product [] price)
            {
                int count = 0;
                foreach (Product p in price)
                {
                    if (minPrice < p.price && maxPrice > p.price)
                    {
                        count++;
                    }
                    
                }
                Product [] filter = new Product[count];
                int i = 0;
                foreach (Product item in price)
                {
                    if (minPrice < item.price && maxPrice > item.price)
                    {
                        filter[i] = item;
                    }
                }
                return filter;
            }


        }

    }
}
