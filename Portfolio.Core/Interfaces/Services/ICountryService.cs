using Portfolio.Core.DTO;

namespace Portfolio.Core.Interfaces.Services
{
    public interface ICountryService
    {
        public int RowCount { get; }

        Task<IEnumerable<CountryDTO>> GetCountries(CancellationToken cancellationToken = default);

        //Task<IEnumerable<ShapedEntityDTO>> GetCountries(CancellationToken cancellationToken = default, string fields = null, string orderBy = null);
        //Task<IEnumerable<ShapedEntityDTO>> GetPagedCountries(int pageNumber, int pageSize, CancellationToken cancellationToken = default, Expression<Func<Country, bool>> predicate = null, string fields = null, string orderBy = null);

        Task<CountryDTO> FindCountry(int id, CancellationToken cancellationToken = default);
    }
}
