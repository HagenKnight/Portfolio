using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Application.Constants;
using Portfolio.Application.Features.Aptitude.Queries;
using Portfolio.Core.DTO;
using Portfolio.Core.DTO.WorkerProfile;
using Portfolio.Core.Wrappers;
using System.Data;

namespace Portfolio.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AptitudeController : Controller
    {

        private readonly IMediator _mediator;

        public AptitudeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<AptitudeDTO>> GetAptitudes() =>
            await _mediator.Send(new GetAllAptitudeQuery());

        // GET: api/Aptitude/5
        [HttpGet("{id}")]
        public async Task<AptitudeDTO> GetAptitude(int id) =>
            await _mediator.Send(new GetAptitudeQuery(id));


        // POST: api/Aptitude
        [HttpPost]
        [Authorize(Roles = CustomRoles.Administrator)]
        public async Task<ApiResponse<CreateAptitudeDTO>> Post([FromBody] CreateAptitudeDTO command) =>
            await _mediator.Send(command);


        [HttpPut()]
        [Authorize(Roles = CustomRoles.Administrator)]
        public async Task<ApiResponse<UpdateAptitudeDTO>> Put([FromBody] UpdateAptitudeDTO command) =>
            await _mediator.Send(command);

        // DELETE: api/Aptitude
        [HttpDelete()]
        [Authorize(Roles = CustomRoles.Administrator)]
        public async Task<ApiResponse<DeleteAptitudeDTO>> Delete([FromBody] DeleteAptitudeDTO command) =>
            await _mediator.Send(command);

    }
}
