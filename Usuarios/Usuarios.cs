namespace EspacioUsuarios;

public class Address
{
    [JsonProperty("street")]
    [JsonPropertyName("street")]
    public string street { get; set; }

    [JsonProperty("suite")]
    [JsonPropertyName("suite")]
    public string suite { get; set; }

    [JsonProperty("city")]
    [JsonPropertyName("city")]
    public string city { get; set; }

    [JsonProperty("zipcode")]
    [JsonPropertyName("zipcode")]
    public string zipcode { get; set; }

    [JsonProperty("geo")]
    [JsonPropertyName("geo")]
    public Geo geo { get; set; }
}

public class Company
{
    [JsonProperty("name")]
    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonProperty("catchPhrase")]
    [JsonPropertyName("catchPhrase")]
    public string catchPhrase { get; set; }

    [JsonProperty("bs")]
    [JsonPropertyName("bs")]
    public string bs { get; set; }
}

public class Geo
{
    [JsonProperty("lat")]
    [JsonPropertyName("lat")]
    public string lat { get; set; }

    [JsonProperty("lng")]
    [JsonPropertyName("lng")]
    public string lng { get; set; }
}

public class Usuario
{
    [JsonProperty("id")]
    [JsonPropertyName("id")]
    public int id { get; set; }

    [JsonProperty("name")]
    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonProperty("username")]
    [JsonPropertyName("username")]
    public string username { get; set; }

    [JsonProperty("email")]
    [JsonPropertyName("email")]
    public string email { get; set; }

    [JsonProperty("address")]
    [JsonPropertyName("address")]
    public Address address { get; set; }

    [JsonProperty("phone")]
    [JsonPropertyName("phone")]
    public string phone { get; set; }

    [JsonProperty("website")]
    [JsonPropertyName("website")]
    public string website { get; set; }

    [JsonProperty("company")]
    [JsonPropertyName("company")]
    public Company company { get; set; }
}
