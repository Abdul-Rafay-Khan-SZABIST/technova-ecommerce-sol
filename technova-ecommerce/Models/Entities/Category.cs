using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace technova_ecommerce.Models.Entities
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("category_id")]
        public int CategoryId { get; set; }

        [Column("category_name")]
        public string? CategoryName { get; set; }

        [Column("category_order")]
        public int DisplayOrder { get; set; }

        //Navigation Property - One Category has many Products
        public required ICollection<Product> Products { get; set; }


    }
}
