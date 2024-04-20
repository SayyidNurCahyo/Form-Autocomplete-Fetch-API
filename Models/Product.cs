using System.ComponentModel.DataAnnotations.Schema;

namespace ILCS_Final_Test.Models
{
    [Table("m_product")]
    public class Product()
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

    }
}
