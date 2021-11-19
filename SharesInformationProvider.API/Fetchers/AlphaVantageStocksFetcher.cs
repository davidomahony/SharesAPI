using SharesInformationProvider.Core.AlphaVantage;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SharesInformationProvider.API.Fetchers
{
    public class AlphaVantageStocksFetcher : HttpResultsFecther<AlphaVantageStockFetchResult>
    {
        public AlphaVantageStocksFetcher(HttpClient client)
            : base(client)
        {
        }

        public override void ConfigureRequest(object details)
        {
            throw new NotImplementedException();
        }

        public override Task<AlphaVantageStockFetchResult> FetchResults()
        {
            throw new NotImplementedException();
        }

        public override void ProcessResults()
        {
            throw new NotImplementedException();
        }
    }
}
