namespace DropZoneRepro.Models
{
    public class Callout
    {
        public string? CalloutName { get; set; }

        public int CalloutIndex { get; set; }

        public List<CalloutPhoto> CalloutPhotos { get; set; } = new();
    }
}
