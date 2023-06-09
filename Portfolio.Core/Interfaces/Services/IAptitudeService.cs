using Portfolio.Core.DTO;

namespace Portfolio.Core.Interfaces.Services
{
    public interface IAptitudeService
    {
        Task<IEnumerable<AptitudeDTO>> GetAptitudes(CancellationToken cancellationToken = default);

        Task<AptitudeDTO> FindAptitude(int id, CancellationToken cancellationToken = default);

        Task<CreateAptitudeDTO> AddAptitude(CreateAptitudeDTO objDTO, CancellationToken cancellationToken = default);

        Task<UpdateAptitudeDTO> UpdateAptitude(UpdateAptitudeDTO objDTO, CancellationToken cancellationToken = default);

        Task<DeleteAptitudeDTO> DeleteAptitude(DeleteAptitudeDTO objDTO, bool autoSave = true, CancellationToken cancellationToken = default);
    }
}
