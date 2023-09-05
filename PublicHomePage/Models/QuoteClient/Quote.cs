using System.Text.Json.Serialization;

namespace PublicHomePage.Models.QuoteClient;

public class Quote
{
    // json property names are different from the property names in the class
    [JsonPropertyName("q")]
    public string Text { get; set; } = "";
    
    [JsonPropertyName("a")]
    public string Author { get; set; } = "";
    
    [JsonPropertyName("c")]
    public string Characters { get; set; } = "";
    
    [JsonPropertyName("h")]
    public string Header { get; set; } = "";
}