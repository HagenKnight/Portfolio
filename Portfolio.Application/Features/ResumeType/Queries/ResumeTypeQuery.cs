using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Parameters;

namespace Portfolio.Application.Features.ResumeType.Queries
{
    public class GetResumeTypeQuery : IRequest<ResumeTypeDTO>
    {
        public int Id { get; set; }
        public GetResumeTypeQuery(int id) => Id = id;
    }

    public class GetAllResumeTypeQuery : IRequest<IEnumerable<ResumeTypeDTO>> { }

    public class GetAllResumeTypeParameter : RequestParameter { }
}
