using MongoDB.Driver;
using Task.Tracker.Api.Config;
using Task.Tracker.Api.Models;

namespace Task.Tracker.Api.Context
{
    public class TaskContext : ITaskContext
    {
        private readonly IMongoDatabase _db;

        public TaskContext(MongoDBConfig config)
        {
            var client = new MongoClient(config.ConnectionString);
            _db = client.GetDatabase(config.Database);

        }

        public IMongoCollection<Tasks> Tasks => _db.GetCollection<Tasks>("Tasks");
    }
}
