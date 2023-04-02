namespace Moya.Model;

public partial class Ingredient : IEquatable<Ingredient>
{
    public bool Equals(Ingredient? other) =>
        other != null && other.Name == this.Name && other.Quantity.Equals(this.Quantity);
}
