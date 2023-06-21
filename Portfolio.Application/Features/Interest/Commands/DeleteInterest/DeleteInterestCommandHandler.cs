using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Wrappers;

namespace Portfolio.Application.Features.Interest.Commands.DeleteInterest
{
    public class DeleteInterestCommandHandler : IRequestHandler<DeleteInterestDTO, ApiResponse<DeleteInterestDTO>>
    {
        private readonly IInterestService _interestService;

        public DeleteInterestCommandHandler(IInterestService interestService) =>
            _interestService = interestService;

        public async Task<ApiResponse<DeleteInterestDTO>> Handle(DeleteInterestDTO request, CancellationToken cancellationToken)
        {
            var entity = await _interestService.DeleteInterest(request, request.AutoSave, cancellationToken);
            return new ApiResponse<DeleteInterestDTO>(entity, $"The Interest with ID {entity.Id} was deleted successfully.");
        }
    }
}
