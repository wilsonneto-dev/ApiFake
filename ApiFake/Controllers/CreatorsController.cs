using ApiFake.DTOs;
using ApiFake.Entities;
using ApiFake.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFake.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreatorsController : ControllerBase
    {
        private readonly IRepository<Creator> _creatorRepository;

        public CreatorsController(ILogger<CreatorsController> logger, IRepository<Creator> repository)
        {
            _creatorRepository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            return Ok(await _creatorRepository.GetAll());
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            var creator = await _creatorRepository.Get(id);
            if (creator == null)
                return NotFound();
            return Ok(creator);
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var creator = await _creatorRepository.Get(id);
            if (creator == null)
                return NotFound();
            await _creatorRepository.Remove(creator.Id);
            return Ok(creator);
        }

        [HttpPost()]
        public async Task<IActionResult> Save([FromBody] SaveCreatorInputModel input)
        {
            var creator = new Creator(input.Name, input.Email, input.Link);
            await _creatorRepository.Save(creator);
            return Ok(creator);
        }

        [HttpPut()]
        public async Task<IActionResult> Update([FromBody] UpdateCreatorInputModel input)
        {
            var creator = new Creator(input.Name, input.Email, input.Link);
            await _creatorRepository.Update(creator);
            return Ok(creator);
        }
    }
}
