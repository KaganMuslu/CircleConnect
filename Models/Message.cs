namespace CircleConnect.Models
{
    public class Message : BaseEntity
    {
        public int Id { get; set; }
        public int ChatId { get; set; }
        public int UserId { get; set; }

        public required string Content { get; set; }
    }
}
