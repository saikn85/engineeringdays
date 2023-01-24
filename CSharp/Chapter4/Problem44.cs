using System.Text;
using static System.Console;

namespace EngineeringDays.Chapter4;

internal static class Problem44
{
    public static void GenerateBillForCarpetCleaning()
    {
        ReadValues(out ushort length, out ushort width, out decimal discount, out decimal costPerSqFt);
        GenerateBill(length, width, costPerSqFt, discount);
    }

    private static void ReadValues(out ushort length, out ushort width, out decimal discount, out decimal costPerSqFt)
    {
        WriteLine("Please enter valid values for the following:");
        Write("Length of Room (feet): ");
        string? len = ReadLine();
        Write("Width of Room (feet): ");
        string? wdt = ReadLine();
        Write("Discount (%): ");
        string? dis = ReadLine();
        Write("Cost / Sq. Ft.: ");
        string? cost = ReadLine();

        if (!ushort.TryParse(len, out length))
            length = 1;
        if (!ushort.TryParse(wdt, out width))
            width = 1;
        if (!decimal.TryParse(dis, out discount))
            discount = 0.00m;
        if (!decimal.TryParse(cost, out costPerSqFt))
            costPerSqFt = 12.50m;
    }

    private static void GenerateBill(ushort length, ushort width, decimal costPerSqFt, decimal discount)
    {
        const decimal laborCost = 0.35m;
        const decimal tax = 8.5m;

        uint area = (uint)(length * width);

        StringBuilder sb = new();
        sb.AppendLine(string.Format("{0, 30}", "MEASUREMENTS"));
        sb.AppendLine();
        sb.AppendLine(string.Format("{0, -30} {1, 30}", "Length (ft)", length));
        sb.AppendLine(string.Format("{0, -30} {1, 30}", "Width (ft)", width));
        sb.AppendLine(string.Format("{0, -30} {1, 30}", "Area (sq. ft)", area));
        WriteLine(sb.ToString());
        WriteLine();

        decimal carpet = costPerSqFt * area;
        decimal totalLaborCost = laborCost * carpet;
        decimal installedPrice = carpet + totalLaborCost;
        
        decimal discountedCost = ((discount / 100) * installedPrice);
        decimal subtotal = (installedPrice + totalLaborCost) - discountedCost;
        
        decimal taxed = subtotal * (tax / 100);
        decimal total = subtotal + taxed;

        PrintReport(costPerSqFt, laborCost, carpet, totalLaborCost, installedPrice, discount, discountedCost, subtotal, taxed, total);
    }

    private static void PrintReport(
        decimal costPerSqFt, decimal laborCost, decimal carpet,
        decimal totalLaborCost, decimal installedPrice, 
        decimal discount, decimal discountedCost, 
        decimal subtotal, decimal taxed, decimal total)
    {
        StringBuilder sb = new();
        sb.AppendLine(string.Format("{0, 30}", "CHARGES"));
        sb.AppendLine();
        sb.AppendLine(string.Format("{0, -20} {1, 20} {2, 20}", "DESCRIPTION", "COST/SQ.FT", "CHARGE"));
        sb.AppendLine("-------------------- -------------------- --------------------");
        sb.AppendLine(string.Format("{0, -20} {1, 20:N2} {2, 20:N2}", "Carpet", costPerSqFt, carpet));
        sb.AppendLine(string.Format("{0, -20} {1, 20:N2} {2, 20:N2}", "Labour", laborCost, totalLaborCost));
        sb.AppendLine("-------------------- -------------------- --------------------");
        sb.AppendLine(string.Format("{0, -20} {1, 20} {2, 20:N2}", "Installed Price", "", installedPrice));
        sb.AppendLine(string.Format("{0, -20} {1, 19:N2}% {2, 20:N2}", "Discount", discount, discountedCost));
        sb.AppendLine("-------------------- -------------------- --------------------");
        sb.AppendLine(string.Format("{0, -20} {1, 20} {2, 20:N2}", "Subtotal", "", subtotal));
        sb.AppendLine(string.Format("{0, -20} {1, 20} {2, 20:N2}", "Tax", "", taxed));
        sb.AppendLine(string.Format("{0, -20} {1, 20} {2, 20:N2}", "TOTAL", "", total));
        
        WriteLine("The Report");
        WriteLine(sb.ToString());
    }
}
