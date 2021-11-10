namespace Shell_Analitick.DB.Model
{
   /// <summary>
   /// Вид продукции 
   /// </summary>
    public class ProductType
    {
        public int ProductTypeId { get; set; }
        public string Name { get; set; }


        public override string ToString()
        {
            return $"ID {ProductTypeId}. {Name}";
        }

    }
}