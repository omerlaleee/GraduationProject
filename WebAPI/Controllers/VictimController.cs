using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VictimController : ControllerBase
    {
        IVictimService _victimService;

        public VictimController(IVictimService victimService)
        {
            _victimService = victimService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result=_victimService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost]
        public IActionResult Add(Victim victim)
        {
            var result=_victimService.Add(victim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Victim victim)
        {
            var result=_victimService.Delete(victim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Victim victim)
        {
            var result=_victimService.Add(victim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}