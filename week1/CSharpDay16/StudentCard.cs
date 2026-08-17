public class StudentCard
{
    public string CardNumber { get; private set; }
    public string IssuedDate { get; private set; }

    public StudentCard(string cardNumber, string issuedDate)
    {
        if (string.IsNullOrWhiteSpace(cardNumber))
        {
            throw new ArgumentException("CardNumber can not be null or white space", nameof(cardNumber));
        }
        if (string.IsNullOrWhiteSpace(issuedDate))
        {
            throw new ArgumentException("IssuedDate can not be null or white space", nameof(issuedDate));
        }
        CardNumber = cardNumber.Trim(); //thêm Trim()
        IssuedDate = issuedDate.Trim(); //Thêm Trim()
    }

    public void DisplayCardInfo()
    {
        Console.WriteLine($"CardNumber: {CardNumber}, IssuedDate: {IssuedDate}");
    }
}