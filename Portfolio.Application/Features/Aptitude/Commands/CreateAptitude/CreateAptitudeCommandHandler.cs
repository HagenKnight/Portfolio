using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Wrappers;

namespace Portfolio.Application.Features.Aptitude.Commands.CreateAptitude
{
    public class CreateAptitudeCommandHandler : IRequestHandler<CreateAptitudeDTO, ApiResponse<CreateAptitudeDTO>>
    {
        private readonly IAptitudeService _aptitudeService;

        public CreateAptitudeCommandHandler(IAptitudeService aptitudeService) => _aptitudeService = aptitudeService;

        public async Task<ApiResponse<CreateAptitudeDTO>> Handle(CreateAptitudeDTO request, CancellationToken cancellationToken)
        {
            var entity = await _aptitudeService.AddAptitude(request, cancellationToken);
            return new ApiResponse<CreateAptitudeDTO>(entity, $"The Aptitude with name {entity.Name} was created successfully.");
        }
    }
}
