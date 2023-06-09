using Portfolio.Core.DTO;

namespace Portfolio.Core.Interfaces.Services
{
    public interface IResumeTypeService
    {
        Task<IEnumerable<ResumeTypeDTO>> GetResumeTypes(CancellationToken cancellationToken = default);
    }
}
