using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AllForOne_Store.Models
{
    public class Delivery
    {
        [Key]
        public int DeliveryId { get; set; }

        public string Address { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }

        public DateTime DeliveryDate { get; set; }

        // Navigation
        public Order Order { get; set; }
    }
}
