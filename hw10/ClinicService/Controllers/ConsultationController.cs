using ClinicService.Models;
using ClinicService.Models.Requests;
using ClinicService.Services;
using Mapster;
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
        public IActionResult Create([FromBody] CreateConsultationRequest consultationRequest)
        {
            var consultation = consultationRequest.Adapt<Consultation>();
            return Ok(_consultationRepository.Create(consultation));
        }

        [HttpPut("edit")]
        public IActionResult Update([FromBody] UpdateConsultationRequest updateRequest)
        {
            var consultation = updateRequest.Adapt<Consultation>();
            return base.Ok(_consultationRepository.Update(consultation));
        }


        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] int id)
        {
            int res = _consultationRepository.Delete(id);
            return Ok(res);
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            return Ok(_consultationRepository.GetAll());
        }

        [HttpGet("get/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok(_consultationRepository.GetById(id));
        }
    }
}
