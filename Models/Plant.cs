using System.ComponentModel.DataAnnotations;

namespace EpicAcre.Models
{
    /// <summary>
    /// A Plant is anything that can be put into the ground and grown.
    /// </summary>
    public class Plant
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual Category Category { get; set; }

    }
}
