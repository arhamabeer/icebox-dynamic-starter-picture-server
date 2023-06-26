﻿using Microsoft.AspNetCore.Mvc;
using System.IO;

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
        public async Task<ActionResult> GetDisplayBackground(string ip)
        {
            try
            {
                var res = await _machine.GetDisplayBackground(ip);
                if (res == null)
                {
                    return NotFound();
                }
                var url = res.Replace("%2F", "/");
                return Ok(url);
            }catch(Exception ex)
            {
                return StatusCode(501, new
                {
                    originalError = ex.Message,
                    errorMessage = "Failed to fetch Data from the Database."
                });
            }
        }

        [HttpPost("{ip=string}/{imgUrl=string}")]
        public async Task<ActionResult> UpdateMachineDisplayBackground(string ip, string imgUrl) {
            try
            {
                var res = await _machine.UpdateMachineDisplayBackground(ip, imgUrl);
                if (res == null)
                {
                    return null;
                }
                return Ok(res);
            }
            catch (Exception ex)
            {
                return StatusCode(501, new
                {
                    originalError = ex.Message,
                    errorMessage = "Failed to fetch Data from the Database."
                });
            }
        }

        [HttpPost("{path}/{type}")]
        public async Task<ActionResult> AddNewImage(string path, string type)
        {
            try
            {
                var res = await _machine.AddNewDisplayBackground(path, type);
                if (res == "001") return BadRequest("path or type must not be empty");
                if (res == "002") return BadRequest("Path or Type is already exists in the Database");
                if (res == "004") return StatusCode(500, "Error in saving new item. Try Again");
                return Ok("Image added successfully");
            }catch(Exception ex)
            {
                return StatusCode(501, new
                {
                    originalError = ex.Message,
                    errorMessage = "Failed to fetch Data from the Database."
                });
            }
        }

        [HttpPost("{path}")]
        public async Task<ActionResult> DeleteImage(string path)
        {
            try
            {
                var res = await _machine.RemoveDisplayBackground(path);
                if(res == null)
                {
                    return BadRequest();
                }
                return Ok(res);
            }
            catch(Exception ex)
            {
                return StatusCode(501, new
                {
                    originalError = ex.Message,
                    errorMessage = "Failed to delete Data from the Database."
                });
            }
        }

        [HttpPost("{existing_path}/{new_type}/{new_path}")]
        public async Task<ActionResult> UpdateImage(string existing_path, string new_type, string new_path)
        {
            try
            {
                var res = await _machine.UpdateBackground(existing_path, new_type, new_path);
                if (res == null)
                {
                    return BadRequest();
                }
                return Ok(res);
            }
            catch (Exception ex)
            {
                return StatusCode(501, new
                {
                    originalError = ex.Message,
                    errorMessage = "Failed to delete Data from the Database."
                });
            }
        }
        
    }
}
