using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Application.Features.Aptitude.Queries
{
    public class GetAllAptitudeHandler : IRequestHandler<GetAllAptitudeQuery, IEnumerable<AptitudeDTO>>
    {
        private readonly IAptitudeService _aptitudeService;

        public GetAllAptitudeHandler(IAptitudeService aptitudeService) =>
            _aptitudeService = aptitudeService;


        public async Task<IEnumerable<AptitudeDTO>> Handle(GetAllAptitudeQuery request, CancellationToken cancellationToken) =>
            await _aptitudeService.GetAptitudes(cancellationToken);
    }
}
