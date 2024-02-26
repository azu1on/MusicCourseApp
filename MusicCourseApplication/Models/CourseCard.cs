using System.Text.Json.Serialization;

namespace MusicCourseApplication.Models
{
    public class CourseCard
    {
        public int Id { get; set; }
        [JsonPropertyName("image")]
        public string? Image { get; set; }
        [JsonPropertyName("contentName")]
        public string? ContentName { get; set; }
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        [JsonPropertyName("price")]
        public float Price { get; set; }
        [JsonPropertyName("usersRating")]
        public string? UsersRating { get; set; }
        [JsonPropertyName("level")]
        public string? Level { get; set; }
        [JsonPropertyName("program")]
        public List<string>? Program { get; set; }

    }
}
