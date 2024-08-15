using CircleConnect.Models;

namespace CircleConnect.Data
{
    public class ApplicationContext
    {
        public static List<Community> Communities { get; set; }
        static ApplicationContext()
        {
            Communities = new List<Community>()
            {
                new Community()
                {
                    Id = 1,
                    CreatorId = 101,
                    ChatId = 201,
                    Name = "Tech Enthusiasts",
                    Description = "A community for technology enthusiasts to discuss the latest trends.",
                    Location = "San Francisco",
                    Date = new DateTime(2024, 9, 10, 18, 0, 0),
                    IsPrivate = 0
                },
                new Community()
                {
                    Id = 2,
                    CreatorId = 102,
                    ChatId = 202,
                    Name = "Book Club",
                    Description = "A group of book lovers sharing and discussing their favorite books.",
                    Location = "New York",
                    Date = new DateTime(2024, 10, 15, 19, 30, 0),
                    IsPrivate = 1
                }
            };
        }
    }
}
