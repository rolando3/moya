namespace Moya.Model;

public partial class Ingredient
{
    public string Name { get; set; } = string.Empty;
    public Quantity Quantity { get; set; } = new Quantity();
}
