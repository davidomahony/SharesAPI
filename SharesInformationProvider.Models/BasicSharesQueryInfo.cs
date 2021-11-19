using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace SharesInformationProvider.Models
{
    public class BasicSharesQueryInfo
    {
        [Required]
        [FromQuery(Name = "ListingName")]
        public string ListingName { get; set; }

        [Required]
        [FromQuery(Name = "StartDate")]
        public DateTimeOffset StartDate { get; set; }

        [Required]
        [FromQuery(Name = "EndDate")]
        public DateTimeOffset EndDate { get; set; }

        [Required]
        [FromQuery(Name = "TimeIncrement")]
        public int TimeIncrement { get; set; }
    }
}
