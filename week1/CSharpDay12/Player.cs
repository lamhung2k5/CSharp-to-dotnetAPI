public class Player
{
    public string Id {  get; private set; }
    public string  FullName { get; private set; }

    public Player(string id, string fullname)
    {
        if(string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("id khong duoc de trong", nameof(id));
        }
        if(string.IsNullOrWhiteSpace(fullname)) 
        {
            throw new ArgumentException("ten khong duoc de trong", nameof(fullname));
        }

        Id = id.Trim();
        FullName = fullname.Trim();
    }

    public override string ToString()
    {
        return $"id: {Id}, full name: {FullName}";
    }
}