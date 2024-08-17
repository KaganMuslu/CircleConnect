namespace CircleConnect.Models
{
    public class CommunityParticipant : BaseEntity
    {
        public int Id { get; set; }

        public bool isAdmin { get; set; }
        public bool isCreator { get; set; }

        // Navigation Properties
        public int UserId { get; set; }
        public User? User { get; set; }

        public int CommunityId { get; set; }
        public Community? Community { get; set; }
    }
}
