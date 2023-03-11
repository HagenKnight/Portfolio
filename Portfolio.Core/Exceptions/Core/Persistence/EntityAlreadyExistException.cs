namespace Portfolio.Core.Exceptions
{
    public class EntityAlreadyExistException : Exception
    {
        public Type EntityType { get; set; }
        public object ValueInfo { get; set; }
        public EntityAlreadyExistException() : base() { }
        public EntityAlreadyExistException(Type entityType) : this(entityType, null, null) { }
        public EntityAlreadyExistException(Type entityType, object valueInfo) : this(entityType, valueInfo, null) { }
        public EntityAlreadyExistException(Type entityType, object valueInfo, Exception innerException) : base(
            valueInfo == null ? $"An entity already exists. Entity type: '{entityType.FullName}'." :
                                $"An entity with the value '{valueInfo}' already exists. Entity type: '{entityType.FullName}'.", innerException)
        { EntityType = entityType; ValueInfo = valueInfo; }
        public EntityAlreadyExistException(string message) : base(message) { }
        public EntityAlreadyExistException(string message, Exception innerException) : base(message, innerException) { }
    }
}
