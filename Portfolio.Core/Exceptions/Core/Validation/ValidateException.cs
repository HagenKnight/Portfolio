namespace Portfolio.Core.Exceptions
{
    public class ValidateException : Exception
    {
        public IReadOnlyDictionary<string, string[]> ErrorsDictionary { get; }
        public ValidateException(IReadOnlyDictionary<string, string[]> errorDictionary) :
          base("One or more validation errors occurred") => ErrorsDictionary = errorDictionary;
    }
}
