using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Parameters;

namespace Portfolio.Application.Features.Language.Queries
{
    public class GetAllLanguageParameter : RequestParameter { }

    public class GetAllLanguageQuery : IRequest<IEnumerable<LanguageDTO>> { }

    public class GetLanguageQuery : IRequest<LanguageDTO>
    {
        public int Id { get; set; }
        public GetLanguageQuery(int id) => Id = id;
    }
}
