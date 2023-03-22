using MediatR;
using Portfolio.Core.DTO.Resume;
using Portfolio.Core.DTO.WorkerProfile;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Wrappers;

namespace Portfolio.Application.Features.Resume.Commands.DeleteResume
{
    public class DeleteResumeCommandHandler : IRequestHandler<DeleteResumeDTO, ApiResponse<DeleteResumeDTO>>
    {
        private readonly IResumeService _resumeService;

        public DeleteResumeCommandHandler(IResumeService resumeService) => _resumeService = resumeService;

        public async Task<ApiResponse<DeleteResumeDTO>> Handle(DeleteResumeDTO request, CancellationToken cancellationToken)
        {
            var entity = await _resumeService.DeleteResume(request, request.AutoSave, cancellationToken);
            return new ApiResponse<DeleteResumeDTO>(entity, $"The Resume item with ID {entity.Id} was deleted successfully.");
        }
    }
}
