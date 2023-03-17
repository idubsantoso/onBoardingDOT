using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace dotnet_rpg.Dtos
{
    public class PaginationMoviesDto
    {
        [JsonProperty("dates")]
        public Dates? Dates { get; set; }
        [JsonProperty("page")]
        public int Page { get; set; }
        [JsonProperty("results")]
        public Movies[]? Results { get; set; }
        [JsonProperty("total_pages")]
        public int TotalPage { get; set; }
        [JsonProperty("total_results")]
        public int TotalResuls { get; set; }
    }

    public partial class Dates
    {
        [JsonProperty("maximum")]
        public string? Maximum { get; set; }

        [JsonProperty("minimum")]
        public string? Minimum { get; set; }
    }
}