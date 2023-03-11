using MediatR;
using Portfolio.Core.DTO;

namespace Portfolio.Application.Features.Entity
{
    public class GetAllEntityQuery : IRequest<IEnumerable<EntityDTO>> { }

    public class GetArtistQuery : IRequest<EntityDTO>
    {
        public int Id { get; set; }
        public GetArtistQuery(int id) => Id = id;
    }
}
