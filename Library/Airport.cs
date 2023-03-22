
namespace Library;
public class Airport
{
    public string? name { get; set; }
    public string? iata_code { get; set; }
    public string? country_code { get; set; }

    public override string ToString()
    {
        return $"{name},{iata_code},{country_code}";
    }
}
