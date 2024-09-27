using System.ComponentModel.DataAnnotations;

namespace Assignment_1.Models
{
    public class Equipment
    {
        public int Id { get; set; }

        [Required]
        public EquipmentType Type { get; set; } 

        [Required]
        public string Description { get; set; }

        [Required]
        public bool IsAvailable { get; set; }
    }
}
