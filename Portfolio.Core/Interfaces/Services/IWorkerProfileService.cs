using Portfolio.Core.DTO.WorkerProfile;

namespace Portfolio.Core.Interfaces.Services
{
    public interface IWorkerProfileService
    {
        Task<IEnumerable<WorkerProfileDTO>> GetWorkerProfiles(CancellationToken cancellationToken = default);

        Task<WorkerProfileDTO> FindWorkerProfile(int id, CancellationToken cancellationToken = default);

        Task<WorkerProfileDTO> FindWorkerProfile(string email, CancellationToken cancellationToken = default);

        Task<CreateWorkerProfileDTO> AddWorkerProfile(CreateWorkerProfileDTO objDTO, CancellationToken cancellationToken = default);

        Task<UpdateWorkerProfileDTO> UpdateWorkerProfile(UpdateWorkerProfileDTO objDTO, CancellationToken cancellationToken = default);

        Task<DeleteWorkerProfileDTO> DeleteWorkerProfile(DeleteWorkerProfileDTO objDTO, bool autoSave = true, CancellationToken cancellationToken = default);
    }
}
