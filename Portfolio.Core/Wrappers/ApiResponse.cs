namespace Portfolio.Core.Wrappers
{
    public class ApiResponse<T>
    {
        public ApiResponse() { }
        public ApiResponse(T data, string message = null)
        { Succeeded = true; Message = message; Data = data; }
        public ApiResponse(string message, bool isOK = false)
        { Succeeded = isOK; Message = message; }
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public IReadOnlyDictionary<string, string[]> Errors { get; set; }
        public T Data { get; set; }
    }
}
