namespace Portfolio.Core.Interfaces.Management
{
    public interface IAddEntity<TKey>
    {
        public TKey Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }

    }
}
