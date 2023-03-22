using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Application.Features.ResumeType.Queries;
using Portfolio.Core.DTO.ResumeType;

namespace Portfolio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumeTypeController : ControllerBase
    {

        private readonly IMediator _mediator;

        public ResumeTypeController(IMediator mediator) => _mediator = mediator;


        [HttpGet]
        public async Task<IEnumerable<ResumeTypeDTO>> GetResumeTypes() =>
            await _mediator.Send(new GetAllResumeTypeQuery());
    }
}
