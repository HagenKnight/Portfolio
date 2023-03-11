namespace Portfolio.Core.Exceptions
{
    public class EntityDuplicatedException : Exception
    {
        public Type EntityType { get; set; }
        public object Id { get; set; }
        public EntityDuplicatedException() : base() { }
        public EntityDuplicatedException(Type entityType) : this(entityType, null, null) { }
        public EntityDuplicatedException(Type entityType, string value, Exception innerException) : base(
            $"There is more than one entity '{entityType.FullName}', with the data of the selected or searched entity.", innerException)
        { EntityType = entityType; }
        public EntityDuplicatedException(string message) : base(message) { }
        public EntityDuplicatedException(string message, Exception innerException) : base(message, innerException) { }
    }
}
