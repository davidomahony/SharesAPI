using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using SharesInformationProvider.Core.AlphaVantage;
using SharesInformationProvider.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SharesInformationProvider.API.Fetchers
{
    public class AlphaVantageStocksRepository : IFetcherRepository<AlphaVantageStockFetchResult>
    {
        private readonly string apiKey;

        public AlphaVantageStocksRepository(HttpClient client, IConfiguration configuration)
            : base(client)
        {
            this.apiKey = configuration["SharesApiProviderInformation:AlphaVantageInformation:ApiKey"];
        }

        public override async Task<AlphaVantageStockFetchResult> FetchResults(object information)
        {
            var requestInformation = information as BasicSharesQueryInfo;

            var result = await this.client.GetAsync(this.BuildRequest(requestInformation));
            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var responseContent = await result.Content.ReadAsStringAsync();
                var deserializedResponse = JsonConvert.DeserializeObject<AlphaVantageStockFetchResult>(responseContent);

                if (deserializedResponse != null)
                {
                    return deserializedResponse;
                }
            }

            throw new NotImplementedException();
        }

        public override void ProcessResults()
        {
            throw new NotImplementedException();
        }

        private string BuildRequest(BasicSharesQueryInfo info)
        {
            return $"?function=TIME_SERIES_DAILY&symbol={info.ListingName}&interval={info.TimeIncrement}hours&apikey={this.apiKey}";
        }
    }
}
