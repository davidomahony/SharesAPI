using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharesInformationProvider.Core.AlphaVantage
{
    public class AlphaVantageStockFetchResult
    {
        public MetaDataCollection MetaData { get; set; }

        public TimeSeriesCollection TimeSeries;

        public class MetaDataCollection
        {
            public string Information;

            public string Symbol { get; set; }

            public string LastRefreshed { get; set; }
        }

        public class TimeSeriesCollection
        {
            public IEnumerable<TimeSeriesEntry> TimeSeries { get; set; }

            public class TimeSeriesEntry
            {
                public DateTimeOffset Time { get; set; }

                public float High { get; set; }

                public float Low { get; set; }

                public float Close { get; set; }

                public float Open { get; set; }
            }
        }
    }
}
