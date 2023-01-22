using System.Text;
using static System.Console;

namespace EngineeringDays.Chapter4;

internal static class Problem44
{
    public static void GenerateBillForCarpetCleaning()
    {
        ReadValues(out byte length, out byte width, out decimal discount, out decimal costPerSqFt);
        decimal installedPrice = ComputeInstalledPrice(length, width, costPerSqFt);

        StringBuilder sb = new();
        //sb.AppendLine("Description\tQuantity\tUnit Price\tTotal Price");
        //sb.AppendLine("-------------\t--------\t----------\t-----------");
        //sb.AppendLine(string.Format("{0, -13}\t{1, 8}\t{2, 10:N2}\t{3, 11:N2}", "TV", tvUnitsSold, tvPrice, tvTotal));
        //sb.AppendLine(string.Format("{0, -13}\t{1, 8}\t{2, 10:N2}\t{3, 11:N2}", "VCR", vcrUnitsSold, vcrPrice, vcrTotal));
        //sb.AppendLine(string.Format("{0, -13}\t{1, 8}\t{2, 10:N2}\t{3, 11:N2}", "RC", rcUnitsSold, rcPrice, rcTotal));
        //sb.AppendLine(string.Format("{0, -13}\t{1, 8}\t{2, 10:N2}\t{3, 11:N2}", "CD", cdUnitsSold, cdPrice, cdTotal));
        //sb.AppendLine(string.Format("{0, -13}\t{1, 8}\t{2, 10:N2}\t{3, 11:N2}", "Tape Recorder", tpUnitsSold, tpPrice, tpTotal));
        //sb.AppendLine("-------------\t--------\t----------\t-----------");
        //sb.AppendLine(string.Format("{0, -13}\t{1, 8}\t{2, -10:N2}\t{3, 11:N2}", "", "", "Sub Total", subTotal));
        //sb.AppendLine(string.Format("{0, -13}\t{1, 8}\t{2, -10:N2}\t{3, 11:N2}", "", "", "Tax", tax));
        //sb.AppendLine(string.Format("{0, -13}\t{1, 8}\t{2, -10:N2}\t{3, 11:N2}", "", "", "Total", total));

        WriteLine("The Report");
        WriteLine(sb.ToString());
    }

    private static decimal ComputeInstalledPrice(byte length, byte width, decimal costPerSqFt)
    {
        const decimal laborCost = 0.35m;
        byte area = (byte)(length * width);
    }

    private static void ReadValues(out byte length, out byte width, out decimal discount, out decimal costPerSqFt)
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

        if (!byte.TryParse(len, out length))
            length = 1;
        if (!byte.TryParse(wdt, out width))
            width = 1;
        if (!decimal.TryParse(dis, out discount))
            discount = 0.00m;
        if (!decimal.TryParse(cost, out costPerSqFt))
            costPerSqFt = 12.50m;
    }
}
