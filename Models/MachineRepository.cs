using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace icebox_dynamic_starter_picture_server.Models
{
    public class MachineRepository : IMachineRepository
    {
        private readonly ApplicationDbContext _context;

        public MachineRepository(ApplicationDbContext applicationDbContext) {
            _context = applicationDbContext;

        }

        public async Task<string> AddNewDisplayBackground(string path, string type)
        {
            if(string.IsNullOrEmpty(path) || string.IsNullOrEmpty(type)) {
                return "001";
            }
            if(await _context.Images.AnyAsync(x => x.Path == path) || await _context.Images.AnyAsync(x=> x.Type == type))
            {
                return "002";
            }
            var img = new Images { Path = path, Type = type };
           await _context.Images.AddAsync(img);
            var res = await _context.SaveChangesAsync();

            if (res > 0) return "003";
            return "004";
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
            if (img_res == null) return null;
            return img_res.Path;
        }

        public async Task<string> RemoveDisplayBackground(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return null;
            }

            Images img_res = await _context.Images.FirstOrDefaultAsync(x => x.Path == path);
            if (img_res == null)
            {
                return null;
            }
            img_res.isDeleted = true;
            var res = await _context.SaveChangesAsync();
            if (res > 0)
            {
                return "OK";
            }
            return null;
        }

        public async Task<string> UpdateBackground(string existing_path, string new_type, string new_path)
        {
            if (string.IsNullOrEmpty(existing_path) || string.IsNullOrEmpty(new_type) || string.IsNullOrEmpty(new_path))
            {
                return null;
            }

            Images img_res = await _context.Images.FirstOrDefaultAsync(x => x.Path == existing_path);
            if (img_res == null)
            {
                return null;
            }
            img_res.Path = new_path;
            img_res.Type = new_type;
            var res = await _context.SaveChangesAsync();
            if (res > 0)
            {
                return "OK";
            }
            return null;
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
