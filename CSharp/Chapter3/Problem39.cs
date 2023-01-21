using System.Text;
using static System.Console;

namespace EngineeringDays.Chapter3;

internal static class Problem39
{
    public static void GenerateBill()
    {
        const decimal tvPrice = 400.00m;
        const decimal vcrPrice = 220.00m;
        const decimal rcPrice = 35.20m;
        const decimal cdPrice = 300.00m;
        const decimal tpPrice = 150.00m;
        const decimal tax = 8.25m;

        WriteLine("Please enter the quantities sold for the following products");
        Write("Units of TV Sold: ");
        string tvUnits = ReadLine() ?? "10";
        Write("Units of VCR Sold: ");
        string? vcrUnits = ReadLine() ?? "10";
        Write("Units of RC Sold: ");
        string? rcUnits = ReadLine() ?? "10";
        Write("Units of CD Player Sold: ");
        string? cdUnits = ReadLine() ?? "10";
        Write("Units of Tape Recorder Sold: ");
        string? tpUnits = ReadLine() ?? "10";


        if (!byte.TryParse(tvUnits, out byte tvUnitsSold))
        {
            WriteLine("Enter the valid units of TV sold!");
            return;
        }
        if (!byte.TryParse(vcrUnits, out byte vcrUnitsSold))
        {
            WriteLine("Enter the valid units of VCR sold!");
            return;
        }
        if (!byte.TryParse(rcUnits, out byte rcUnitsSold))
        {
            WriteLine("Enter the valid units of RC sold!");
            return;
        }
        if (!byte.TryParse(cdUnits, out byte cdUnitsSold))
        {
            WriteLine("Enter the valid units of CD sold!");
            return;
        }
        if (!byte.TryParse(tpUnits, out byte tpUnitsSold))
        {
            WriteLine("Enter the valid units of Tape Recorder sold!");
            return;
        }

        decimal tvTotal = tvPrice * tvUnitsSold;
        decimal vcrTotal = vcrPrice * vcrUnitsSold;
        decimal rcTotal = rcPrice * rcUnitsSold;
        decimal cdTotal = cdPrice * cdUnitsSold;
        decimal tpTotal = tpPrice * tpUnitsSold;
        decimal subTotal = tvTotal + vcrTotal + rcTotal + cdTotal + tpTotal;
        decimal total = subTotal * (1 + tax);

        StringBuilder sb = new();
        sb.AppendLine("Description\tQuantity\tUnit Price\tTotal Price");
        sb.AppendLine("-------------\t--------\t----------\t-----------");
        sb.AppendLine(string.Format("{0, 13}\t{1, 8}\t{2, 10:N2}\t{3, 11:N2}", "TV", tvUnitsSold, tvPrice, tvTotal));
        sb.AppendLine(string.Format("{0, 13}\t{1, 8}\t{2, 10:N2}\t{3, 11:N2}", "VCR", vcrUnitsSold, vcrPrice, vcrTotal));
        sb.AppendLine(string.Format("{0, 13}\t{1, 8}\t{2, 10:N2}\t{3, 11:N2}", "RC", rcUnitsSold, rcPrice, rcTotal));
        sb.AppendLine(string.Format("{0, 13}\t{1, 8}\t{2, 10:N2}\t{3, 11:N2}", "CD", cdUnitsSold, cdPrice, cdTotal));
        sb.AppendLine(string.Format("{0, 13}\t{1, 8}\t{2, 10:N2}\t{3, 11:N2}", "Tape Recorder", tpUnitsSold, tpPrice, tpTotal));
        sb.AppendLine("-------------\t--------\t----------\t-----------");
        sb.AppendLine(string.Format("{0, 13}\t{1, 8}\t{2, -10:N2}\t{3, 11:N2}", "", "", "Sub Total", subTotal));
        sb.AppendLine(string.Format("{0, 13}\t{1, 8}\t{2, -10:N2}\t{3, 11:N2}", "", "", "Tax", tax));
        sb.AppendLine(string.Format("{0, 13}\t{1, 8}\t{2, -10:N2}\t{3, 11:N2}", "", "", "Total", total));

        WriteLine("The Report");
        WriteLine(sb.ToString());
    }
}
