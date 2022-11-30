namespace DropZoneRepro.Models
{
    public class Room
    {
        public string? RoomName { get; set; }
        public List<Callout> Callouts { get; set; } = new();
    }
}
