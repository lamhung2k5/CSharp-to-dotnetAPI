public class CPU
{
    public string Model { get; private set; }
    public int CoreCount { get; private set; }

    public CPU(string model, int coreCount)
    {
        if(string.IsNullOrWhiteSpace(model)) 
        {
            throw new ArgumentException("Model khong duoc rong", nameof(model));
        }
        if(coreCount <= 0)
        {
            throw new InvalidOperationException("so nhan phai lon hon 0");
        }
        Model = model.Trim();
        CoreCount = coreCount;
    }


}