public class OrderProcessingQueue
{
	public string Name { get;}
	private readonly Queue<Order> _orders;

	public OrderProcessingQueue(string name)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			throw new ArgumentException("Name cannot be null or whitespace");
		}

		Name = name.Trim();
		_orders = new Queue<Order>();
	}

	public void AddOrder(Order order)
	{
		if (order == null)
		{
			throw new ArgumentNullException(nameof(order), "order cannot be null");
		}
		_orders.Enqueue(order);
	}

	public Order? ViewNextOrder()
	{
		if (_orders.TryPeek(out Order? order))
		{
			return order;
		}

		return null;
	}

	public Order? ProcessNextOrder()
	{
		if (_orders.TryDequeue(out Order? order))
		{
			return order;
		}
		
		return null;
	}

	public int GetWaitingOrderCount()
	{
		return _orders.Count;
	}

	public void DisplayWaitingOrder()
	{
		Console.WriteLine($"Name: {Name}");	

		if (_orders.Count == 0)
		{
			Console.WriteLine("There are no waiting order");
			return;
		}

		foreach (Order order in _orders)
		{
			order.DisplayInfo();
		}
	}
}