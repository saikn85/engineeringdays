using static System.Console;
namespace EngineeringDays.Chapter3;

internal static class Problem38
{
    public static void PrintNumberPatternScreenOrigin(short rows = 10)
    {
        for (short i = 0; i < rows; i++)
        {
            for (short j = i; j < rows; j++)
                Write($"{j}  ");
            WriteLine();
        }
    }

    public static void PrintNumberPatternAwayOrigin(short rows = 10)
    {
        for (short i = 0; i < rows; i++)
        {
            for (short j = (short)(rows - 1); j > i; j--)
                Write($" ");
            for(short k = 0; k <= i; k++)
                Write($"|");
            WriteLine();
        }
    }
}
