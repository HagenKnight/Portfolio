using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Application.Constants;
using Portfolio.Application.Features.Interest.Queries;
using Portfolio.Core.DTO;
using Portfolio.Core.Wrappers;

namespace Portfolio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestController : Controller
    {
        private readonly IMediator _mediator;

        public InterestController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IEnumerable<InterestDTO>> GetInterests() =>
            await _mediator.Send(new GetAllInterestQuery());


        // GET: api/Interest/5
        [HttpGet("{id}")]
        public async Task<InterestDTO> GetInterest(int id) =>
            await _mediator.Send(new GetInterestQuery(id));

        // POST: api/Aptitude
        [HttpPost]
        [Authorize(Roles = CustomRoles.Administrator)]
        public async Task<ApiResponse<CreateInterestDTO>> Post([FromBody] CreateInterestDTO command) =>
            await _mediator.Send(command);


        [HttpPut()]
        [Authorize(Roles = CustomRoles.Administrator)]
        public async Task<ApiResponse<UpdateInterestDTO>> Put([FromBody] UpdateInterestDTO command) =>
            await _mediator.Send(command);

        // DELETE: api/Interest
        [HttpDelete()]
        [Authorize(Roles = CustomRoles.Administrator)]
        public async Task<ApiResponse<DeleteInterestDTO>> Delete([FromBody] DeleteInterestDTO command) =>
            await _mediator.Send(command);
    }
}
