namespace CircleConnect.Models
{
    public class Messages : BaseEntity
    {
        public int Id { get; set; }
        public int ChatId { get; set; }
        public int UserId { get; set; }

        public required string Content { get; set; }
    }
}
