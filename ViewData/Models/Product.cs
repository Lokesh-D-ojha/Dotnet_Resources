using System.ComponentModel.DataAnnotations;

namespace ViewData.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int? CategoryId { get; set; }

    }
}
