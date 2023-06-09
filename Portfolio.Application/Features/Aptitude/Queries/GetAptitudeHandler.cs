using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Application.Features.Aptitude.Queries
{
    public class GetAptitudeHandler : IRequestHandler<GetAptitudeQuery, AptitudeDTO>
    {
        private readonly IAptitudeService _aptitudeService;

        public GetAptitudeHandler(IAptitudeService aptitudeService) => _aptitudeService = aptitudeService;

        public async Task<AptitudeDTO> Handle(GetAptitudeQuery request, CancellationToken cancellationToken) =>
            await _aptitudeService.FindAptitude(request.Id, cancellationToken);
    }
}
