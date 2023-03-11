using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Application.Features.Entity
{
    public class GetAllEntityHandler : IRequestHandler<GetAllEntityQuery, IEnumerable<EntityDTO>>
    {
        private readonly IEntityService _entityService;

        public GetAllEntityHandler(IEntityService entityService) => _entityService = entityService;

        public Task<IEnumerable<EntityDTO>> Handle(GetAllEntityQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
