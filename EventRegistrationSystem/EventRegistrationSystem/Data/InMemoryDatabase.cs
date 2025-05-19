using Microsoft.Extensions.Logging;
using System.Collections.Generic;
namespace EventRegistrationSystem.Models
{
    public class InMemoryDatabase
    {
        public static List<EventModel> Events { get; } = new();
        public static List<ParticipantModel> Participants { get; } = new();
    }
}
