namespace Portfolio.Core.Interfaces.Management
{
    public interface IDeleteEntity<TKey> : IAddEntity<TKey>
    {
        public bool IsDeleted { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string? DeletedBy { get; set; }
    }
}
