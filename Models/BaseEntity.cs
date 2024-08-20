using System.Text.Json.Serialization;

namespace CircleConnect.Models
{
    // OOP ABSTRACTION (SOYUTLAMA)
    public abstract class BaseEntity
    {
        [JsonIgnore] // Swagger'da görünmemesi için kullanıyoruz!
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
