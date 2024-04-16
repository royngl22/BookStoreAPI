using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace BookStoreAPI.Models
{
    public class BookResponse
    {
        [JsonProperty("book_id")]
        public int BookId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; } = null!;

        [JsonProperty("type")]
        public string Type { get; set; } = null!;

        [JsonProperty("price")]
        public decimal? Price { get; set; }

        [JsonProperty("notes")]
        public string? Notes { get; set; }

        [JsonProperty("published_date")]
        public DateTime PublishedDate { get; set; }

    }
}
