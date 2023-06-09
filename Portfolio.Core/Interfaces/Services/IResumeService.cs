using Portfolio.Core.DTO;
using Portfolio.Core.DTO.Resume;

namespace Portfolio.Core.Interfaces.Services
{
    public interface IResumeService
    {
        Task<IEnumerable<ResumeDTO>> GetResumes(int workerProfileId, CancellationToken cancellationToken = default);

        Task<ResumeDTO> FindResume(int id, CancellationToken cancellationToken = default);

        Task<ResumeDTO> FindResume(string email, CancellationToken cancellationToken = default);

        Task<CreateResumeDTO> AddResume(CreateResumeDTO objDTO, CancellationToken cancellationToken = default);

        Task<UpdateResumeDTO> UpdateResume(UpdateResumeDTO objDTO, CancellationToken cancellationToken = default);

        Task<DeleteResumeDTO> DeleteResume(DeleteResumeDTO objDTO, bool autoSave = true, CancellationToken cancellationToken = default);
    }
}
