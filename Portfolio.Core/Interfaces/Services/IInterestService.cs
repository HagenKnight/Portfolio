using Portfolio.Core.DTO;

namespace Portfolio.Core.Interfaces.Services
{
    public interface IInterestService
    {
        Task<IEnumerable<InterestDTO>> GetInterests(CancellationToken cancellationToken = default);

        Task<InterestDTO> FindInterest(int id, CancellationToken cancellationToken = default);

        Task<CreateInterestDTO> AddInterest(CreateInterestDTO objDTO, CancellationToken cancellationToken = default);

        Task<UpdateInterestDTO> UpdateInterest(UpdateInterestDTO objDTO, CancellationToken cancellationToken = default);

        Task<DeleteInterestDTO> DeleteInterest(DeleteInterestDTO objDTO, bool autoSave = true, CancellationToken cancellationToken = default);
    }
}
