using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell_Analitick.DB.Model
{
    /// <summary>
    /// продукция на  складе
    /// </summary>
    public class ProductStorege
    {
        public  int  ProductStoregeId { get; set; }

        /// <summary>
        /// кол-во товара
        /// </summary>
        public  int Count { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int StoregeId { get; set; }
        public Storege Storege { get; set; }

        /// <summary>
        /// истина - поступление / ложь - списание
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// Дата поступления / списания
        /// </summary>
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"ID{ProductStoregeId}. {Date}, {Product.Name} кол-во: {Count}, Склад №{Storege.NumberStorege }, , {Status}";
        }

    }
}
