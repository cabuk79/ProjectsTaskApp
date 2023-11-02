using System.ComponentModel.DataAnnotations;

namespace KanBanTrials.Models
{
    public class TaskItem
    {
        public Guid TaskId { get; set; }
        [Required(ErrorMessage = "You must enter a name for the new task.")]
        public string TaskName { get; set; }
        public DateOnly DateRaised { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
        [Required(ErrorMessage = "Please select a catagory for this task.")]
        public string Catagory { get; set; }
        public string Status { get; set; }
        public string OverDueStatus { get; set; }
        public List<TaskNote> TaskNotes { get; set; }

    }
}
