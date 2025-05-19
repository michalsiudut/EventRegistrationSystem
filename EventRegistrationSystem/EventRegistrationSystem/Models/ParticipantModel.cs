using System.ComponentModel.DataAnnotations;

namespace EventRegistrationSystem.Models
{
    public class ParticipantModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public int EventID { get; set; }
    }
}
