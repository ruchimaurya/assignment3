using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace full_inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listofitems = new List<Product>();

            listofitems.Add(new Product("lettuce", 10.5, 50, "Leafy green"));
            listofitems.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            listofitems.Add(new Product("pumpkin", 30, 30, "Marrow "));
            listofitems.Add(new Product("cauliflower", 10, 25, "Cruciferous"));
            listofitems.Add(new Product("zucchini", 20.5, 50, "Marrow"));
            listofitems.Add(new Product("yam", 30, 50, "Root "));
            listofitems.Add(new Product("spinach", 10, 100, "Leafy green"));
            listofitems.Add(new Product("broccoli", 20.2, 75, "Cruciferous"));
            listofitems.Add(new Product("Garlic", 30, 20, "Leafy green"));
            listofitems.Add(new Product("silverbeet", 10, 50, "Marrow"));

            shortbytype(listofitems);
            checkinventory(listofitems);

            Console.WriteLine("Average price product {0}", listofitems.Average(item => item.price));
            var costlyitems= listofitems.Where(r => r.price > 50);
            var cheapitems = listofitems.Where(r => r.price <= 50);

            Console.WriteLine("---------List of costly products:------------");
            foreach (var a in costlyitems)
            {
                Console.WriteLine("{0}", a);
            }
            Console.WriteLine("---------List of cheap products:------------");
            foreach (var a in cheapitems)
            {
                Console.WriteLine("{0}",  a.name);
            }

            Console.Read();
        }

        private static void checkinventory(List<Product> listofitems)
        {
            Console.WriteLine("---------List of total price of products:------------");
            double totalPrice = 0;
            double totalQuantity = 0;
            foreach (var a in listofitems)
            {
                var productPrice = a.quantity * a.price;
                Console.WriteLine("Product name: {0} , Quantity: {1}, Unitprice: {2}, Price: {3}", a.name, a.quantity, a.price, productPrice);
                totalPrice += productPrice;
                totalQuantity += a.quantity;
            }

            Console.WriteLine("Total Quantity of product : {0} \n Total Price of all items : {1}", totalQuantity, totalPrice);

        }

        private static void shortbytype(List<Product> listofitems)
        {
            Console.WriteLine("---------List of Product group by type:------------");
            var sitesGroupedByType = listofitems.GroupBy(s => s.type).Select(g => new {
                Type = g.Key,
                Sites = g.Select(site => new
                {
                    site.name,
                    site.price,
                    site.quantity,
                    site.type
                })
            });

            foreach (var siteTypeGroup in sitesGroupedByType.OrderBy(g => g.Type))
            {
                foreach (var site in siteTypeGroup.Sites)
                {
                    Console.WriteLine(string.Format("Type : {0}, Title : {1} , Price : {2} , Quantity : {3}",
                                      siteTypeGroup.Type, site.name, site.price, site.quantity));
                }
            }


        }
    }
}
