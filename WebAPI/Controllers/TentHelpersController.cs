using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TentHelpersController : ControllerBase
    {
        ITentHelperService _tentHelperService;

        public TentHelpersController(ITentHelperService tentHelperService)
        {
            _tentHelperService = tentHelperService;
        }

        [HttpPost("add")]
        public IActionResult Add(TentHelper tentHelper)
        {
            var result = _tentHelperService.Add(tentHelper);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(TentHelper tentHelper)
        {
            var result = _tentHelperService.Delete(tentHelper);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _tentHelperService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _tentHelperService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(TentHelper tentHelper)
        {
            var result = _tentHelperService.Update(tentHelper);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("gettenthelperdetails")]
        public IActionResult GetTentHelperDetails()
        {
            var result = _tentHelperService.GetTentHelperDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("gettenthelperdetailsbyemail")]
        public IActionResult GetTentHelperDetailsByEmail(string email)
        {
            var result = _tentHelperService.GetTentHelperDetailsByEmail(email);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
