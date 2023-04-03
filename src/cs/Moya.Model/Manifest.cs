namespace Moya.Model;

public class Manifest
{
    public string Author { get; set; } = "";
    public string Interpreter { get; set; } = "";
    public Uri? Url { get; set; } = null;
    public DateTimeOffset Date { get; set; } = DateTimeOffset.MinValue;
    public string Signature { get; set; } = "";
    public string Units { get; set; } = "";
    public string Language { get; set; } = "";
}

