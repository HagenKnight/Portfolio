using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Application.Features.WorkerProfile;
using Portfolio.Application.Models;
using Portfolio.Core.DTO.WorkerProfile;
using Portfolio.Core.Wrappers;

namespace Portfolio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerProfileController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WorkerProfileController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IEnumerable<WorkerProfileDTO>> GetWorkerProfiles() =>
            await _mediator.Send(new GetAllWorkerProfileQuery());

        [HttpGet("{id:int}")]
        public async Task<WorkerProfileDTO> GetWorkerProfile(int id) =>
            await _mediator.Send(new GetWorkerProfileQuery(id));


        //}/workerprofile/emailValue
        [HttpGet("{email}")]
        public async Task<WorkerProfileDTO> GetWorkerProfile(string email) =>
            await _mediator.Send(new GetWorkerProfileQuery(email));

        // POST: api/GetWorkerProfile
        [HttpPost]
        [Authorize(Roles = CustomRoles.Administrator)]
        public async Task<ApiResponse<CreateWorkerProfileDTO>> Post([FromBody] CreateWorkerProfileDTO command) =>
            await _mediator.Send(command);


        [HttpPut()]
        [Authorize(Roles = CustomRoles.Administrator)]
        public async Task<ApiResponse<UpdateWorkerProfileDTO>> Put([FromBody] UpdateWorkerProfileDTO command) =>
            await _mediator.Send(command);

        // DELETE: api/WorkerProfile
        [HttpDelete()]
        [Authorize(Roles = CustomRoles.Administrator)]
        public async Task<ApiResponse<DeleteWorkerProfileDTO>> Delete([FromBody] DeleteWorkerProfileDTO command) =>
            await _mediator.Send(command);


    }
}
