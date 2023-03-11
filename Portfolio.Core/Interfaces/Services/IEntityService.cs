using Portfolio.Core.DTO;

namespace Portfolio.Core.Interfaces.Services
{
    public interface IEntityService
    {
        Task<IEnumerable<EntityDTO>> GetEntities(CancellationToken cancellationToken = default);

        Task<EntityDTO> FindEntity(int id, CancellationToken cancellationToken = default);

        //Task<EntityDTO> FilterArtist(Expression<Func<Artist, bool>> predicate, CancellationToken cancellationToken = default);
        Task<CreateEntityDTO> AddEntity(CreateEntityDTO objDTO, CancellationToken cancellationToken = default);
        Task<UpdateEntityDTO> UpdateEntity(UpdateEntityDTO objDTO, CancellationToken cancellationToken = default);
        Task<DeleteEntityDTO> DeleteEntity(DeleteEntityDTO objDTO, bool autoSave = true, CancellationToken cancellationToken = default);

    }
}
