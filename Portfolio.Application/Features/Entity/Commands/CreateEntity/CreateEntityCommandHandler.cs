using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Wrappers;

namespace Portfolio.Application.Features.Artist.Commands
{
    public class CreateEntityCommandHandler : IRequestHandler<CreateEntityDTO, ApiResponse<CreateEntityDTO>>
    {
        private readonly IEntityService _entityService;
        public CreateEntityCommandHandler(IEntityService entityService) => _entityService = entityService;

        public Task<ApiResponse<CreateEntityDTO>> Handle(CreateEntityDTO request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
