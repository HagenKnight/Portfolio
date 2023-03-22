using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Application.Features.Resume;
using Portfolio.Application.Features.Resume.Queries;
using Portfolio.Application.Models;
using Portfolio.Core.DTO.Resume;
using Portfolio.Core.DTO.Resume;
using Portfolio.Core.DTO.Resume;
using Portfolio.Core.DTO.Resume;
using Portfolio.Core.Wrappers;
using System.Data;

namespace Portfolio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumeController : ControllerBase
    {

        private readonly IMediator _mediator;

        public ResumeController(IMediator mediator) => _mediator = mediator;



        [HttpGet("{workerProfileid:int}")]
        public async Task<IEnumerable<ResumeDTO>> GetResumes(int workerProfileid) =>
            await _mediator.Send(new GetAllResumeQuery(workerProfileid));


        // POST: api/GetResume
        [HttpPost]
        [Authorize(Roles = CustomRoles.Administrator)]
        public async Task<ApiResponse<CreateResumeDTO>> Post([FromBody] CreateResumeDTO command) =>
            await _mediator.Send(command);


        [HttpPut()]
        [Authorize(Roles = CustomRoles.Administrator)]
        public async Task<ApiResponse<UpdateResumeDTO>> Put([FromBody] UpdateResumeDTO command) =>
            await _mediator.Send(command);

        // DELETE: api/Resume
        [HttpDelete()]
        [Authorize(Roles = CustomRoles.Administrator)]
        public async Task<ApiResponse<DeleteResumeDTO>> Delete([FromBody] DeleteResumeDTO command) =>
            await _mediator.Send(command);
    }
}
