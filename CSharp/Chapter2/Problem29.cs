using EngineeringDays.Chapter2;

/// <summary>
/// Extract and print the second rightmost digit of the integral part of a float
/// </summary>
internal static class Problem29
{
    public static void GetSecondRightMostDigit(float number) =>
        Console.WriteLine($"Second rightmost digit of the integral part of the float {number} is {(int)(number / 10)%10}");
}
