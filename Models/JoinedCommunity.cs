namespace CircleConnect.Models
{
    public class JoinedCommunity : BaseEntity
    {
        public int UserId { get; set; }
        public int CommunityId { get; set; }
    }
}
