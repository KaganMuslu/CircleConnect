namespace CircleConnect.Models
{
    public class Event : BaseEntity
    {
        public int Id { get; set; }
        public int CreatorId { get; set; }
        public int CommunityId { get; set; }

        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Location { get; set; }
        public required string Category { get; set; }
    }
}
