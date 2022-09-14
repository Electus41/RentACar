using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelYearsController : ControllerBase
    {
        IModelyearService _modelYearsService;

        public ModelYearsController(IModelyearService modelYearsService)
        {
            _modelYearsService = modelYearsService;
        }
        [HttpGet("getall")]

        public IActionResult GetAll()
        {
            var result =  _modelYearsService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);

            
        }
        [HttpGet("Add")]
        public IActionResult Add(ModelYear modelYear)
        {
            var result = _modelYearsService.Add(modelYear);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("Delete")]
        public IActionResult Delete(ModelYear modelYear)
        {
            var result = _modelYearsService.Delete(modelYear);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("Update")]
        public IActionResult Update(ModelYear modelYear)
        {
            var result = _modelYearsService.Update(modelYear);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

    }
}
