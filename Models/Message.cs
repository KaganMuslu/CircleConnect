namespace CircleConnect.Models
{
    public class Message : BaseEntity
    {
        public int Id { get; set; }

        public required string Content { get; set; }

        // Navigation Properties
        public int CommunityId { get; set; }
        public Community Community { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
