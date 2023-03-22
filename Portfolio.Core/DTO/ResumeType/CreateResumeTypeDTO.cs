using MediatR;
using Portfolio.Core.DTO.Base;
using Portfolio.Core.DTO.Resume;
using Portfolio.Core.Wrappers;

namespace Portfolio.Core.DTO.ResumeType
{
    public class CreateResumeTypeDTO : CommandDTO, IRequest<ApiResponse<CreateResumeDTO>>
    {
    }
}
