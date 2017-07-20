using System.ComponentModel.DataAnnotations;

namespace TestTask.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
    }
}