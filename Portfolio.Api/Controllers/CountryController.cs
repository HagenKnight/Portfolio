using MediatR;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Portfolio.Application.Features.Country;
using Portfolio.Core.Custom;
using Portfolio.Core.DTO;
using Portfolio.Core.Entities.Base;
using Portfolio.Core.Wrappers;

namespace Portfolio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CountryController(IMediator mediator) => _mediator = mediator;

        // GET: api/Countries
        //[HttpGet]
        //public async Task<ApiResponse<MetaData<ShapedEntityDTO>>> GetCountries([FromQuery] GetAllCountryParameter filter)
        //{
        //    var _response = await _mediator.Send(new GetAllCountryQuery() { PageSize = filter.PageSize, PageNumber = filter.PageNumber, Fields = filter.Fields, OrderBy = filter.OrderBy, Search = filter.Search, Route = Request.Path.Value });
        //    Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject((_response.Data.Paging.CurrentPage, _response.Data.Paging.PageSize, _response.Data.Paging.TotalCount)));
        //    return _response;
        //}

        [HttpGet]
        public async Task<IEnumerable<CountryDTO>> GetCountries() =>
            await _mediator.Send(new GetAllCountryQuery());


        // GET: api/Countries/5
        [HttpGet("{id}")]
        public async Task<CountryDTO> GetCountry(int id) =>
            await _mediator.Send(new GetCountryQuery(id));

    }

}
