namespace CircleConnect.Models
{
    public class Community : BaseEntity
    {
        public int Id { get; set; }

        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Location { get; set; }
        public int IsPrivate { get; set; }

        // Navigation Properties
        public List<Event>? Events { get; set; }

        public List<CommunityCategory>? CommunityCategories { get; set; }
        public List<CommunityParticipant>? JoinedCommunities { get; set; }
        public List<Message>? Messages { get; set; }
    }
}
