using System.Text;

namespace EngineeringDays.Chapter3;

internal static class Problem37
{
    public static void FibonacciNumber(byte limit = 5)
    {
        uint prev = 0;
        uint curr = 1;
        StringBuilder sb = new();
        sb.Append($"{prev}, {curr}");
        for (byte i = 0; i <= limit; i++)
        {
            uint next = prev + curr;
            sb.Append($", {next}");
            prev = curr;
            curr = next;
        }
        Console.WriteLine(sb.ToString());
    }
}
