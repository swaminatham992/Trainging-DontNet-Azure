using System.ComponentModel.DataAnnotations;

namespace WebApplication8_Products_APi.Model
{
    public class Product
    {
        [Key]
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int Price { get; set; }

        public string Brand { get; set; }

        public DateTime ManufactureDate { get; set; }

        public DateTime ExpirationDate { get; set; }
    }
}
