using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Wrappers;

namespace Portfolio.Application.Features.Aptitude.Commands.DeleteAptitude
{
    public class DeleteAptitudeCommandHandler : IRequestHandler<DeleteAptitudeDTO, ApiResponse<DeleteAptitudeDTO>>
    {
        private readonly IAptitudeService _aptitudeService;

        public DeleteAptitudeCommandHandler(IAptitudeService aptitudeService) =>
            _aptitudeService = aptitudeService;

        public async Task<ApiResponse<DeleteAptitudeDTO>> Handle(DeleteAptitudeDTO request, CancellationToken cancellationToken)
        {
            var entity = await _aptitudeService.DeleteAptitude(request, request.AutoSave, cancellationToken);
            return new ApiResponse<DeleteAptitudeDTO>(entity, $"The Aptitude with ID {entity.Id} was deleted successfully.");
        }
    }
}
