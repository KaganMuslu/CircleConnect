namespace CircleConnect.Models
{
    public class JoinedCommunity : BaseEntity
    {
        public int Id { get; set; }

        // Navigation Properties
        public int UserId { get; set; }
        public User User { get; set; }

        public int CommunityId { get; set; }
        public Community Community{ get; set; }
    }
}
