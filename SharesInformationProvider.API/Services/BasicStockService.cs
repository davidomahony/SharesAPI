using SharesInformationProvider.Core;
using System;
using SharesInformationProvider.Models;
using SharesInformationProvider.Core.AlphaVantage;
using SharesInformationProvider.API.Fetchers;
using System.Linq;
using System.Threading.Tasks;

namespace SharesInformationProvider.API.Services
{
    public class BasicStockService : IResultsGenerator<BasicSharesQueryResponse>
    {
        IFetcherRepository<AlphaVantageStockFetchResult> resultsFetcher;

        public BasicStockService(IResultsRepository<AlphaVantageStockFetchResult> basicResultsFetcher)
        {
            this.resultsFetcher = basicResultsFetcher as IFetcherRepository<AlphaVantageStockFetchResult>;
        }

        public async Task<BasicSharesQueryResponse> GenerateResults(object information)
        {
            if (information == null || !(information is BasicSharesQueryInfo))
            {

            }

            var responseFromFetcher = await this.resultsFetcher.FetchResults(information);
            if (responseFromFetcher == null)
            {

            }

            return new BasicSharesQueryResponse()
            {
                ListingName = responseFromFetcher.MetaData.Symbol,
                //Results = responseFromFetcher.TimeSeries.TimeSeries.ToDictionary(itm => itm.Time.ToString(), itm => itm.Close)
            };
        }

    }
}
