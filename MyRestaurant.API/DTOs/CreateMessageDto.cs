using System.Text.Json.Serialization;

namespace MyRestaurant.API.DTOs
{
    public class CreateMessageDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        [JsonIgnore]
        public bool IsRead { get; set; } = false;
        [JsonIgnore]
        public DateTime SendDate { get; set; } = DateTime.Now;
    }
}
