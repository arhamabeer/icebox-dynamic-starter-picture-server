namespace icebox_dynamic_starter_picture_server.Models
{
    public class Machine
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int? ImageId { get; set; } // Foreign key
        public Images? Image { get; set; } // Navigation property
    }
}
