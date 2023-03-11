namespace Portfolio.Core.Custom
{
    public class Pagination
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
        public bool HasFirstPage { get; set; }
        public bool HasLastPage { get; set; }
        public int? NextPageNumber { get; set; }
        public int? PreviousPageNumber { get; set; }
        public int? FirstPageNumber { get; set; }
        public int? LastPageNumber { get; set; }
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
        public Pagination(int currentPage, int pageSize, int totalCount, int totalPages, bool hasPreviousPage, bool hasNextPage,
                          bool hasFirstPage, bool hasLastPage, int? nextPageNumber, int? previousPageNumber, int? firstPageNumber,
                          int? lastPageNumber, int startIndex, int endindex)
        {
            CurrentPage = currentPage; PageSize = pageSize; TotalCount = totalCount; TotalPages = totalPages;
            HasPreviousPage = hasPreviousPage; HasNextPage = hasNextPage; HasFirstPage = hasFirstPage; HasLastPage = hasLastPage;
            NextPageNumber = nextPageNumber; PreviousPageNumber = previousPageNumber; FirstPageNumber = firstPageNumber;
            LastPageNumber = lastPageNumber; StartIndex = startIndex; EndIndex = endindex;
        }
    }
}