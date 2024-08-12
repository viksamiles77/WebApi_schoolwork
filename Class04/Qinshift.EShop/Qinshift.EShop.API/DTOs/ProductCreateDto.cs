using System.ComponentModel.DataAnnotations;

namespace Qinshift.EShop.API.DTOs
{
    public class ProductCreateDto
    {
        [Required(ErrorMessage = "Name cannot be empty!")]
        [MinLength(3, ErrorMessage = "Name must contain at least 3 characters!")]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
}
