namespace MyRestaurant.API.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsRead { get; set; }
    }
}
