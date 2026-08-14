public class Student : Person
{
    public string StudentCode { get; private set; }
    public StudentCard StudentCard { get; private set; }

    public Student(string id, string fullName, string studentCode, string cardNumber, string issuedDate) : base(id, fullName)
    {
        if(string.IsNullOrWhiteSpace(studentCode))
        {
            throw new ArgumentException("Student code can not be null or white space", nameof(studentCode));
        }
        if(string.IsNullOrWhiteSpace(cardNumber))
        {
            throw new ArgumentException("card number can not be null or white space", nameof(studentCode));
        }
        if (string.IsNullOrWhiteSpace(issuedDate))
        {
            throw new ArgumentException("issued date can not be null or white space", nameof(issuedDate));
        }
        StudentCode = studentCode.Trim();
        StudentCard = new StudentCard(cardNumber, issuedDate);
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Student Code: {StudentCode}, Card Number: {StudentCard.CardNumber}, Issued Date: {StudentCard.IssuedDate}");
    }
}