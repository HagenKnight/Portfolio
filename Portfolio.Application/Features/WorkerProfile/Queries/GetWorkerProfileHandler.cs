using MediatR;
using Portfolio.Core.DTO.WorkerProfile;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Application.Features.WorkerProfile
{
    public class GetWorkerProfileHandler : IRequestHandler<GetWorkerProfileQuery, WorkerProfileDTO>
    {
        private readonly IWorkerProfileService _workerProfile;

        public GetWorkerProfileHandler(IWorkerProfileService workerProfile) => _workerProfile = workerProfile;

        public async Task<WorkerProfileDTO> Handle(GetWorkerProfileQuery request, CancellationToken cancellationToken) =>
            await _workerProfile.FindWorkerProfile(request.Id, cancellationToken);

    }
}
