using SharesInformationProvider.Core;
using System.Net.Http;
using System.Threading.Tasks;

namespace SharesInformationProvider.API.Fetchers
{
    public abstract class IFetcherRepository<T> : IResultsRepository<T>
    {
        protected HttpClient client;

        public IFetcherRepository(HttpClient client) => this.client = client;

        public abstract Task<T> FetchResults(object requestDetails);

        public abstract void ProcessResults();
    }
}
