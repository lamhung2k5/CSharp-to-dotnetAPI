public class ActionHistory
{
    public string Name { get; }
    private readonly Stack<string> _actions;

    public ActionHistory(string name)
    {
        if(string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be null or whitespace", nameof(name));
        }

        Name = name.Trim();
        _actions = new Stack<string>();
    }

    public void AddAction(string action)
    {
        if(string.IsNullOrWhiteSpace(action))
        {
            throw new ArgumentException("Action cannot be null or whitespace", nameof(action));
        }

        _actions.Push(action.Trim());
    }

    public string? ViewLastAction()
    {
        if(_actions.TryPeek(out string? action))
        {
            return action;
        }

        return null;
    }

    public string? UndoLastAction()
    {
        if(_actions.TryPop(out string? action))
        {
            return action;
        }

        return null;
    }

    public int GetActionCount()
    {
        return _actions.Count;
    }

    public void DisplayActions()
    {
        Console.WriteLine($"History name: {Name}");
        if(_actions.Count == 0)
        {
            Console.WriteLine($"The action history is empty.");
            return;
        }

        foreach(string action in _actions)
        {
            Console.WriteLine($"- {action}");
        }
    }
}