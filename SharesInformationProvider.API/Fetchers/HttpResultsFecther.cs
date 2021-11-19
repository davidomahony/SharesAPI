using SharesInformationProvider.Core;
using System.Net.Http;
using System.Threading.Tasks;

namespace SharesInformationProvider.API.Fetchers
{
    public abstract class HttpResultsFecther<T> : IResultsFetcher<T>
    {
        protected HttpClient client;

        public HttpResultsFecther(HttpClient client) => this.client = client;

        public abstract Task<T> FetchResults();

        public abstract void ConfigureRequest(object details);

        public abstract void ProcessResults();
    }
}
