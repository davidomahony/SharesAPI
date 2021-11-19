using System;

namespace SharesInformationProvider.Models
{
    public class BasicSharesQueryInfo
    {
        public string ListingName { get; set; }

        public DateTimeOffset StartDate { get; set; }

        public DateTimeOffset EndDate { get; set; }

        public int TimeIncrement { get; set; }
    }
}
