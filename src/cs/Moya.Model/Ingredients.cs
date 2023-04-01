namespace Moya.Model;

public partial class Ingredients
{
    public Ingredients()
    {
    }

    public Ingredients(IEnumerable<Ingredient> ingredients)
    {
        _ingredients = ingredients.ToList();
    }
}
