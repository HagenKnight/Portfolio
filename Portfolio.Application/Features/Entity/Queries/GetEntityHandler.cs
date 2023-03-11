using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Application.Features.Entity
{
    public class GetEntityHandler : IRequestHandler<GetArtistQuery, EntityDTO>
    {
        private readonly IEntityService _entityService;
        public GetEntityHandler(IEntityService entityService) => _entityService = entityService;

        public Task<EntityDTO> Handle(GetArtistQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
