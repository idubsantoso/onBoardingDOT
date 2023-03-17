using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Dtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ThirdPartyAPIController : ControllerBase
    {
        // Let the `IHttpClientFactory` do the `HttpClient` handling
        private HttpClient _client;

        public ThirdPartyAPIController(HttpClient client)
        {
            _client = client;
        }

        [HttpGet]
        public async Task<IActionResult> GetMoviesAsync()
        {
            var URL = $"https://api.themoviedb.org/3/movie/550?api_key=28fefc44d2b3efa2a35b7dbabbc41fd3";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(URL);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var movieList = JsonConvert.DeserializeObject<Movies>(apiResponse);
            return Ok(movieList);

        }

        [HttpGet("GetNowPlaying/{page}")]
        public async Task<IActionResult> GetMoviesNowPlayingAsync(int page)
        {
            var URL = $"https://api.themoviedb.org/3/movie/now_playing?api_key=28fefc44d2b3efa2a35b7dbabbc41fd3&language=en-US&page="+page;
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(URL);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var movieList = JsonConvert.DeserializeObject<PaginationMoviesDto>(apiResponse);
            return Ok(movieList);

        }
        
    }
}