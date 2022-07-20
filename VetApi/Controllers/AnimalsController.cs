using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VetApi.Services.Interfaces;

namespace VetApi.Controllers
{
    [Route("v1/[controller]")]
    public class AnimalsController : Controller
    {
       private readonly IAnimalServices _animalServices;

        public AnimalsController(IAnimalServices animalServices)
        {
            _animalServices = animalServices;
        }

        [HttpGet("{skip:int?}/{take:int?}")]
        public async Task<IActionResult> Get([FromRoute] int skip = 0,
                                             [FromRoute] int take = 10)
        {
            try
            {
                var animals = await _animalServices.Get(skip, take);
                return Ok(animals);
            }
            catch(Exception)
            {
                return BadRequest("Invalid Request!");
            }
            
        }

    }
}