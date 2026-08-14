public class StudentCard
{
    public string CardNumber { get; private set; }
    public DateTime IssuedDate { get; private set; }

    public StudentCard(string cardNumber, DateTime issuedDate)
    {
        if (string.IsNullOrWhiteSpace(cardNumber))
        {
            throw new ArgumentException("Card number cannot be null or whitespace.", nameof(cardNumber));
        }
        if (issuedDate.Date > DateTime.Today)
        {
            throw new ArgumentException(
                "Ngay cap the khong duoc lon hon ngay hien tai",
                nameof(issuedDate));
        }

        CardNumber = cardNumber.Trim();
        IssuedDate = issuedDate.Date;
        
    }
}