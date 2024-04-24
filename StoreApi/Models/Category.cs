using System.ComponentModel.DataAnnotations;

namespace StoreApi.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio"), StringLength(25)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public List<Product> Products { get; set; } // Relación uno a muchos
    }
}
