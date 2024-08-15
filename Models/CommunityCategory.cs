namespace CircleConnect.Models
{
    public class CommunityCategory
    {
        // Navigation Properties
        public int CommunityId { get; set; }
        public Community Community { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
