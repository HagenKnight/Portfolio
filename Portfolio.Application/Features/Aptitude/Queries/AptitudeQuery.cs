using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Parameters;

namespace Portfolio.Application.Features.Aptitude.Queries
{
    public class GetAllAptitudeParameter : RequestParameter { }

    public class GetAllAptitudeQuery : IRequest<IEnumerable<AptitudeDTO>> { }

    public class GetAptitudeQuery : IRequest<AptitudeDTO>
    {
        public int Id { get; set; }
        public GetAptitudeQuery(int id) => Id = id;
    }
}
