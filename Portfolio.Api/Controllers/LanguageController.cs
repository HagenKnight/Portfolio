using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Application.Constants;
using Portfolio.Application.Features.Language.Queries;
using Portfolio.Core.DTO;
using Portfolio.Core.Wrappers;

namespace Portfolio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : Controller
    {
        private readonly IMediator _mediator;

        public LanguageController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<LanguageDTO>> GetLanguages() =>
            await _mediator.Send(new GetAllLanguageQuery());

        // GET: api/Language/5
        [HttpGet("{id}")]
        public async Task<LanguageDTO> GetLanguage(int id) =>
            await _mediator.Send(new GetLanguageQuery(id));

        // POST: api/Aptitude
        [HttpPost]
        [Authorize(Roles = CustomRoles.Administrator)]
        public async Task<ApiResponse<CreateLanguageDTO>> Post([FromBody] CreateLanguageDTO command) =>
            await _mediator.Send(command);


        [HttpPut()]
        [Authorize(Roles = CustomRoles.Administrator)]
        public async Task<ApiResponse<UpdateLanguageDTO>> Put([FromBody] UpdateLanguageDTO command) =>
            await _mediator.Send(command);

        // DELETE: api/Language
        [HttpDelete()]
        [Authorize(Roles = CustomRoles.Administrator)]
        public async Task<ApiResponse<DeleteLanguageDTO>> Delete([FromBody] DeleteLanguageDTO command) =>
            await _mediator.Send(command);
    }
}
