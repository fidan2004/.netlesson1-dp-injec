using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {

        private readonly IAnimal _animal;

        public AnimalController(IAnimal animal)
        {
            _animal = animal;
        }

        [HttpGet]
        public string Get()
        {
            return _animal.GetAnimal();
        }
    }
}
