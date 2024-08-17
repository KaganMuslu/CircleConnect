namespace CircleConnect.Models
{
    public class CommunityCategory : BaseEntity
    {
        public int Id { get; set; }

        // Navigation Properties
        public int CommunityId { get; set; }
        public Community? Community { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
