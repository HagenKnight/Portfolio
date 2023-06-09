using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Wrappers;

namespace Portfolio.Application.Features.Language.Commands.DeleteLanguage
{
    public class DeleteLanguageCommandHandler : IRequestHandler<DeleteLanguageDTO, ApiResponse<DeleteLanguageDTO>>
    {
        private readonly ILanguageService _languageService;

        public DeleteLanguageCommandHandler(ILanguageService languageService) =>
            _languageService = languageService;

        public async Task<ApiResponse<DeleteLanguageDTO>> Handle(DeleteLanguageDTO request, CancellationToken cancellationToken)
        {
            var entity = await _languageService.DeleteLanguage(request, request.AutoSave, cancellationToken);
            return new ApiResponse<DeleteLanguageDTO>(entity, $"The Language with ID {entity.Id} was deleted successfully.");
        }
    }
}
