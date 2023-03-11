namespace Portfolio.Core.Exceptions
{
    public class PageRowIndexNotFound : Exception
    {
        public object ValueInfo { get; set; }
        public PageRowIndexNotFound() : base() { }
        public PageRowIndexNotFound(object valueInfo) : base($"The page number '{valueInfo}' does not exist within the data collection per page.") { ValueInfo = valueInfo; }
        public PageRowIndexNotFound(string message) : base(message) { }
        public PageRowIndexNotFound(string message, Exception innerException) : base(message, innerException) { }
    }
}
