using AutoMapper;
using Portfolio.Core.Custom;

namespace Portfolio.Application.Mappings
{
    public class ConverterPaging<TSource, TDestination> : ITypeConverter<PagedList<TSource>, MetaData<TDestination>>
    {
        public MetaData<TDestination> Convert(PagedList<TSource> source, MetaData<TDestination> destination, ResolutionContext context) => new()
        {
            Paging = context.Mapper.Map<Pagination>(new Pagination(source.CurrentPage, source.PageSize, source.TotalCount,
                                                                   source.TotalPages, source.HasPreviousPage, source.HasNextPage,
                                                                   source.HasFirstPage, source.HasLastPage, source.NextPageNumber,
                                                                   source.PreviousPageNumber, source.FirstPageNumber, source.LastPageNumber,
                                                                   source.StartIndex, source.EndIndex)),
            DataSet = context.Mapper.Map<IEnumerable<TSource>, IEnumerable<TDestination>>(source),
            Links = context.Mapper.Map<NavLinks>(new NavLinks(source.SelfPage, source.FirstPage, source.LastPage, source.NextPage, source.PreviousPage))
        };
    }
}
