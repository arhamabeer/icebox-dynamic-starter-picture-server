using static System.Net.Mime.MediaTypeNames;

namespace icebox_dynamic_starter_picture_server.Models
{
    public class MachineRepository : IMachineRepository
    {
        private readonly ApplicationDbContext _context;

        private List<Images> _images;

        public MachineRepository(ApplicationDbContext applicationDbContext) {
            _images = new List<Images>();

            // Add items to the list
            _images.Add(new Images { Image = "image1.jpg", Type = "Eid" });
            _images.Add(new Images { Image = "image2.jpg", Type = "Ramadan" });
            _images.Add(new Images { Image = "image3.jpg", Type = "New Year" });
            _images.Add(new Images { Image = "image4.jpg", Type = "Default" });


        }

        public string GetDisplayBackground(string ip)
        {
            if (string.IsNullOrEmpty(ip))
            {
                var img = _images.FirstOrDefault(x => x.Type == "Default");
                return img.Image;
            }
            if(ip == "192.168.0.1")
            {
                var img1 = _images.FirstOrDefault(x => x.Type == "Eid");
                return img1.Image;
            }
            var img2 = _images.FirstOrDefault(x => x.Type == "Default");
            return img2.Image;
        }
    }
}
