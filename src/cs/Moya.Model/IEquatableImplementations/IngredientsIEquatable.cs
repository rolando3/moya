namespace Moya.Model;

public partial class Ingredients : IEquatable<Ingredients>
{
    public bool Equals(Ingredients? other) =>
        other?._ingredients.Equals(this._ingredients) ?? false;
}
