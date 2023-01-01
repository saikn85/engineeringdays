namespace EngineeringDays.Chapter2;

/// <summary>
/// Extract and print the rightmost digit of the integral part of a float
/// </summary>
internal static class Problem28
{
    public static void GetRightMostDigit(float number = 10.00f) => 
        Console.WriteLine($"Right mostdigit of the integrap part of the float {number} is {(int)number % 10}");
}
