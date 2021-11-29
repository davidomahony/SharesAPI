using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SharesInformationProvider.Core.AlphaVantage
{
    public class AlphaVantageStockFetchResult
    {
        [JsonProperty("Meta Data")]
        public MetaDataCollection MetaData { get; set; }

        [JsonProperty("Time Series (Daily)")]
        public TimeSeriesCollection TimeSeries;

        public class MetaDataCollection
        {
            [JsonProperty("1. Information")]
            public string Information;

            [JsonProperty("2. Symbol")]
            public string Symbol { get; set; }

            [JsonProperty("3. Last Refreshed")]
            public string LastRefreshed { get; set; }
        }

        public class TimeSeriesCollection
        {
            public Dictionary<string, TimeSeriesEntry> TimeSeries { get; set; }

            public class TimeSeriesEntry
            {
                [JsonProperty("1. Information")]
                public float High { get; set; }

                [JsonProperty("1. Information")]
                public float Low { get; set; }

                [JsonProperty("1. Information")]
                public float Close { get; set; }

                [JsonProperty("1. Information")]
                public float Open { get; set; }
            }
        }
    }
}
