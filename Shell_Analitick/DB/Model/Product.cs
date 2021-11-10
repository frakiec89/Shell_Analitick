using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell_Analitick.DB.Model
{

    /// <summary>
    /// Продукция на  продажу
    /// </summary>
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }


        public override string ToString()
        {
            return $" ID {ProductId}. {Name} - {ProductType.Name}";
        }
    }
}
