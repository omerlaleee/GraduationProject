using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperatorHelpersController : ControllerBase
    {
        IOperatorHelperService _operatorHelperService;

        public OperatorHelpersController(IOperatorHelperService operatorHelperService)
        {
            _operatorHelperService = operatorHelperService;
        }

        [HttpPost("add")]
        public IActionResult Add(OperatorHelper operatorHelper)
        {
            var result = _operatorHelperService.Add(operatorHelper);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(OperatorHelper operatorHelper)
        {
            var result = _operatorHelperService.Delete(operatorHelper);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _operatorHelperService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _operatorHelperService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(OperatorHelper operatorHelper)
        {
            var result = _operatorHelperService.Update(operatorHelper);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getoperatorhelperdetails")]
        public IActionResult GetOperatorHelperDetails()
        {
            var result = _operatorHelperService.GetOperatorHelperDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getoperatorhelperdetailsbyemail")]
        public IActionResult GetOperatorHelperDetailsByEmail(string email)
        {
            var result = _operatorHelperService.GetOperatorHelperDetailsByEmail(email);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
