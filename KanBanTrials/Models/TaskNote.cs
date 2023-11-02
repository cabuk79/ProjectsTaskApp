using System.ComponentModel.DataAnnotations;

namespace KanBanTrials.Models
{
    public class TaskNote
    {
        public Guid NoteId { get; set; }
        public Guid TaskId { get; set; }
        [Required(ErrorMessage = "Please enter text for the note.")]
        public string NoteDetail { get; set; }
        public DateOnly DateRaised { get; set; }
        public List<FileLocation> Files { get; set; } = new(); 
    }
}
