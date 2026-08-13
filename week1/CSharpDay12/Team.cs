public class Team
{
	public string Name { get; private set; }
	public List<Player> Players { get; private set; }

	public Team(string name, List<Player> players)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			throw new ArgumentException("ten khong duoc de trong", nameof(name));
		}
		if (players == null)
		{
			throw new ArgumentNullException(
				nameof(players));
		}
		Name = name.Trim();
		Players = players;
	}

	public void DisplayInfo()
	{
		Console.WriteLine($"name of Team: {Name}");

		foreach (Player p in Players)
		{
			Console.WriteLine(p.ToString());
		}
	}
}