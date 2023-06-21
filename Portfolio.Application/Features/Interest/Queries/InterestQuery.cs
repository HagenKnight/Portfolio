using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Parameters;

namespace Portfolio.Application.Features.Interest.Queries
{
    public class GetAllInterestParameter : RequestParameter { }

    public class GetAllInterestQuery : IRequest<IEnumerable<InterestDTO>> { }

    public class GetInterestQuery : IRequest<InterestDTO>
    {
        public int Id { get; set; }
        public GetInterestQuery(int id) => Id = id;
    }
}
