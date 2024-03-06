using FarmApp.Api.IServices;
using FarmApp.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace FarmApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachineController : ControllerBase
    {
        private readonly IMachineService _service;
        public MachineController(IMachineService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<Machine>> GetAll()
        {
            return Ok(await _service.GetAll());
        }

    }
}
