using MediatR;
using Portfolio.Core.DTO.WorkerProfile;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Wrappers;

namespace Portfolio.Application.Features.WorkerProfile.Commands
{
    public class CreateWorkerProfileCommandHandler : IRequestHandler<CreateWorkerProfileDTO, ApiResponse<CreateWorkerProfileDTO>>
    {
        private readonly IWorkerProfileService _workerProfilService;

        public CreateWorkerProfileCommandHandler(IWorkerProfileService workerProfilService) => _workerProfilService = workerProfilService;

        public async Task<ApiResponse<CreateWorkerProfileDTO>> Handle(CreateWorkerProfileDTO request, CancellationToken cancellationToken)
        {
            var entity = await _workerProfilService.AddWorkerProfile(request, cancellationToken);
            return new ApiResponse<CreateWorkerProfileDTO>(entity, $"The Worker Profile for {entity.FirstName} {entity.LastName} was created successfully." );
        }
    }
}
