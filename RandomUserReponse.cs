using System.Text.Json.Serialization;

namespace Programacion_Asicronica
{
    public class RandomUserResponse
    {
        [JsonPropertyName("results")]
        public List<Result> Results { get; set; }
    }

    public class Result
    {
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("location")]
        public Location location { get; set; }
    }

    public class Name
    {
        [JsonPropertyName("first")]
        public string First { get; set; }

        [JsonPropertyName("last")]
        public string Last { get; set; }
    }

    public class Location
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }
    }
}
