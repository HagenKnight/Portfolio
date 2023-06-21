using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Wrappers;

namespace Portfolio.Application.Features.Interest.Commands.UpdateInterest
{
    public class UpdateInterestCommandHandler : IRequestHandler<UpdateInterestDTO, ApiResponse<UpdateInterestDTO>>
    {
        private readonly IInterestService _interestService;

        public UpdateInterestCommandHandler(IInterestService interestService) =>
            _interestService = interestService;

        public async Task<ApiResponse<UpdateInterestDTO>> Handle(UpdateInterestDTO request, CancellationToken cancellationToken)
        {
            var entity = await _interestService.UpdateInterest(request, cancellationToken);
            return new ApiResponse<UpdateInterestDTO>(entity, $"The Interest with name {entity.Name} was updated successfully.");
        }
    }
}
