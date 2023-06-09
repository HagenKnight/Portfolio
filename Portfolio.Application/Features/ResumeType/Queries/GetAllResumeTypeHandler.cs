using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Application.Features.ResumeType.Queries
{
    public class GetAllResumeTypeHandler : IRequestHandler<GetAllResumeTypeQuery, IEnumerable<ResumeTypeDTO>>
    {
        private readonly IResumeTypeService _resumeTypeService;

        public GetAllResumeTypeHandler(IResumeTypeService resumeTypeService)
        {
            _resumeTypeService = resumeTypeService;
        }

        public async Task<IEnumerable<ResumeTypeDTO>> Handle(GetAllResumeTypeQuery request, CancellationToken cancellationToken) =>
            await _resumeTypeService.GetResumeTypes(cancellationToken);

    }
}
