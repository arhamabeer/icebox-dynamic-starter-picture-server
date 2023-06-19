using static System.Net.Mime.MediaTypeNames;

namespace icebox_dynamic_starter_picture_server.Models
{
    public class MachineRepository : IMachineRepository
    {
        private readonly ApplicationDbContext _context;

        public MachineRepository(ApplicationDbContext applicationDbContext) {
            _context = applicationDbContext;

        }

        public async Task<string> GetDisplayBackground(string ip)
        {

            if (string.IsNullOrWhiteSpace(ip))
            {
                var result = await _context.Images.FirstOrDefaultAsync(x => x.ImageId == 5);
                return result.Path;
            }
            var res = await _context.Machines.FirstOrDefaultAsync(x => x.Ip == ip);
            if (res == null) {
                return $"We cannot find the machine allocated to your IP: {ip}";
            }
            var img_res = await _context.Images.FirstOrDefaultAsync(x=> x.ImageId == res.ImageId);
            return img_res.Path;
        }

        public async Task<Machine> UpdateMachineDisplayBackground(string ip, string imgUrl)
        {
            
            if (string.IsNullOrWhiteSpace(ip))
            {
                return null;
            }
            if (string.IsNullOrEmpty(imgUrl))
            {
                return null;

            }
            var res = await _context.Machines.FirstOrDefaultAsync(x => x.Ip == ip);
            if (res == null) 
            {
                return null;
            }
            var img_res = await _context.Images.FirstOrDefaultAsync(x=> x.Path == imgUrl);
            if(img_res != null)
            {
                res.ImageId = img_res.ImageId;
                await _context.SaveChangesAsync();
                return res;
            }
            return res;
        }
    }
}
