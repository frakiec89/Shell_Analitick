using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Shell_Analitick
{
    class Program
    {
        static void Main(string[] args)
        {
            DB.MySqlLiteContext liteContext = new DB.MySqlLiteContext();

            var producttype = liteContext.ProductTypes.ToList();
            var product = liteContext.Products.Include(x => x.ProductType).ToList();
            var sklad = liteContext.Storeges.ToList();
            var seller = liteContext.Sellers.ToList();
            var productSklad = liteContext.ProductStoreges.Include(x => x.Product).Include(x => x.Storege).ToList();
            var sell = liteContext.Sells.Include(x => x.Seller).Include(x => x.Storege).Include(x => x.Product).ToList();



            Console.WriteLine("Виды продукции");
            producttype.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            Console.WriteLine("Товары");
            product.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            Console.WriteLine("склады");
            sklad.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            Console.WriteLine("Продавцы");
            seller.ForEach(x => Console.WriteLine(x)); 
            Console.WriteLine();

            Console.WriteLine("поступления");
            productSklad.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();


            Console.WriteLine("продажи");
            sell.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();





            Console.ReadLine();

        }
    }
}
