namespace CircleConnect.Models
{
    public class Notifications : BaseEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public required string Content { get; set; }
        public required string Type { get; set; }
        public int IsRead { get; set; }
    }
}
