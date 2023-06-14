using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Wrappers;

namespace Portfolio.Application.Features.Language.Commands.UpdateLanguage
{
    public class UpdateLanguageCommandHandler : IRequestHandler<UpdateLanguageDTO, ApiResponse<UpdateLanguageDTO>>
    {
        private readonly ILanguageService _languageService;

        public UpdateLanguageCommandHandler(ILanguageService languageService) =>
            _languageService = languageService;

        public async Task<ApiResponse<UpdateLanguageDTO>> Handle(UpdateLanguageDTO request, CancellationToken cancellationToken)
        {
            var entity = await _languageService.UpdateLanguage(request, cancellationToken);
            return new ApiResponse<UpdateLanguageDTO>(entity, $"The Language with name {entity.NameEn} was updated successfully.");
        }
    }
}
