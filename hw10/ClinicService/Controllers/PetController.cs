using ClinicService.Models;
using ClinicService.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClinicService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IPetRepository _petRepository;

        public PetController(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] Pet createRequest)
        {
            return Ok(_petRepository.Create(createRequest));
        }

        [HttpPut("edit")]
        public IActionResult Update([FromBody] Pet updateRequest)
        {
            return Ok(_petRepository.Update(updateRequest));
        }


        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] int clientId)
        {
            int res = _petRepository.Delete(clientId);
            return Ok(res);
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            return Ok(_petRepository.GetAll());
        }

        [HttpGet("get/{clientId}")]
        public IActionResult GetById([FromRoute] int clientId)
        {
            return Ok(_petRepository.GetById(clientId));
        }
    }
}
