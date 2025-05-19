using System.ComponentModel.DataAnnotations;

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
        public DateTime Date { get; set; }
        [Required]
        public String Description { get; set; } = string.Empty;
    }
}
