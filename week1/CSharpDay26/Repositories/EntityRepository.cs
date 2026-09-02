public class EntityRepository<T> where T : class, IEntity, IDisplayable
{
    private readonly Dictionary<string, T> _items;

    //constructor
    public EntityRepository()
    {
        //khoa khong phan biet hoa thuong
        _items = new Dictionary<string, T>(StringComparer.OrdinalIgnoreCase);
    }

    public void Add(T item)
    {
        if(item == null)
        {
            throw new InvalidOperationException("Item cannot be null.");
        }

        if(_items.ContainsKey(item.Id))
        {
            throw new InvalidOperationException($"An item with the same Id '{item.Id}' already exists.");
        }

        _items.Add(item.Id, item);
    }

    public T? FindById(string id)
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("Id cannot be null or whitespace.", nameof(id));
        }

        if(_items.TryGetValue(id.Trim(), out T? item))
        {
            return item;
        }

        return null;
    }
    
    public bool ContainsId(string id)
    {
        /*
        if(FindById(id) != null)
        {
            return true;
        }

        return false;
        */
        if (string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("Id cannot be null or whitespace.", nameof(id));
        }

        return _items.ContainsKey(id.Trim());
    }

    public bool RemoveById(string id)
    {
        if(FindById(id) != null)
        {
            _items.Remove(id.Trim());
            return true;
        }

        return false;
    }

    public int GetCount()
    {
        return _items.Count;
    }

    public List<T> GetAllItems()
    {
        List<T> allItems = new List<T>(_items.Values);

        return allItems;
    }

    public void DisplayAll()
    {
        if(_items.Count == 0)
        {
            Console.WriteLine("This repository is empty.");
            return;
        }

        foreach(T item in _items.Values)
        {
            item.DisplayInfo();
        }
    }
}