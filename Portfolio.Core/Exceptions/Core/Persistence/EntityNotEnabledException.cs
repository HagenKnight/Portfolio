namespace Portfolio.Core.Exceptions
{
    public class EntityNotEnabledException : Exception
    {
        public Type EntityType { get; set; }
        public object Id { get; set; }
        public EntityNotEnabledException() : base() { }
        public EntityNotEnabledException(Type entityType) : this(entityType, null, null) { }
        public EntityNotEnabledException(Type entityType, object id) : this(entityType, id, null) { }
        public EntityNotEnabledException(Type entityType, object id, Exception innerException) : base(
            id == null ? $"Entity not enabled. Entity type: '{entityType.FullName}'" :
                            $"Entity not enabled. Entity type: '{entityType.FullName}', id: '{id}'", innerException)
        { EntityType = entityType; Id = id; }
        public EntityNotEnabledException(string message) : base(message) { }
        public EntityNotEnabledException(string message, Exception innerException) : base(message, innerException) { }
    }
}
