using System.Collections.Generic;
using System.Threading.Tasks;
using Task.Tracker.Api.Models;

namespace Task.Tracker.Api.Repository
{
    public interface ITaskRepository
    {
        Task<IEnumerable<Tasks>> GetAllTasks();
        Task<Tasks> GetTask(int id);
        System.Threading.Tasks.Task Create(Tasks task);
        Task<bool> Update(Tasks task);
        Task<bool> Delete(int id);

    }
}
