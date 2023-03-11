using Portfolio.Core.Interfaces.Management;
using Portfolio.Core.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Core.Custom
{
    public class PagedList<T> : List<T>
    {

        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage => CurrentPage > 1;
        public bool HasNextPage => CurrentPage < TotalPages;
        public bool HasFirstPage => PreviousPageNumber != null;
        public bool HasLastPage => NextPageNumber != null;
        public int? NextPageNumber => HasNextPage ? CurrentPage + 1 : (int?)null;
        public int? PreviousPageNumber => HasPreviousPage ? CurrentPage - 1 : (int?)null;
        public int? FirstPageNumber => HasFirstPage ? 1 : (int?)null;
        public int? LastPageNumber => HasLastPage ? TotalPages : (int?)null;
        public int StartIndex { get; private set; }
        public int EndIndex { get; private set; }
        public Uri SelfPage { get; set; }
        public Uri NextPage { get; set; }
        public Uri PreviousPage { get; set; }
        public Uri FirstPage { get; set; }
        public Uri LastPage { get; set; }
        public PagedList(IEnumerable<T> data, int pageNumber, int pageSize, int totalRows, IUriService uriService, string fields = null, string orderBy = null, string search = null, string route = null)
        {
            if (uriService is null)
                throw new ArgumentNullException(nameof(uriService), "The constructor for the class 'PagedList' received a null argument.");

            CurrentPage = pageNumber;
            PageSize = pageSize;
            TotalCount = totalRows;
            TotalPages = (int)Math.Ceiling(TotalCount / (double)PageSize);

            // calculate start and end item indexes
            StartIndex = (CurrentPage - 1) * pageSize;
            EndIndex = Math.Min(StartIndex + pageSize - 1, TotalCount - 1);

            if (!string.IsNullOrEmpty(route))
            {
                SelfPage = uriService.GetPageUri(new RequestParameter(CurrentPage, PageSize, search, fields, orderBy), route);
                NextPage = (CurrentPage >= 1 && CurrentPage < TotalPages) ? uriService.GetPageUri(new RequestParameter(CurrentPage + 1, PageSize, search, fields, orderBy), route) : null;
                PreviousPage = ((CurrentPage - 1) >= 1 && CurrentPage <= TotalPages) ? uriService.GetPageUri(new RequestParameter(CurrentPage - 1, PageSize, search, fields, orderBy), route) : null;
                FirstPage = (CurrentPage > 1 && CurrentPage <= TotalPages) ? uriService.GetPageUri(new RequestParameter(1, PageSize, search, fields, orderBy), route) : null;
                LastPage = (CurrentPage >= 1 && CurrentPage < TotalPages) ? uriService.GetPageUri(new RequestParameter(TotalPages, PageSize, search, fields, orderBy), route) : null;
            }

            AddRange(data);
        }

    }
}
