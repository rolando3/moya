namespace Moya.Model;

public partial class Process
{
    public Process()
    {
    }

    public Process(IEnumerable<ProcessStep> steps)
    {
        _steps = steps.ToList();
    }
}
