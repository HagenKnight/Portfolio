using Portfolio.Core.DTO.ResumeType;

namespace Portfolio.Core.Interfaces.Services
{
    public interface IResumeTypeService
    {
        Task<IEnumerable<ResumeTypeDTO>> GetResumeTypes(CancellationToken cancellationToken = default);
    }
}
