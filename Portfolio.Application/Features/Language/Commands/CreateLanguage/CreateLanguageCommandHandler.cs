using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Wrappers;

namespace Portfolio.Application.Features.Language.Commands.CreateLanguage
{
    public class CreateLanguageCommandHandler : IRequestHandler<CreateLanguageDTO, ApiResponse<CreateLanguageDTO>>
    {
        private readonly ILanguageService _languageService;

        public CreateLanguageCommandHandler(ILanguageService languageService) => _languageService = languageService;

        public async Task<ApiResponse<CreateLanguageDTO>> Handle(CreateLanguageDTO request, CancellationToken cancellationToken)
        {
            var entity = await _languageService.AddLanguage(request, cancellationToken);
            return new ApiResponse<CreateLanguageDTO>(entity, $"The Language with name {entity.NameEn} was created successfully.");
        }
    }
}
