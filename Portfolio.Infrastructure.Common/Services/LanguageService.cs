using AutoMapper;
using Portfolio.Core.DTO;
using Portfolio.Core.DTO.Base;
using Portfolio.Core.Entities;
using Portfolio.Core.Exceptions;
using Portfolio.Core.Interfaces.Base;
using Portfolio.Core.Interfaces.Management;
using Portfolio.Core.Interfaces.Repository;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Infrastructure.Persistence.Data;
using Portfolio.Infrastructure.Persistence.Services.Base;

namespace Portfolio.Infrastructure.Common.Services
{
    public class LanguageService : CRUDService<LanguageDTO, CommandDTO, int,
                                Language, ILanguageRepository<PortfolioDbContext>, PortfolioDbContext>,
                                ILanguageService
    {
        public LanguageService(ILanguageRepository<PortfolioDbContext> repository,
            IUnitOfWork<PortfolioDbContext> unitOfWork,
            IMapper mapper,
            IDataShapeHelper<LanguageDTO> dataShapeHelper
            ) : base(repository, unitOfWork, mapper)
        {
        }

        public async Task<IEnumerable<LanguageDTO>> GetLanguages(CancellationToken cancellationToken = default) =>
            await GetAllAsync(cancellationToken);

        public async Task<LanguageDTO> FindLanguage(int id, CancellationToken cancellationToken = default) =>
            await FindAsync(id, cancellationToken);

        public async Task<CreateLanguageDTO> AddLanguage(CreateLanguageDTO objDTO, CancellationToken cancellationToken = default)
        {
            var ifExists = await FilterAsync(u => u.NameEn == objDTO.NameEn &&
                                  u.IsDeleted == false);
            if (ifExists.Count() > 0)
                throw new EntityAlreadyExistException(objDTO.GetType(), $"{objDTO.NameEn}");
            else
                return Mapper.Map<CreateLanguageDTO>(await InsertAsync(objDTO, cancellationToken));
        }
        public async Task<UpdateLanguageDTO> UpdateLanguage(UpdateLanguageDTO objDTO, CancellationToken cancellationToken = default)
        {
            var ifExistsById = await GetSingleAsync(u => u.Id == objDTO.Id &&
                                    u.IsDeleted == false);
            if (ifExistsById == null)
                throw new EntityNotFoundException(objDTO.GetType(), objDTO.Id);
            else
            {
                var ifExistsByName = await GetSingleAsync(u => u.NameEn == objDTO.NameEn &&
                    u.IsDeleted == false,
                    null, cancellationToken);
                if (ifExistsByName != null)
                {
                    if (ifExistsByName.Id == objDTO.Id)
                        return Mapper.Map<UpdateLanguageDTO>(await UpdateAsync(objDTO, cancellationToken));
                    else
                        throw new EntityDuplicatedException($"The Language with '{objDTO.NameEn}' name  has already taken.");
                }
                else
                    return Mapper.Map<UpdateLanguageDTO>(await UpdateAsync(objDTO, cancellationToken));
            }
        }
        public async Task<DeleteLanguageDTO> DeleteLanguage(DeleteLanguageDTO objDTO, bool autoSave = true, CancellationToken cancellationToken = default)
        {
            var ifExists = await FilterAsync(u => u.Id == objDTO.Id && u.IsDeleted == false);
            if (ifExists == null || ifExists.Count() == 0)
                if (ifExists == null || ifExists.Count() == 0)
                    throw new EntityNotFoundException(objDTO.Id.ToString());

            return Mapper.Map<DeleteLanguageDTO>(await DeleteAsync(objDTO, autoSave, cancellationToken));
        }

    }

}
