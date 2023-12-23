using ClinicService.Models;
using ClinicService.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClinicService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultationController : ControllerBase
    {
        private readonly IConsultationRepository _consultationRepository;

        public ConsultationController(IConsultationRepository consultationRepository)
        {
            _consultationRepository = consultationRepository;
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] Consultation consultation)
        {
            return Ok(_consultationRepository.Create(consultation));
        }

        [HttpPut("edit")]
        public IActionResult Update([FromBody] Consultation updateRequest)
        {
            return Ok(_consultationRepository.Update(updateRequest));
        }


        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] int clientId)
        {
            int res = _clientRepository.Delete(clientId);
            return Ok(res);
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            return Ok(_clientRepository.GetAll());
        }

        [HttpGet("get/{clientId}")]
        public IActionResult GetById([FromRoute] int clientId)
        {
            return Ok(_clientRepository.GetById(clientId));
        }
    }
}
