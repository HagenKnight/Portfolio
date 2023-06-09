using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Wrappers;

namespace Portfolio.Application.Features.Aptitude.Commands.UpdateAptitude
{
    public class UpdateAptitudeCommandHandler : IRequestHandler<UpdateAptitudeDTO, ApiResponse<UpdateAptitudeDTO>>
    {
        private readonly IAptitudeService _aptitudeService;

        public UpdateAptitudeCommandHandler(IAptitudeService aptitudeService) =>
            _aptitudeService = aptitudeService;

        public async Task<ApiResponse<UpdateAptitudeDTO>> Handle(UpdateAptitudeDTO request, CancellationToken cancellationToken)
        {
            var entity = await _aptitudeService.UpdateAptitude(request, cancellationToken);
            return new ApiResponse<UpdateAptitudeDTO>(entity, $"The Aptitude with name {entity.Name} was updated successfully.");
        }
    }
}
