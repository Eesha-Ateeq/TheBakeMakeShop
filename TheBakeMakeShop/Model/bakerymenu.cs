using System.Text.Json;
using System.Text.Json.Serialization;

namespace THE_BAKE_MAKE_SHOPWEB.Model
{
    public class bakerymenu
    {
        [JsonPropertyName("id")]
        public int bakerymenu_id { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("image")]
        public string image { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<bakerymenu>(this);
        }
    }

}