using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Application.Features.Language.Queries
{
    public class GetAllLanguageHandler : IRequestHandler<GetAllLanguageQuery, IEnumerable<LanguageDTO>>
    {
        private readonly ILanguageService _languageService;

        public GetAllLanguageHandler(ILanguageService languageService) =>
            _languageService = languageService;


        public async Task<IEnumerable<LanguageDTO>> Handle(GetAllLanguageQuery request, CancellationToken cancellationToken) =>
            await _languageService.GetLanguages(cancellationToken);
    }
}
