namespace CircleConnect.Models
{
    public class Categories : BaseEntity
    {
        public int Id { get; set; }

        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
