using MediatR;
using Portfolio.Core.DTO;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Application.Features.Country
{
    public class GetCountryHandler : IRequestHandler<GetCountryQuery, CountryDTO>
    {
        private readonly ICountryService _countryService;

        public GetCountryHandler(ICountryService countryService) => _countryService = countryService;

        public async Task<CountryDTO> Handle(GetCountryQuery request, CancellationToken cancellationToken) =>
            await _countryService.FindCountry(request.Id, cancellationToken);

    }
}
