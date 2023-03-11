namespace Portfolio.Core.Parameters
{
    public class RequestParameter
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string Search { get; set; }
        public string Fields { get; set; }
        public string OrderBy { get; set; }
        public RequestParameter() { PageNumber = 1; PageSize = 10; Fields = string.Empty; OrderBy = string.Empty; Search = string.Empty; }
        public RequestParameter(int pageNumber, int pageSize, string search, string fields, string orderBy)
        {
            PageNumber = pageNumber < 1 ? 1 : pageNumber;
            PageSize = pageSize > 10 ? 10 : pageSize;
            Fields = fields; OrderBy = orderBy; Search = search;
        }
    }
}

