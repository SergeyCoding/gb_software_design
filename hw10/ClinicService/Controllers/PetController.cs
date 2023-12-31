﻿using ClinicService.Models;
using ClinicService.Models.Requests;
using ClinicService.Services;
using Mapster;
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
        public IActionResult Create([FromBody] CreatePetRequest createRequest)
        {
            var item = createRequest.Adapt<Pet>();
            return base.Ok(_petRepository.Create(item));
        }

        [HttpPut("edit")]
        public IActionResult Update([FromBody] Pet updateRequest)
        {
            var item = updateRequest.Adapt<Pet>();
            return base.Ok(_petRepository.Update(item));
        }


        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] int id)
        {
            int res = _petRepository.Delete(id);
            return Ok(res);
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            return Ok(_petRepository.GetAll());
        }

        [HttpGet("get/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok(_petRepository.GetById(id));
        }
    }
}
