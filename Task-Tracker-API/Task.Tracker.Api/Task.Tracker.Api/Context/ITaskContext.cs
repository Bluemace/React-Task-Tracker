using MongoDB.Driver;
using Task.Tracker.Api.Models;

namespace Task.Tracker.Api.Context
{
    public interface ITaskContext
    {
        IMongoCollection<Tasks> Tasks { get; }
    }
}
