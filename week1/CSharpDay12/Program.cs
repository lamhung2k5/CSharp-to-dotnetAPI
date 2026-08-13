public class Program
{
    public static void Main(string[] args)
    {
        Player p1 = new Player("P01", "An");
        Player p2 = new Player("P02", "Binh");

        Team team = new Team(
            "TVU FC",
            new List<Player>
            {
        p1,
        p2
            });

        team.DisplayInfo();

    }
}