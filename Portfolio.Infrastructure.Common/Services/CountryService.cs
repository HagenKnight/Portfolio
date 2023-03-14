using AutoMapper;
using Portfolio.Core.DTO;
using Portfolio.Core.DTO.Base;
using Portfolio.Core.Entities;
using Portfolio.Core.Entities.Base;
using Portfolio.Core.Interfaces.Base;
using Portfolio.Core.Interfaces.Management;
using Portfolio.Core.Interfaces.Repository;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Infrastructure.Persistence.Data;
using Portfolio.Infrastructure.Persistence.Services.Base;
using System.Linq.Expressions;

namespace Portfolio.Infrastructure.Common.Services
{
    public class CountryService : CRUDService<CountryDTO, CommandDTO, int,
                                  Country, ICountryRepository<PortfolioDbContext>, PortfolioDbContext>,
                                  ICountryService
    {
        private readonly IDataShapeHelper<CountryDTO> _dataShaperHelper;

        public CountryService(ICountryRepository<PortfolioDbContext> repository,
            IUnitOfWork<PortfolioDbContext> unitOfWork,
            IMapper mapper,
            IDataShapeHelper<CountryDTO> dataShapeHelper
            ) : base(repository,
                                   unitOfWork,
                                   mapper)
        {
            _dataShaperHelper = dataShapeHelper;
        }

        public async Task<IEnumerable<CountryDTO>> GetCountries(CancellationToken cancellationToken = default) =>
            await GetAllAsync(cancellationToken);

        public async Task<CountryDTO> FindCountry(int id, CancellationToken cancellationToken = default) =>
            await FindAsync(id, cancellationToken);


        //public async Task<IEnumerable<ShapedEntityDTO>> GetCountries(CancellationToken cancellationToken = default, string fields = null, string orderBy = null) =>
        //    await _dataShaperHelper.ShapeDataAsync(await GetAllAsync(cancellationToken, fields, orderBy), fields);


        //public async Task<IEnumerable<ShapedEntityDTO>> GetPagedCountries(int pageNumber, int pageSize, CancellationToken cancellationToken = default, Expression<Func<Country, bool>> predicate = null, string fields = null, string orderBy = null) =>
        //    (predicate == null) ? await _dataShaperHelper.ShapeDataAsync(await GetPagedAsync(pageNumber, pageSize, cancellationToken, fields, orderBy), fields) :
        //                await _dataShaperHelper.ShapeDataAsync(await GetPagedAsync(pageNumber, pageSize, predicate, cancellationToken, fields, orderBy), fields);


    }
}
