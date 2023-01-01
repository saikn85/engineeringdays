namespace EngineeringDays.Chapter2;

/// <summary>
/// Print area and perimeter of a rectangle
/// </summary>
internal static class Problem30
{
    public static void CalculateAreaPerimeterOfRectangle(ushort length = 1, ushort breadth = 1) =>
        Console.WriteLine($"Length: {length} Breadth: {breadth} | Area = {length * breadth}; Perimeter = {2*(length + breadth)}");
    
}

