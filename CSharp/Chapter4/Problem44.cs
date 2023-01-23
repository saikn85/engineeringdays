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
        
        decimal carpet = costPerSqFt * area;
        decimal totalLaborCost = laborCost * area;
        decimal installedPrice = carpet + totalLaborCost;
        
        decimal discountedCost = installedPrice - ((discount / 100) * installedPrice);
        decimal subtotal = totalLaborCost - discountedCost;
        
        decimal taxed = subtotal * (tax / 100);
        decimal total = subtotal + taxed;

        PrintReport(costPerSqFt, laborCost, carpet, totalLaborCost, installedPrice, discountedCost, subtotal, taxed, total);
    }

    private static void PrintReport(decimal costPerSqFt, decimal laborCost, decimal carpet, 
        decimal totalLaborCost, decimal installedPrice, decimal discountedCost, 
        decimal subtotal, decimal taxed, decimal total)
    {
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
}
