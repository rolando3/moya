namespace Moya.Model;

public class Ingredient
{
    public string Name { get; set; } = string.Empty;
    public Quantity Quantity { get; set; } = new Quantity();
}
