namespace CircleConnect.Models
{
    public class Communities : BaseEntity
    {
        public int Id { get; set; }
        public int CreatorId { get; set; }
        public int ChatId { get; set; }

        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Location { get; set; }
        public required DateTime Date { get; set; }
        public int IsPrivate { get; set; }

    }
}
