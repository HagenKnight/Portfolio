using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Application.Features.Resume.Queries
{
    public class GetAllResumeHandler : IRequestHandler<GetAllResumeQuery, IEnumerable<ResumeDTO>>
    {
        private readonly IResumeService _resumeService;

        public GetAllResumeHandler(IResumeService resumeService) => _resumeService = resumeService;

        public async Task<IEnumerable<ResumeDTO>> Handle(GetAllResumeQuery request, CancellationToken cancellationToken)
        {
            var listOfResumes = await _resumeService.GetResumes(request.WorkerProfileId, cancellationToken);

            var lists = listOfResumes.OrderBy(d => d.ResumeTypeId).ThenByDescending(d => d.StartDate);

            return lists.AsQueryable();
        }
    }
}
