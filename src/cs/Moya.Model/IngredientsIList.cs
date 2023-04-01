using System.Collections;

namespace Moya.Model;

/// <summary>
/// IList implementation for Ingredients
/// </summary>
public partial class Ingredients : IList<Ingredient>
{
    private List<Ingredient> _ingredients = new();

    public Ingredient this[int index] { get => ((IList<Ingredient>)_ingredients)[index]; set => ((IList<Ingredient>)_ingredients)[index] = value; }

    public int Count => ((ICollection<Ingredient>)_ingredients).Count;

    public bool IsReadOnly => ((ICollection<Ingredient>)_ingredients).IsReadOnly;

    public void Add(Ingredient item)
    {
        ((ICollection<Ingredient>)_ingredients).Add(item);
    }

    public void Clear()
    {
        ((ICollection<Ingredient>)_ingredients).Clear();
    }

    public bool Contains(Ingredient item)
    {
        return ((ICollection<Ingredient>)_ingredients).Contains(item);
    }

    public void CopyTo(Ingredient[] array, int arrayIndex)
    {
        ((ICollection<Ingredient>)_ingredients).CopyTo(array, arrayIndex);
    }

    public IEnumerator<Ingredient> GetEnumerator()
    {
        return ((IEnumerable<Ingredient>)_ingredients).GetEnumerator();
    }

    public int IndexOf(Ingredient item)
    {
        return ((IList<Ingredient>)_ingredients).IndexOf(item);
    }

    public void Insert(int index, Ingredient item)
    {
        ((IList<Ingredient>)_ingredients).Insert(index, item);
    }

    public bool Remove(Ingredient item)
    {
        return ((ICollection<Ingredient>)_ingredients).Remove(item);
    }

    public void RemoveAt(int index)
    {
        ((IList<Ingredient>)_ingredients).RemoveAt(index);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)_ingredients).GetEnumerator();
    }
}
