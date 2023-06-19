using Microsoft.AspNetCore.Mvc;

namespace icebox_dynamic_starter_picture_server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MachineController : ControllerBase
    {
        private readonly IMachineRepository _machine;

        public MachineController(IMachineRepository machineRepository)
        {
            _machine = machineRepository;
        }
        [HttpGet("{ip=string}")]
        public async Task<string> GetDisplayBackground(string ip)
        {
            try
            {
                var res = await _machine.GetDisplayBackground(ip);
                if (res == null)
                {
                    return "Not found";
                }
                return res;
            }catch(Exception ex)
            {
                return ex.Message;
            }
        }

        [HttpGet("{ip=string, imgUrl=string}")]
        public async Task<Machine> UpdateMachineDisplayBackground(string ip, string imgUrl) {
            try
            {
                var res = await _machine.UpdateMachineDisplayBackground(ip, imgUrl);
                if (res == null)
                {
                    return null;
                }
                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
