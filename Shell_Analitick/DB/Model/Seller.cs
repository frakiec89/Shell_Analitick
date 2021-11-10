using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell_Analitick.DB.Model
{

    /// <summary>
    /// Продавцы
    /// </summary>
    public class Seller
    {
        public int SellerId { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"ID {SellerId}. {Name}" ;
        }

    }
}
