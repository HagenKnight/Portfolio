using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Parameters;

namespace Portfolio.Application.Features.Country
{

    public class GetAllCountryParameter : RequestParameter { }

    public class GetAllCountryQuery : IRequest<IEnumerable<CountryDTO>> { }

    public class GetCountryQuery : IRequest<CountryDTO>
    {
        public int Id { get; set; }
        public GetCountryQuery (int id) => Id = id;
    }

    //public class GetAllCountryQuery : IRequest<ApiResponse<MetaData<ShapedEntityDTO>>>
    //{
    //    public int PageNumber { get; set; }
    //    public int PageSize { get; set; }
    //    public string Fields { get; set; }
    //    public string Search { get; set; }
    //    public string OrderBy { get; set; }
    //    public string Route { get; set; }
    //}
}
