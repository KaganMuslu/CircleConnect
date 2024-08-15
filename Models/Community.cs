namespace CircleConnect.Models
{
    public class Community : BaseEntity
    {
        public int Id { get; set; }

        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Location { get; set; }
        public required DateTime Date { get; set; }
        public int IsPrivate { get; set; }

        // Navigation Properties
        public int UserId { get; set; }
        public User User { get; set; }

        public List<Event> Events { get; set; }

        public List<CommunityCategory> CommunityCategories { get; set; }
        public List<JoinedCommunity> JoinedCommunities { get; set; }
        public List<Message> Messages { get; set; }
    }
}
