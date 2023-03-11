using Portfolio.Core.Parameters;

namespace Portfolio.Core.Interfaces.Management
{
    public interface IUriService
    {
        Uri GetPageUri(RequestParameter filter, string route);
    }
}
