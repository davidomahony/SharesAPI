using System.Collections.Generic;

namespace SharesInformationProvider.Models
{
    public class BasicSharesQueryResponse
    {
        public string ListingName { get; set; }

        public Dictionary<string, float> Results { get; set; }
    }
}
