using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransporterHelpersController : ControllerBase
    {
        ITransporterHelperService _transporterHelperService;

        public TransporterHelpersController(ITransporterHelperService transporterHelperService)
        {
            _transporterHelperService = transporterHelperService;
        }

        [HttpPost("add")]
        public IActionResult Add(TransporterHelper transporterHelper)
        {
            var result = _transporterHelperService.Add(transporterHelper);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(TransporterHelper transporterHelper)
        {
            var result = _transporterHelperService.Delete(transporterHelper);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _transporterHelperService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _transporterHelperService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(TransporterHelper transporterHelper)
        {
            var result = _transporterHelperService.Update(transporterHelper);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
