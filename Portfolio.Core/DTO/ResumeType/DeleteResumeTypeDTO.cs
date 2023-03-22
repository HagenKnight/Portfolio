using MediatR;
using Portfolio.Core.DTO.Base;
using Portfolio.Core.DTO.Resume;
using Portfolio.Core.Wrappers;

namespace Portfolio.Core.DTO.ResumeType
{
    public class DeleteResumeTypeDTO : CommandDTO, IRequest<ApiResponse<CreateResumeDTO>>
    {
    }
}
