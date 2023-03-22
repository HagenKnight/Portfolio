using MediatR;
using Portfolio.Core.DTO.WorkerProfile;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Wrappers;

namespace Portfolio.Application.Features.WorkerProfile.Commands
{
    public class DeleteWorkerProfileCommandHandler : IRequestHandler<DeleteWorkerProfileDTO, ApiResponse<DeleteWorkerProfileDTO>>
    {
        private readonly IWorkerProfileService _workerProfilService;

        public DeleteWorkerProfileCommandHandler(IWorkerProfileService workerProfilService) => _workerProfilService = workerProfilService;

        public async Task<ApiResponse<DeleteWorkerProfileDTO>> Handle(DeleteWorkerProfileDTO request, CancellationToken cancellationToken)
        {
            var entity = await _workerProfilService.DeleteWorkerProfile(request, request.AutoSave, cancellationToken);
            return new ApiResponse<DeleteWorkerProfileDTO>(entity, $"The Worker Profile with ID {entity.Id} was deleted successfully.");
        }
    }
}
