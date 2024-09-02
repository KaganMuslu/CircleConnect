using CircleConnect.Data;
using CircleConnect.Models;
using CircleConnect.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CircleConnect.Controllers
{
    [Route("api/event")]
    [ApiController]
    public class EventController : BaseController<Event>
    {
        private readonly NotificationService _notificationService;

        // Dependency Injection (DI)
        public EventController(AppDbContext appDbContext, NotificationService notificationService) : base(appDbContext)
        {
            _notificationService = notificationService;
        }

        [HttpPost]
        public override IActionResult Add([FromBody] Event newEvent)
        {
            try
            {
                if (newEvent == null)
                    return BadRequest(); // 400

                _context.Events.Add(newEvent);
                _context.SaveChanges();

                // Notify Community Members
                NotifyCommunityMembers(newEvent.CommunityId, newEvent.Name);

                return StatusCode(201, newEvent);
            }
            catch (Exception ex)
            {
                // Log the exception (consider using a logger)
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        private void NotifyCommunityMembers(int communityId, string eventName)
        {
            try
            {
                var communityMembers = _context.CommunityParticipants
                    .Where(c => c.CommunityId == communityId)
                    .Select(c => c.UserId)
                    .ToList();

                if (!communityMembers.Any())
                {
                    Console.WriteLine("Community memebers are null!");
                    return;
                }

                foreach (var memberId in communityMembers)
                {
                    string message = $"New event '{eventName}' has been created in your community.";
                    _notificationService.PublishNotification($"user-{memberId}", message);
                }
            }
            catch (Exception ex)
            {
                // Log the error and handle it
                Console.WriteLine($"Error notifying members: {ex.Message}");
                throw; // or handle the exception as needed
            }
        }


    }
}
