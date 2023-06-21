using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Application.Features.Interest.Queries
{
    public class GetInterestHandler : IRequestHandler<GetInterestQuery, InterestDTO>
    {
        private readonly IInterestService _interestService;

        public GetInterestHandler(IInterestService interestService) => _interestService = interestService;

        public async Task<InterestDTO> Handle(GetInterestQuery request, CancellationToken cancellationToken) =>
            await _interestService.FindInterest(request.Id, cancellationToken);
    }
}
