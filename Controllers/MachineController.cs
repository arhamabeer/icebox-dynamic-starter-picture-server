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
        public string GetDisplayBackground(string ip)
        {
            try
            {
                return _machine.GetDisplayBackground(ip);
            }catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
