public static class Calculator
{
    public static decimal Add(decimal first, decimal second)
    {
        return first + second;
    }

    public static decimal Subtract(decimal first, decimal second)
    {
        return first - second;
    }

    public static decimal Multiply(decimal first, decimal second)
    {
        return first * second;
    }

    public static decimal Divide(decimal first, decimal second) 
    {
        if(second == 0)
        {
            throw new DivideByZeroException("The second element is invalid.");
        }

        return first / second;
    }

    public static decimal Calculate(decimal first, decimal second, CalculateDelegate operation)
    {
        return operation(first, second);
    }
}