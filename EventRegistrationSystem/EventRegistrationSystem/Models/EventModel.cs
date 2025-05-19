using System.ComponentModel.DataAnnotations;
using EventRegistrationSystem.Validation;
namespace EventRegistrationSystem.Models
{
    public class EventModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]  
        public string Title { get; set; }
        [Required]
        [FutureDate(ErrorMessage = "Data musi być w przyszłości")]
        public DateTime Date { get; set; }
        [Required]
        public String Description { get; set; } = string.Empty;
    }
}
