using Portfolio.Core.DTO;

namespace Portfolio.Core.Interfaces.Services
{
    public interface ILanguageService
    {
        Task<IEnumerable<LanguageDTO>> GetLanguages(CancellationToken cancellationToken = default);

        Task<LanguageDTO> FindLanguage(int id, CancellationToken cancellationToken = default);

        Task<CreateLanguageDTO> AddLanguage(CreateLanguageDTO objDTO, CancellationToken cancellationToken = default);

        Task<UpdateLanguageDTO> UpdateLanguage(UpdateLanguageDTO objDTO, CancellationToken cancellationToken = default);

        Task<DeleteLanguageDTO> DeleteLanguage(DeleteLanguageDTO objDTO, bool autoSave = true, CancellationToken cancellationToken = default);
    }
}
