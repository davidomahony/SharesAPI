using System.Threading.Tasks;

namespace SharesInformationProvider.Core
{
    public interface IResultsFetcher<T>
    {
        public Task<T> FetchResults(object requestInformation);
    }
}
