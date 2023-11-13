namespace KanBanTrials.Models
{
    public class DataGridColumnMetadata
    {
        public string Name { get; set; }
        public string Label { get; set; }
        public string? FormatString { get; set; }
        public bool IsSearchable { get; set; }
        public string? Filter { get; set; }
    }
}
