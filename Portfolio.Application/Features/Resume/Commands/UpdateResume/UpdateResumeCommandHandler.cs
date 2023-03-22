using MediatR;
using Portfolio.Core.DTO.Resume;
using Portfolio.Core.DTO.WorkerProfile;
using Portfolio.Core.Entities;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Wrappers;

namespace Portfolio.Application.Features.Resume.Commands.UpdateResume
{
    public class UpdateResumeCommandHandler : IRequestHandler<UpdateResumeDTO, ApiResponse<UpdateResumeDTO>>
    {
        private readonly IResumeService _resumeService;

        public UpdateResumeCommandHandler(IResumeService resumeService) => _resumeService = resumeService;

        public async Task<ApiResponse<UpdateResumeDTO>> Handle(UpdateResumeDTO request, CancellationToken cancellationToken)
        {
            string message = string.Empty;
            var entity = await _resumeService.UpdateResume(request, cancellationToken);

            message = (entity.ResumeTypeId == 1) ? ResumeTypeEnum.WorkExperience.ToString() : ResumeTypeEnum.Education.ToString();

            return new ApiResponse<UpdateResumeDTO>(entity, $"The {entity.Title} {message} in {entity.InstitutionName} was updated successfully.");
        }
    }
}
