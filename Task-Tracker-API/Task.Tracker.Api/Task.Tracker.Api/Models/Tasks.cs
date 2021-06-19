using MongoDB.Bson.Serialization.Attributes;
namespace Task.Tracker.Api.Models
{
    public class Tasks
    {
        [BsonId]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Day { get; set; }
        public bool Reminder { get; set; }

    }
}
