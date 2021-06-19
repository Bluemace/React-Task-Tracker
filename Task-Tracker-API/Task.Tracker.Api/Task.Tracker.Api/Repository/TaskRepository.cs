using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task.Tracker.Api.Context;
using Task.Tracker.Api.Models;

namespace Task.Tracker.Api.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ITaskContext context;
        public TaskRepository(ITaskContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Tasks>> GetAllTasks()
        {
            return await context
                    .Tasks
                    .Find(_ => true)
                    .ToListAsync();
        }

        public Task<Tasks> GetTask(int id)
        {
            FilterDefinition<Tasks> filter = Builders<Tasks>.Filter.Eq(m => m.Id, id);
            return context
                .Tasks
                .Find(filter)
                .FirstOrDefaultAsync();
        }

        //TODO: Return bool or int to determine if the item was added or not.
        public async System.Threading.Tasks.Task Create(Tasks task)
        {
            await context.Tasks.InsertOneAsync(task);
        }

        public async Task<bool> Update(Tasks task)
        {
            ReplaceOneResult updateResult =
                await context.Tasks.ReplaceOneAsync(filter: x => x.Id == task.Id, replacement: task);

            return updateResult.IsAcknowledged && updateResult.ModifiedCount > 0;
        }

        public async Task<bool> Delete(int id)
        {
            FilterDefinition<Tasks> filter = Builders<Tasks>.Filter.Eq(x => x.Id, id);
            DeleteResult deleteResult = await context.Tasks.DeleteOneAsync(filter);

            return deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0;
        }
    }
}
