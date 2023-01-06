namespace EngineeringDays.Chapter3;


/// <summary>
/// Given a degree(s), find its equivalent radian(s) value
/// </summary>
internal static class Problem31
{
    public static void RadiansToDegrees(double degrees = 90)
    {
        const double one_radian_eq_degree = 57.295779;
        Console.WriteLine($"{degrees}° = {degrees/one_radian_eq_degree:0.000000} rad");
    }
}
