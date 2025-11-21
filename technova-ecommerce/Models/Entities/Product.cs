using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace technova_ecommerce.Models.Entities
{
    [Table("products")]
    public class Product
    {
        [Column("product_id")]
        public int ProductId { get; set; }

        [Column("product_name")]
        public string? ProductName { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("stock_price")]
        public decimal StockPrice { get; set; }

        // Foriegn Key
        [Column("category_id")]
        public int CategoryId { get; set; }

        //navigation 
        [ForeignKey("CategoryId")]
        public required Category Category { get; set; }


        //cascade means if primary data is removed secondary also gets removed
    }
}
