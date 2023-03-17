using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace dotnet_rpg.Models
{
    public class Movies
    {
        [JsonProperty("adult")]
        public Boolean Adult { get; set; }

        [JsonProperty("backdrop_path")]
        public string? BackdropPath { get; set; }

        [JsonProperty("belongs_to_collection")]
        public object? BelongsToCollection { get; set; }

        [JsonProperty("budget")]
        public long Budget { get; set; }

        [JsonProperty("genres")]
        public Genre[]? Genres { get; set; }

        [JsonProperty("homepage")]
        public Uri? Homepage { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("imdb_id")]
        public string? ImdbId { get; set; }

        [JsonProperty("original_language")]
        public string? OriginalLanguage { get; set; }

        [JsonProperty("original_title")]
        public string? OriginalTitle { get; set; }

        [JsonProperty("overview")]
        public string? Overview { get; set; }

        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("poster_path")]
        public string? PosterPath { get; set; }

        [JsonProperty("production_companies")]
        public ProductionCompany[]? ProductionCompanies { get; set; }

        [JsonProperty("production_countries")]
        public ProductionCountry[]? ProductionCountries { get; set; }

        [JsonProperty("release_date")]
        public DateTimeOffset ReleaseDate { get; set; }

        [JsonProperty("revenue")]
        public long Revenue { get; set; }

        [JsonProperty("runtime")]
        public long Runtime { get; set; }

        [JsonProperty("spoken_languages")]
        public SpokenLanguage[]? SpokenLanguages { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("tagline")]
        public string? Tagline { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("video")]
        public bool Video { get; set; }

        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public long VoteCount { get; set; }
    }

    public partial class ProductionCompany
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("logo_path")]
        public string? LogoPath { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("origin_country")]
        public string? OriginCountry { get; set; }
    }

    public partial class ProductionCountry
    {
        [JsonProperty("iso_3166_1")]
        public string? Iso3166_1 { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }

    public partial class SpokenLanguage
    {
        [JsonProperty("english_name")]
        public string? EnglishName { get; set; }

        [JsonProperty("iso_639_1")]
        public string? Iso639_1 { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}