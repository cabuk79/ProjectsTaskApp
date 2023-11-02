using System.Runtime.CompilerServices;

namespace KanBanTrials.Models
{
    public class FileLocation
    {
        public Guid FileId { get; set; }
        public Guid TaskNoteId { get; set; }
        public string FilePath { get; set; }
    }
}
