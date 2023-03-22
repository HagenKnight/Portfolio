using MediatR;
using Portfolio.Core.DTO.WorkerProfile;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Wrappers;

namespace Portfolio.Application.Features.WorkerProfile.Commands.UpdateWorkerProfile
{
    public class UpdateWorkerProfileCommandHandler : IRequestHandler<UpdateWorkerProfileDTO, ApiResponse<UpdateWorkerProfileDTO>>
    {
        private readonly IWorkerProfileService _workerProfileService;

        public UpdateWorkerProfileCommandHandler(IWorkerProfileService workerProfileService) => _workerProfileService = workerProfileService;

        public async Task<ApiResponse<UpdateWorkerProfileDTO>> Handle(UpdateWorkerProfileDTO request, CancellationToken cancellationToken)
        {
            var entity = await _workerProfileService.UpdateWorkerProfile(request, cancellationToken);
            return new ApiResponse<UpdateWorkerProfileDTO>(entity, $"The WorkerProfile with name {entity.FirstName} {entity.LastName} was updated successfully.");
        }
    }
}
