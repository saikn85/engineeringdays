namespace EngineeringDays.Chapter3;

internal static class Problem36
{
    public static void ConvertInchToInchMetrics(double measure = 1)
    {
        Console.WriteLine($"inch: {measure:0.00000} = foot: {measure / 12:0.00000}");
        Console.WriteLine($"inch: {measure:0.00000} = yard: {measure / 36:0.00000}");
        Console.WriteLine($"inch: {measure:0.00000} = centimeter: {measure * 2.54:0.00000}");
        Console.WriteLine($"inch: {measure:0.00000} = meter: {measure / 39.37:0.00000}");
    }
}
