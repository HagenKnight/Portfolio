using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Wrappers;

namespace Portfolio.Application.Features.Entity.Commands
{
    public class DeleteEntityCommandHandler : IRequestHandler<DeleteEntityDTO, ApiResponse<DeleteEntityDTO>>
    {
        private readonly IEntityService _entityService;

        public DeleteEntityCommandHandler(IEntityService entityService) =>
            _entityService = entityService;

        public Task<ApiResponse<DeleteEntityDTO>> Handle(DeleteEntityDTO request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
