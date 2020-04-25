using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SquadUpMVC.Models
{

    public class Response
    {
        [JsonPropertyName("data")]
        public List<Event> Data { get; set; }
    }
    public class Event
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("ages")]
        public string Ages { get; set; }

        [JsonPropertyName("artistList")]
        public List<Artist> ArtistList { get; set; }

        [JsonPropertyName("venue")]
        public Venue Venue { get; set; }
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }


    }
    public class Venue
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("location")]
        public string Location { get; set; }
    }
    public class Artist
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("link")]
        public string Link { get; set; }
    }
}
