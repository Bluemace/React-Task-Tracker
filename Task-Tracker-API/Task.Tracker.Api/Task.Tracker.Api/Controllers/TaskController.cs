using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Task.Tracker.Api.Models;
using Task.Tracker.Api.Repository;

namespace Task.Tracker.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TaskController : Controller
    {
        private readonly ITaskRepository repo;

        public TaskController(ITaskRepository repo)
        {
            this.repo = repo;
        }
        //TODO: Error handling
        [HttpGet]
        public async Task<ActionResult<Tasks>> GetAllTasks()
        {
            return new ObjectResult(await repo.GetAllTasks());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tasks>> GetTask(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<ActionResult<Tasks>> PostTask([FromBody] Tasks task)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Tasks>> UpdateTask(int id, [FromBody] Tasks task)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Tasks>> DeleteTask(int id)
        {
            throw new NotImplementedException();
        }
    }
}
