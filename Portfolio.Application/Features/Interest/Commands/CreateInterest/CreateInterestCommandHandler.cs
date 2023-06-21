using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Wrappers;

namespace Portfolio.Application.Features.Interest.Commands.CreateInterest
{
    public class CreateInterestCommandHandler : IRequestHandler<CreateInterestDTO, ApiResponse<CreateInterestDTO>>
    {
        private readonly IInterestService _interestService;

        public CreateInterestCommandHandler(IInterestService interestService) => _interestService = interestService;

        public async Task<ApiResponse<CreateInterestDTO>> Handle(CreateInterestDTO request, CancellationToken cancellationToken)
        {
            var entity = await _interestService.AddInterest(request, cancellationToken);
            return new ApiResponse<CreateInterestDTO>(entity, $"The Interest with name {entity.Name} was created successfully.");
        }
    }
}
