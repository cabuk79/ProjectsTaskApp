using KanBanTrials.Models;
using Microsoft.AspNetCore.SignalR;

namespace KanBanTrials
{
    public class KanbanHub : Hub
    {
        public Task UpdateTask(TaskItem updatedTask)
        {
            return Clients.All.SendAsync("ReceiveUpdatedTask", updatedTask);
        }

        public Task UpdateTasks()
        {
            return Clients.All.SendAsync("RecievedAllTasksUpdate");
        }
    }
}
