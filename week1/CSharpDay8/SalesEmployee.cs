public class SalesEmployee : Employee, IBonusEligible

{
    public decimal SalesRevenue { get; private set; }
    public decimal CommissionRate { get; private set; }

    public SalesEmployee(string id, string fullName, decimal baseSalary, decimal salesRevenue, decimal commissionRate) : base(id, fullName, baseSalary)
    {
        if (salesRevenue < 0)
        {
            throw new ArgumentException("Doanh thu ban hang khong duoc am", nameof(salesRevenue));
        }
        if (commissionRate < 0 || commissionRate > 0.3m)
        {
            throw new ArgumentException("Ty le hoa hong phai nam trong khoang tu 0 den 0.3", nameof(commissionRate));
        }
        SalesRevenue = salesRevenue;
        CommissionRate = commissionRate;
    }

    public decimal CalculateBonus()
    {
        if (SalesRevenue >= 100_000_000m)
        {
            return  SalesRevenue * 0.02m;
        }

        return 0;
    }

    public override decimal CalculateSalary()
    {
        return BaseSalary + (SalesRevenue * CommissionRate) + CalculateBonus();
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Sales Revenue: {SalesRevenue:C}, Commission Rate: {CommissionRate:P}, Total Salary: {CalculateSalary():C}");
    }   
}