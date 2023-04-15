using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class HelpersController : ControllerBase
    //{
    //    IHelperService _helperService;

    //    public HelpersController(IHelperService helperService)
    //    {
    //        _helperService = helperService;
    //    }

    //    [HttpPost("add")]
    //    public IActionResult Add(Helper helper)
    //    {
    //        var result = _helperService.Add(helper);
    //        if (result.Success)
    //        {
    //            return Ok(result);
    //        }
    //        return BadRequest(result);
    //    }

    //    [HttpPost("delete")]
    //    public IActionResult Delete(Helper helper)
    //    {
    //        var result = _helperService.Delete(helper);
    //        if (result.Success)
    //        {
    //            return Ok(result);
    //        }
    //        return BadRequest(result);
    //    }

    //    [HttpGet("getall")]
    //    public IActionResult GetAll()
    //    {
    //        var result = _helperService.GetAll();
    //        if (result.Success)
    //        {
    //            return Ok(result);
    //        }
    //        return BadRequest(result);
    //    }

    //    [HttpGet("getbyid")]
    //    public IActionResult GetById(int id)
    //    {
    //        var result = _helperService.GetById(id);
    //        if (result.Success)
    //        {
    //            return Ok(result);
    //        }
    //        return BadRequest(result);
    //    }

    //    [HttpPost("update")]
    //    public IActionResult Update(Helper helper)
    //    {
    //        var result = _helperService.Update(helper);
    //        if (result.Success)
    //        {
    //            return Ok(result);
    //        }
    //        return BadRequest(result);
    //    }
    //}
}
