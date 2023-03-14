using MediatR;
using Portfolio.Core.Custom;
using Portfolio.Core.DTO;
using Portfolio.Core.Entities.Base;
using Portfolio.Core.Parameters;
using Portfolio.Core.Wrappers;

namespace Portfolio.Application.Features.Country
{

    public class GetAllCountryParameter : RequestParameter { }

    public class GetAllCountryQuery : IRequest<IEnumerable<CountryDTO>> { }

    //public class GetAllCountryQuery : IRequest<ApiResponse<MetaData<ShapedEntityDTO>>>
    //{
    //    public int PageNumber { get; set; }
    //    public int PageSize { get; set; }
    //    public string Fields { get; set; }
    //    public string Search { get; set; }
    //    public string OrderBy { get; set; }
    //    public string Route { get; set; }
    //}

    public class GetCountryQuery : IRequest<CountryDTO>
    {
        public int Id { get; set; }
        public GetCountryQuery(int id) => Id = id;
    }

}
