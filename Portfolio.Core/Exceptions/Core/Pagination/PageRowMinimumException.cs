namespace Portfolio.Core.Exceptions
{
    public class PageRowMinimumException : Exception
    {
        public object ValueInfo { get; set; }
        public PageRowMinimumException() : base() { }
        public PageRowMinimumException(object valueInfo) : base($"The value {valueInfo} is less than the minimum number of records per page.") { ValueInfo = valueInfo; }
        public PageRowMinimumException(string message) : base(message) { }
        public PageRowMinimumException(string message, Exception innerException) : base(message, innerException) { }
    }
}
