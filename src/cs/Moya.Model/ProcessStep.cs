namespace Moya.Model;

public partial class ProcessStep
{
    public string Action { get; set; } = "";
    public string[] Ingredients { get; set; } = new string[] {};
    public string[] Results { get; set; } = new string[] {};
    public string Description { get; set; } = "";
    public TimeSpan Duration { get; set; } = TimeSpan.Zero;
}
