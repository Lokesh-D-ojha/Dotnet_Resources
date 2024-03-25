using System.ComponentModel.DataAnnotations;

namespace ViewData.Models
{
    public class Category
    {
        [key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="The name should start from capital letter")]
        [Display(Name ="Name-Lokesh")]
        [StringLength(10,MinimumLength =5)]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "The message should be clear")]
        [Display(Name = "Short summery")]
        [StringLength(20, MinimumLength = 10)]
        public string Description { get; set; }
    }
}
