using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Application.Features.Language.Queries
{
    public class GetLanguageHandler : IRequestHandler<GetLanguageQuery, LanguageDTO>
    {
        private readonly ILanguageService _languageService;

        public GetLanguageHandler(ILanguageService languageService) => _languageService = languageService;

        public async Task<LanguageDTO> Handle(GetLanguageQuery request, CancellationToken cancellationToken) =>
            await _languageService.FindLanguage(request.Id, cancellationToken);
    }
}
