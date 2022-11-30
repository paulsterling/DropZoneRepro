namespace DropZoneRepro.Models
{
    public class Project
    {
        public string? ProjectName { get; set; }
        public List<Room> Rooms { get; set; } = new();
    }
}
