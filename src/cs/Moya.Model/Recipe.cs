using System.Collections;

namespace Moya.Model;

public partial class Recipe
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public Ingredients Ingredients { get; set; } = new Ingredients();
    public Process Process { get; set; } = new Process();
}
