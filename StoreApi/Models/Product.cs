using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StoreApi.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio"), StringLength(30)]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio"), ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio"), ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public Supplier Suppliers { get; set; }
    }
}
