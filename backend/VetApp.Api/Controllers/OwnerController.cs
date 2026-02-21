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

        public async Task<ActionResult<OwnerResponse>> Create(CreateOwnerRequest request)
        {
            var response = await _service.CreateAsync(request);
            return CreatedAtAction(nameof(GetAll), new {id = response.Id}, response);
        }
    }
}