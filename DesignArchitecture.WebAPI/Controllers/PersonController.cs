using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignArchitecture.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet("getPersonList")]
        public IActionResult GetPersonList()
        {
            var result = _personService.GetAllPerson();
            return Ok(result);
        }

        [HttpPost("postPersonAdded")]
        public IActionResult PostPerson(Person person)
        {
            var result = _personService.GetPersonAdded(person);
            return Ok(result);
        }

    }
}
