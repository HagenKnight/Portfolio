using MediatR;
using Portfolio.Core.DTO.Resume;
using Portfolio.Core.Parameters;

namespace Portfolio.Application.Features.Resume.Queries
{
    public class GetResumeQuery : IRequest<ResumeDTO>
    {
        public int Id { get; set; }
        public GetResumeQuery(int id) => Id = id;
    }

    public class GetAllResumeQuery : IRequest<IEnumerable<ResumeDTO>>
    {
        public int WorkerProfileId { get; set; }

        public GetAllResumeQuery(int workerProfileId) => WorkerProfileId = workerProfileId;
    }

    public class GetAllResumeParameter : RequestParameter { }
}
