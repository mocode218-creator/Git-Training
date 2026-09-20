using System;

public class Calculator
{
    // Optional metadata property retained from previous implementation
    public int Age { get; set; }

    public Calculator() { }

    public Calculator(int age)
    {
        Age = age;
    }

    /// <summary>
    /// Adds two integers using checked arithmetic to surface overflow.
    /// </summary>
    public int Add(int a, int b) => checked(a + b);

    /// <summary>
    /// Adds two doubles.
    /// </summary>
    public double Add(double a, double b) => a + b;

    /// <summary>
    /// Subtracts b from a using checked arithmetic.
    /// </summary>
    public int Subtract(int a, int b) => checked(a - b);

    /// <summary>
    /// Multiplies two integers using checked arithmetic to surface overflow.
    /// </summary>
    public int Multiply(int a, int b) => checked(a * b);

    /// <summary>
    /// Divides two doubles; throws DivideByZeroException for zero divisor.
    /// </summary>
    public double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Divisor cannot be zero.");
        return a / b;
    }

    /// <summary>
    /// Attempts to divide two integers and returns false when divisor is zero.
    /// Uses integer division semantics.
    /// </summary>
    public bool TryDivide(int a, int b, out int result)
    {
        if (b == 0)
        {
            result = 0;
            return false;
        }

        result = a / b;
        return true;
    }

    /// <summary>
    /// Static helper for quick one-off operations without creating an instance.
    /// </summary>
    public static int SafeAdd(int a, int b) => checked(a + b);

    public override string ToString() => $"Calculator(Age={Age})";
}
