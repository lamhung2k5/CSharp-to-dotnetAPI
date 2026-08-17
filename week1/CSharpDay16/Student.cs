public class Student : Person
{
    public string StudentCode { get; private set; }
    public StudentCard StudentCard { get; private set; }

    public Student(string id, string fullName, string studentCode, string cardNumber, string issuedDate) : base(id, fullName)
    {
        if(string.IsNullOrWhiteSpace(studentCode))
        {
            throw new ArgumentException("StudentCode can not be null or white space", nameof(studentCode));
        }
        /* bị dư validation
        if(string.IsNullOrWhiteSpace(cardNumber))
        {
            throw new ArgumentException("CardNumber can not be null or white space", nameof(cardNumber));
        }
        if(string.IsNullOrWhiteSpace(issuedDate))
        {
            throw new ArgumentException("IssuedDate can not be null or white space", nameof(issuedDate));
        }
        */

        StudentCard = new StudentCard(cardNumber, issuedDate);
        StudentCode = studentCode;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"StudentCode: {StudentCode}");
        StudentCard.DisplayCardInfo();
    }
}