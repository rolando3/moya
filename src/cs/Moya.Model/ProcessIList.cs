using System.Collections;

namespace Moya.Model;

public partial class Process : IList<ProcessStep>
{
    private List<ProcessStep> _steps = new List<ProcessStep>();

    public ProcessStep this[int index] { get => ((IList<ProcessStep>)_steps)[index]; set => ((IList<ProcessStep>)_steps)[index] = value; }

    public int Count => ((ICollection<ProcessStep>)_steps).Count;

    public bool IsReadOnly => ((ICollection<ProcessStep>)_steps).IsReadOnly;

    public void Add(ProcessStep item)
    {
        ((ICollection<ProcessStep>)_steps).Add(item);
    }

    public void Clear()
    {
        ((ICollection<ProcessStep>)_steps).Clear();
    }

    public bool Contains(ProcessStep item)
    {
        return ((ICollection<ProcessStep>)_steps).Contains(item);
    }

    public void CopyTo(ProcessStep[] array, int arrayIndex)
    {
        ((ICollection<ProcessStep>)_steps).CopyTo(array, arrayIndex);
    }

    public IEnumerator<ProcessStep> GetEnumerator()
    {
        return ((IEnumerable<ProcessStep>)_steps).GetEnumerator();
    }

    public int IndexOf(ProcessStep item)
    {
        return ((IList<ProcessStep>)_steps).IndexOf(item);
    }

    public void Insert(int index, ProcessStep item)
    {
        ((IList<ProcessStep>)_steps).Insert(index, item);
    }

    public bool Remove(ProcessStep item)
    {
        return ((ICollection<ProcessStep>)_steps).Remove(item);
    }

    public void RemoveAt(int index)
    {
        ((IList<ProcessStep>)_steps).RemoveAt(index);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)_steps).GetEnumerator();
    }
}
