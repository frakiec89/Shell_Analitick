using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell_Analitick.DB.Model
{
    /// <summary>
    /// продажа  товаров
    /// </summary>
    public class Sell
    {
        public  int  SellId { get; set; }

        public int Count { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int StoregeId { get; set; }
        public Storege Storege { get; set; }

        public int SellerId { get; set; }
        public  Seller Seller { get; set; }
        public  DateTime DateSell { get; set; }



        public override string ToString()
        {
            return $"ID {SellerId}. {DateSell}, {Product.Name}, кол-во {Count}, продавец {Seller.Name} {Storege}";
        }

    }
}
