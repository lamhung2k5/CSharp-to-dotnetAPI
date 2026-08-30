public class EntityRepository<T> where T : class, IEntity, IDisplayable
{
    private readonly List<T> _items;

    public EntityRepository()
    {
        _items = new List<T>();
    }

    public void Add(T item)
    {
        /*
            if(item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item annot be null.");
            }

            if(!_items.Contains(item))
            {
                _items.Add(item);
            }
            else
            {
                throw new InvalidOperationException("Id item is already exists.");
            }
        */
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item), "Item cannot be null.");
        }

        if (FindById(item.Id) != null)
        {
            throw new InvalidOperationException($"An item with Id '{item.Id}' already exists.");
        }

        _items.Add(item);
    }

    public T? FindById(string id)
    {
        if(string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("Id cannot be null or whitespace.", nameof(id));
        }

        string normalizedId = id.Trim();

        foreach(T item in _items)
        {
            if(string.Equals(item.Id, normalizedId, StringComparison.OrdinalIgnoreCase))
            {
                return item;
            }
        }

        return null;
    }

    public bool RemoveById(string id)
    {
        /*
        if (string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("Id cannot be null or whitespace.", nameof(id));
        }

        string normalizedId = id.Trim();

        if(_items.Remove(FindById(normalizedId)))
        {
            return true;
        }

        return false;
        */

        string normalizedId = id.Trim();

        T? foundItem = FindById(normalizedId);

        if (foundItem == null)
        {
            return false;
        }

        return _items.Remove(foundItem);
    }

    public bool ContainsId(string id)
    {
        /*
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Id cannot be null or whitespace.", nameof(id));
            }

            string normalizedId = id.Trim();

            if(_items.Contains(normalizedId))
            {
                return true;
            }

            return false;
        */
        return FindById(id) != null;
    }

    public int GetCount()
    {
        return _items.Count;
    }

    public void DisplayAll()
    {
        if(_items.Count == 0)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        foreach(T item in _items)
        {
            item.DisplayInfo();
        }
    }
}