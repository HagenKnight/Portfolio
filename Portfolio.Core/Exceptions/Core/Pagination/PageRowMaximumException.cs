namespace Portfolio.Core.Exceptions
{
    public class PageRowMaximumException : Exception
    {
        public object ValueInfo { get; set; }
        public PageRowMaximumException() : base() { }
        public PageRowMaximumException(object valueInfo) : base($"The value {valueInfo} is higher than the maximum number of records per page.") { ValueInfo = valueInfo; }
        public PageRowMaximumException(string message) : base(message) { }
        public PageRowMaximumException(string message, Exception innerException) : base(message, innerException) { }
    }
}
