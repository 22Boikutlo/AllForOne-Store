using System.ComponentModel.DataAnnotations;

namespace AllForOne_Store.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string Name { get; set; }

        // Navigation
        public ICollection<Product> Products { get; set; }
    }
}
