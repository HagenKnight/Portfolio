using MediatR;
using Portfolio.Core.DTO.Resume;
using Portfolio.Core.Entities;
using Portfolio.Core.Exceptions;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Wrappers;

namespace Portfolio.Application.Features.Resume.Commands.CreateResume
{
    public class CreateResumeCommandHandler : IRequestHandler<CreateResumeDTO, ApiResponse<CreateResumeDTO>>
    {
        private readonly IResumeService _resumeService;

        public CreateResumeCommandHandler(IResumeService resumeService) => _resumeService = resumeService;

        public async Task<ApiResponse<CreateResumeDTO>> Handle(CreateResumeDTO request, CancellationToken cancellationToken)
        {
            string message = string.Empty;

            int compareDates = DateTime.Compare(request.FinishDate, request.StartDate.Date);
            if (compareDates > 0)
            {
                var entity = await _resumeService.AddResume(request, cancellationToken);
                message = (entity.ResumeTypeId == 1) ? ResumeTypeEnum.WorkExperience.ToString() : ResumeTypeEnum.Education.ToString();
                return new ApiResponse<CreateResumeDTO>(entity, $"The {entity.Title} {message} in {entity.InstitutionName} was created successfully.");
            }
            else
            {
                throw new BusinessException(null, $"Las fechas introducidas son incorrectas");
            }
        }
    }
}
