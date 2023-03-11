using Portfolio.Core.Entities.Base;

namespace Portfolio.Core.Interfaces.Management
{
    public interface IDataShapeHelper<T>
    {
        ShapedEntityDTO ShapeData(T entity, string fieldsString);
        IEnumerable<ShapedEntityDTO> ShapeData(IEnumerable<T> entities, string fieldsString);
        Task<IEnumerable<ShapedEntityDTO>> ShapeDataAsync(IEnumerable<T> entities, string fieldsString);
    }
}
