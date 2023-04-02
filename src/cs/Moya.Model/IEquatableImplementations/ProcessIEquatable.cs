namespace Moya.Model;

public partial class Process : IEquatable<Process?>
{
    public bool Equals(Process? other)
        => other != null && other._steps.Equals(this._steps);
}
