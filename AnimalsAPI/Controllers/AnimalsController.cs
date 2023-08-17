using Domain.DTO.Animal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services.Interfaces;

namespace AnimalsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly IAnimalesService _service;
        public AnimalsController(IAnimalesService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetAnimal")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AnimalDTO))]
        public async Task<IResult> GetAnimal(int animal)
        {

            var result = _service.GetAnimal(animal);
            return result == null ? Results.NoContent() : Results.Ok(result);

        }
        [HttpPost]
        [Route("InsertAnimal")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        public async Task<IResult> InsertAnimal(AnimalDTO animal)
        {

            var result = _service.AddAnimal(animal);
            return result == null ? Results.NoContent() : Results.Ok(result);

        }
        [HttpPut]
        [Route("UpdateAnimal")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        public async Task<IResult> UpdateAnimal(AnimalDTO animal)
        {

            var result = _service.UpdateAnimal(animal);
            return result == null ? Results.NoContent() : Results.Ok(result);

        }
        [HttpDelete]
        [Route("DeleteAnimal")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        public async Task<IResult> DeleteAnimal(int animal)
        {

            var result = _service.DeleteAnimal(animal);
            return result == null ? Results.NoContent() : Results.Ok(result);

        }
    }
}
