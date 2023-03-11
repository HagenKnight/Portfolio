using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Wrappers;

namespace Portfolio.Application.Features.Entity
{
    public class UpdateEntityCommandHandler : IRequestHandler<UpdateEntityDTO, ApiResponse<UpdateEntityDTO>>
    {
        private readonly IEntityService _entityService;
        public UpdateEntityCommandHandler(IEntityService entityService) => _entityService = entityService;

        public Task<ApiResponse<UpdateEntityDTO>> Handle(UpdateEntityDTO request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
