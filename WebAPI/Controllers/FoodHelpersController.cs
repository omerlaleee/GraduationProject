using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodHelpersController : ControllerBase
    {
        IFoodHelperService _foodHelperService;

        public FoodHelpersController(IFoodHelperService foodHelperService)
        {
            _foodHelperService = foodHelperService;
        }

        [HttpPost("add")]
        public IActionResult Add(FoodHelper foodHelper)
        {
            var result = _foodHelperService.Add(foodHelper);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(FoodHelper foodHelper)
        {
            var result = _foodHelperService.Delete(foodHelper);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _foodHelperService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _foodHelperService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(FoodHelper foodHelper)
        {
            var result = _foodHelperService.Update(foodHelper);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getfoodhelperdetails")]
        public IActionResult GetFoodHelperDetails()
        {
            var result = _foodHelperService.GetFoodHelperDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }        
        
        [HttpGet("getfoodhelperdetailsbyemail")]
        public IActionResult GetFoodHelperDetailsByEmail(string email)
        {
            var result = _foodHelperService.GetFoodHelperDetailsByEmail(email);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}