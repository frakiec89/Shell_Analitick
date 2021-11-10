using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell_Analitick.DB.Model
{
    /// <summary>
    /// Склады с продукцией 
    /// </summary>
    public class Storege
    {
        public  int StoregeId { get; set; }

        /// <summary>
        /// Номер склада
        /// </summary>
        public  int  NumberStorege { get; set; }

        public  string Adress { get; set; }


        public override string ToString()
        {
            return $"ID {StoregeId}. Склад №{NumberStorege}. адрес {Adress}";
        }
    }
}
