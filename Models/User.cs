namespace CircleConnect.Models
{
    public class User : BaseEntity
    {
        public int Id { get; set; }

        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }

        // Navigation Properties
        public List<Message> Messages { get; set; }
        public List<Notification> Notifications { get; set; }
        public List<EventParticipant> EventParticipants { get; set; }
        public List<JoinedCommunity> JoinedCommunities { get; set; }
    }
}
