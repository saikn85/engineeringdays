using static System.Console;

namespace EngineeringDays.Chapter4;

internal static class Problem35
{
    public static void SumDigits(ushort number = ushort.MaxValue)
    {
        ushort sum = default;
        while(number != 0)
        {
            ushort digit = (ushort)(number % 10);
            sum += digit;
            number /= 10;
        }
        WriteLine($"Sum of Digits: {sum}");
    }
}
