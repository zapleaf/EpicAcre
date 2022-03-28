using System.ComponentModel.DataAnnotations;

namespace EpicAcre.Models
{
    /// <summary>
    /// Category includes Cut Flower, Vegetable, Fruit, etc.
    /// </summary>
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
