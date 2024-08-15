namespace CircleConnect.Models
{
    public class JoinedCommunities : BaseEntity
    {
        public int UserId { get; set; }
        public int CommunityId { get; set; }
    }
}
