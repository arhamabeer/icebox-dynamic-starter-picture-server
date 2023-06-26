namespace icebox_dynamic_starter_picture_server.Models
{
    public interface IMachineRepository
    {
        public Task<string> GetDisplayBackground(string ip);
        public Task<Machine> UpdateMachineDisplayBackground(string ip, string imgUrl);
        public Task<string> AddNewDisplayBackground(string path, string type);
        public Task<string> RemoveDisplayBackground(string path);

        public Task<string> UpdateBackground(Images images);
    }
}
