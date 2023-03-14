namespace Portfolio.Core.Interfaces.Management
{
    public interface IUpdateEntity<TKey>
    {
        public DateTime? LastModifiedDate { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
