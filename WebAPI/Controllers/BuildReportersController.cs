using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildReportersController : ControllerBase
    {
        IBuildReporterService _builderReporterService;

        public BuildReportersController(IBuildReporterService builderReporterService)
        {
            _builderReporterService = builderReporterService;
        }

        [HttpPost("add")]
        public IActionResult Add(BuildReporter buildReporter)
        {
            var result = _builderReporterService.Add(buildReporter);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(BuildReporter buildReporter)
        {
            var result = _builderReporterService.Delete(buildReporter);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _builderReporterService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _builderReporterService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(BuildReporter buildReporter)
        {
            var result = _builderReporterService.Update(buildReporter);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
