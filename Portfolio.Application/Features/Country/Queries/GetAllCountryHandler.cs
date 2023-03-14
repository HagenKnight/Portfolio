using AutoMapper;
using MediatR;
using Portfolio.Core.Custom;
using Portfolio.Core.DTO;
using Portfolio.Core.Entities.Base;
using Portfolio.Core.Interfaces.Management;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Wrappers;
using System.Linq.Expressions;
using Utilities;

namespace Portfolio.Application.Features.Country
{
    public class GetAllCountryHandler : IRequestHandler<GetAllCountryQuery, IEnumerable<CountryDTO>>
    {

        private readonly IMapper _mapper;
        private readonly IUriService _uriService;
        private readonly IModelHelper _modelHelper;

        private readonly ICountryService _countryService;

        public GetAllCountryHandler(ICountryService countryService, IMapper mapper, IModelHelper modelHelper, IUriService uriService) =>
            (_mapper, _uriService, _modelHelper, _countryService) = (mapper, uriService, modelHelper, countryService);

        public async Task<IEnumerable<CountryDTO>> Handle(GetAllCountryQuery request, CancellationToken cancellationToken) =>
            await _countryService.GetCountries(cancellationToken);

        /*
         * Paged Handle 
        public async Task<ApiResponse<MetaData<ShapedEntityDTO>>> Handle(GetAllCountryQuery request, CancellationToken cancellationToken)
        {
            Expression<Func<Portfolio.Core.Entities.Country, bool>> _expressionLambda = null;
            var _validFilter = _mapper.Map<GetAllCountryParameter>(request);

            // Filtered fields security & limit to fields in view model
            if (!string.IsNullOrEmpty(_validFilter.Fields))
                _validFilter.Fields = _modelHelper.ValidateModelFields<CountryDTO>(_validFilter.Fields);

            // Default fields from view model
            if (string.IsNullOrEmpty(_validFilter.Fields))
                _validFilter.Fields = _modelHelper.GetModelFields<CountryDTO>();

            // Create search criteria, according to the entity of the Database context.
            if (!string.IsNullOrEmpty(_validFilter.Search))
            {
                var _newFilter = new WhereFilter()
                {
                    Condition = GroupOp.OR,
                    Rules = new List<WhereFilter>()
                    {
                        new WhereFilter { Field = "nameEs", Operator = WhereConditionsOp.Contains, Data = new[] { _validFilter.Search } },
                        new WhereFilter { Field = "nameEn", Operator = WhereConditionsOp.Contains, Data = new[] { _validFilter.Search } },
                        new WhereFilter { Field = "iso2", Operator = WhereConditionsOp.Contains, Data = new[] { _validFilter.Search } }
                    }
                };
                _expressionLambda = _newFilter.BuildExpressionLambda<Portfolio.Core.Entities.Country>(new BuildExpressionOptions() { ParseDatesAsUtc = false });
            }

            var _resultPaged = await _countryService.GetPagedCountries(_validFilter.PageNumber, _validFilter.PageSize, cancellationToken, _expressionLambda, _validFilter.Fields, _validFilter.OrderBy);
            return new ApiResponse<MetaData<ShapedEntityDTO>>(_mapper.Map<PagedList<ShapedEntityDTO>, MetaData<ShapedEntityDTO>>(new PagedList<ShapedEntityDTO>(_resultPaged, _validFilter.PageNumber, _validFilter.PageSize, _countryService.RowCount, _uriService, string.IsNullOrEmpty(request.Fields) ? "" : _validFilter.Fields, string.IsNullOrEmpty(request.OrderBy) ? "" : _validFilter.OrderBy, string.IsNullOrEmpty(request.Search) ? "" : _validFilter.Search, request.Route)));
        }
        */
    }
}
