using SharesInformationProvider.Core;
using System.Net.Http;
using System.Threading.Tasks;

namespace SharesInformationProvider.API.Fetchers
{
    public abstract class HttpResultsFecther<T> : IResultsFetcher<T>
    {
        protected HttpClient client;

        public HttpResultsFecther(HttpClient client) => this.client = client;

        public abstract Task<T> FetchResults(object requestDetails);

        public abstract void ProcessResults();
    }
}
