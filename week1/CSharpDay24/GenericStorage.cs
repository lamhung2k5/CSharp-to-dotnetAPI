public class GenericStorage<T>
{ 
    public string Name { get; }
    private readonly List<T> _items;

    public GenericStorage(string name)
    {
        if(string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be null or whitespace", nameof(name));
        }

        Name = name.Trim();
        _items = new List<T>();
    }

    public void AddItem(T item)
    {
        _items.Add(item);
    }

    public T GetFirstItem()
    {
        if(_items.Count == 0)
        {
            throw new InvalidOperationException("The storage is empty.");
        }

        return _items[0];
    }

    public T GetLastItem()
    {
        if (_items.Count == 0)
        {
            throw new InvalidOperationException("the Storage is empty.");
        }

        return _items[_items.Count - 1];
    }

    public T GetItemAt(int index)
    {
        if(index < 0 || index >= _items.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), index, "Index is outside the storage range.");
        }
        return _items[index];
    }

    public bool RemoveItem(T item)
    {
        return _items.Remove(item);
    }

    public bool ContainsItem(T item)
    {
        return _items.Contains(item);
    }

    public int GetItemCount()
    {
        return _items.Count;
    }

    public List<T> GetAllItems()
    {
        return new List<T>(_items);
    }

    public void DisplayItems()
    {
        Console.WriteLine($"Name: {Name}");

        if(_items.Count == 0)
        {
            Console.WriteLine("The storage is empty.");
            return;
        }

        foreach(T item in _items)
        {
            Console.WriteLine(item);
        }
    }
}
