using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HauseHelpersController : ControllerBase
    {
        IHouseHelperService _houseHelperService;

        public HauseHelpersController(IHouseHelperService houseHelperService)
        {
            _houseHelperService = houseHelperService;
        }

        [HttpPost("add")]
        public IActionResult Add(HouseHelper houseHelper)
        {
            var result = _houseHelperService.Add(houseHelper);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(HouseHelper houseHelper)
        {
            var result = _houseHelperService.Delete(houseHelper);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _houseHelperService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _houseHelperService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(HouseHelper houseHelper)
        {
            var result = _houseHelperService.Update(houseHelper);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
