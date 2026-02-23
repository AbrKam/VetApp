using Microsoft.AspNetCore.Mvc;
using VetApp.Application.Contracts.Owner;
using VetApp.Application.Interfaces.ServiceInterfaces;

namespace VetApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService _service;

        public OwnerController(IOwnerService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OwnerResponse>>> GetAll()
        {
            var owners = await _service.GetAllAsync();
            return Ok(owners);
        }

        [HttpPost]
        public async Task<ActionResult<OwnerResponse>> Create(CreateOwnerRequest request)
        {
            var response = await _service.CreateAsync(request);
            return CreatedAtAction(nameof(GetAll), new {id = response.Id}, response);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<OwnerResponse>> Update([FromRoute] long id, [FromBody] UpdateOwnerRequest request)
        {
            var response = await _service.UpdateAsync(id, request);
            if (response == null) return NotFound();
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<OwnerResponse>> Delete([FromRoute] long id)
        {
            var response = await _service.DeleteAsync(id);
            if (response == null) return NotFound();
            return response;
        }
    }
}