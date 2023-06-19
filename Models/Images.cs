using System.ComponentModel.DataAnnotations;

namespace icebox_dynamic_starter_picture_server.Models
{
    public class Images
    {
        [Key]
        public int ImageId { get; set; } // Primary key

        public string Path { get; set; }
        public string Type { get; set; }

    }
}
