
namespace Task.Tracker.Api.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Day { get; set; }
        public bool Reminder { get; set; }

    }
}
