using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Application.Features.Interest.Queries
{
    public class GetAllInterestHandler : IRequestHandler<GetAllInterestQuery, IEnumerable<InterestDTO>>
    {
        private readonly IInterestService _interestService;

        public GetAllInterestHandler(IInterestService interestService) =>
            _interestService = interestService;

        public async Task<IEnumerable<InterestDTO>> Handle(GetAllInterestQuery request, CancellationToken cancellationToken) =>
            await _interestService.GetInterests(cancellationToken);
    }
}
