using System.ComponentModel.DataAnnotations;

namespace StoreApi.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio"), StringLength(50)]
        public string Name { get; set; }

        public List<Product> Products { get; set; } // Relación uno a muchos
    }
}
