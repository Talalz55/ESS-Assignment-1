using System.ComponentModel.DataAnnotations;

namespace Assignment_1.Models
{
    
    public class EquipmentRequest
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Phone number must be in the format xxx-xxx-xxxx")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public string Role { get; set; }

        [Required(ErrorMessage = "Equipment type is required")]
        public EquipmentType Equipment { get; set; }

        [Required(ErrorMessage = "Request details are required")]
        public string RequestDetails { get; set; }

        [Required(ErrorMessage = "Duration is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Duration must be a positive number")]
        public int Duration { get; set; }        
    }
}
