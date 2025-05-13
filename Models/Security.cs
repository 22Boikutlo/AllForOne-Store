using System.ComponentModel.DataAnnotations;

namespace AllForOne_Store.Models
{
    public class Security
    {
        [Key]
        public int SecurityId { get; set; }

        public string Action { get; set; }

        public DateTime ActionDate { get; set; }

    }
}
