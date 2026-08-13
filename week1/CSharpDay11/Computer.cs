public class Computer
{
    public string Name { get; set; }
    public CPU CPU { get; set; }

    public Computer(string name, string cpuName, int cpuCoreCount)
    {
        if(string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Ten may khong duoc rong", nameof(name));
        }
        Name = name.Trim();
        CPU = new CPU(cpuName,cpuCoreCount);
    }
}