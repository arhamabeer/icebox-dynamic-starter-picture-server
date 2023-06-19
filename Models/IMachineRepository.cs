namespace icebox_dynamic_starter_picture_server.Models
{
    public interface IMachineRepository
    {
        public Task<string> GetDisplayBackground(string ip);
        public Task<Machine> UpdateMachineDisplayBackground(string ip, string imgUrl);
    }
}
