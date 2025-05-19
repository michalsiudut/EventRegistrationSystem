using EventRegistrationSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventRegistrationSystem.Controllers
{
    public class ParticipantsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View(InMemoryDatabase.Participants);
        }
        [HttpPost]
        public IActionResult CreateAParticipant(ParticipantModel participant)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", participant);
            }
            participant.Id = InMemoryDatabase.Participants.Count > 0
                ? InMemoryDatabase.Participants.Max(p => p.Id) + 1
                : 1;

            InMemoryDatabase.Participants.Add(participant);

            return RedirectToAction("Create");
        }
        [HttpGet]
        public IActionResult CreateAParticipant()
        {
            return View();
        }
        public IActionResult ListByEvent(int eventId)
        {
            var filtered = InMemoryDatabase.Participants
                .Where(p => p.EventID == eventId)
                .ToList();

            return View("Create", filtered); // lub inny widok obsługujący List<ParticipantModel>
        }

    }
}
