using System.Collections.Generic;
using System.Threading;

namespace StandardVesselEstimator
{
    public class FullReport
    {
        ProductInfo productInfo;
        QuoteSheet qsheet;
        ExcelItems xl;


        public FullReport()
        {
            productInfo = new ProductInfo();
            qsheet = new QuoteSheet(productInfo);
            xl = new ExcelItems();
        }


        public void run_full_report()
        {
            int headerRow = 1;
            int currentRow = 3;
            int tagCol = 1;
            int matCol = 3;
            int labCol = 5;

            xl.New_report_sheet();

            xl.worksheet.Cells[headerRow, tagCol].Value2 = "TAG";
            xl.worksheet.Cells[headerRow, matCol].Value2 = "MATERIAL COST";
            xl.worksheet.Cells[headerRow, labCol].Value2 = "LABOR COST";

            foreach (StandardVessel sv in StandardVesselList)
            {
                double materialTotal;
                double laborTotal;

                productInfo.VesselType = sv.Type;
                productInfo.Tag = sv.Tag;
                productInfo.getVesselValues();

                qsheet.Get_quote_sums(out materialTotal, out laborTotal);

                xl.worksheet.Cells[currentRow, tagCol].Value2 = sv.Tag;
                xl.worksheet.Cells[currentRow, matCol].Value2 = materialTotal;
                xl.worksheet.Cells[currentRow, labCol].Value2 = laborTotal;

                Thread.Sleep(20);
                //pbar.PerformStep();
                currentRow++;
            }
        }


        protected class StandardVessel
        {
            public string Type { get; set; }
            public string Tag { get; set; }
        }

        protected static List<StandardVessel> StandardVesselList = new List<StandardVessel>
        {
            new StandardVessel {Type = "HHPR", Tag = "HHPR20-96"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR20-144"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR24-144"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR24-192"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR30-138"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR36-141"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR42-144"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR48-147"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR48-266"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR54-150"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR54-269"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR60-153"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR60-272"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR72-159"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR72-276"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR84-165"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR84-282"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR96-171"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR96-288"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR108-177"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR108-296"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR120-183"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR120-302"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR144-195"},
            new StandardVessel {Type = "HHPR", Tag = "HHPR144-314"},

            new StandardVessel {Type = "VHPR", Tag = "VHPR20-144"},
            new StandardVessel {Type = "VHPR", Tag = "VHPR24-144"},
            new StandardVessel {Type = "VHPR", Tag = "VHPR30-138"},
            new StandardVessel {Type = "VHPR", Tag = "VHPR36-141"},
            new StandardVessel {Type = "VHPR", Tag = "VHPR42-144"},
            new StandardVessel {Type = "VHPR", Tag = "VHPR48-147"},
            new StandardVessel {Type = "VHPR", Tag = "VHPR48-195"},
            new StandardVessel {Type = "VHPR", Tag = "VHPR54-150"},
            new StandardVessel {Type = "VHPR", Tag = "VHPR54-198"},
            new StandardVessel {Type = "VHPR", Tag = "VHPR60-153"},
            new StandardVessel {Type = "VHPR", Tag = "VHPR60-201"},
            new StandardVessel {Type = "VHPR", Tag = "VHPR72-159"},
            new StandardVessel {Type = "VHPR", Tag = "VHPR72-207"},
            new StandardVessel {Type = "VHPR", Tag = "VHPR84-165"},
            new StandardVessel {Type = "VHPR", Tag = "VHPR84-213"},
            new StandardVessel {Type = "VHPR", Tag = "VHPR96-171"},
            new StandardVessel {Type = "VHPR", Tag = "VHPR96-219"},
            new StandardVessel {Type = "VHPR", Tag = "VHPR108-177"},
            new StandardVessel {Type = "VHPR", Tag = "VHPR108-225"},
            new StandardVessel {Type = "VHPR", Tag = "VHPR120-183"},
            new StandardVessel {Type = "VHPR", Tag = "VHPR120-231"},
            new StandardVessel {Type = "VHPR", Tag = "VHPR144-195"},
            new StandardVessel {Type = "VHPR", Tag = "VHPR144-243"},

            new StandardVessel {Type = "VHPTSR", Tag = "VHPTSR36-141"},
            new StandardVessel {Type = "VHPTSR", Tag = "VHPTSR48-195"},
            new StandardVessel {Type = "VHPTSR", Tag = "VHPTSR54-198"},
            new StandardVessel {Type = "VHPTSR", Tag = "VHPTSR60-201"},
            new StandardVessel {Type = "VHPTSR", Tag = "VHPTSR72-207"},
            new StandardVessel {Type = "VHPTSR", Tag = "VHPTSR84-213"},
            new StandardVessel {Type = "VHPTSR", Tag = "VHPTSR96-219"},
            new StandardVessel {Type = "VHPTSR", Tag = "VHPTSR108-225"},
            new StandardVessel {Type = "VHPTSR", Tag = "VHPTSR120-231"},
            new StandardVessel {Type = "VHPTSR", Tag = "VHPTSR144-243"},

            new StandardVessel {Type = "HTSR", Tag = "HTSR8-48"},
            new StandardVessel {Type = "HTSR", Tag = "HTSR10-48"},
            new StandardVessel {Type = "HTSR", Tag = "HTSR12-48"},
            new StandardVessel {Type = "HTSR", Tag = "HTSR12-72"},
            new StandardVessel {Type = "HTSR", Tag = "HTSR16-72"},
            new StandardVessel {Type = "HTSR", Tag = "HTSR20-72"},
            new StandardVessel {Type = "HTSR", Tag = "HTSR24-72"},
            new StandardVessel {Type = "HTSR", Tag = "HTSR30-84"},
            new StandardVessel {Type = "HTSR", Tag = "HTSR36-96"},
            new StandardVessel {Type = "HTSR", Tag = "HTSR42-120"},
            new StandardVessel {Type = "HTSR", Tag = "HTSR48-147"},

            new StandardVessel {Type = "VTSR", Tag = "VTSR8-48"},
            new StandardVessel {Type = "VTSR", Tag = "VTSR10-48"},
            new StandardVessel {Type = "VTSR", Tag = "VTSR12-48"},
            new StandardVessel {Type = "VTSR", Tag = "VTSR12-72"},
            new StandardVessel {Type = "VTSR", Tag = "VTSR16-72"},
            new StandardVessel {Type = "VTSR", Tag = "VTSR20-72"},
            new StandardVessel {Type = "VTSR", Tag = "VTSR24-72"},
            new StandardVessel {Type = "VTSR", Tag = "VTSR30-84"},

            new StandardVessel {Type = "VCPR", Tag = "VCPR20-144"},
            new StandardVessel {Type = "VCPR", Tag = "VCPR24-144"},
            new StandardVessel {Type = "VCPR", Tag = "VCPR30-138"},
            new StandardVessel {Type = "VCPR", Tag = "VCPR36-141"},
            new StandardVessel {Type = "VCPR", Tag = "VCPR42-144"},
            new StandardVessel {Type = "VCPR", Tag = "VCPR48-147"},
            new StandardVessel {Type = "VCPR", Tag = "VCPR54-150"},
            new StandardVessel {Type = "VCPR", Tag = "VCPR60-153"},
            new StandardVessel {Type = "VCPR", Tag = "VCPR72-159"},
            new StandardVessel {Type = "VCPR", Tag = "VCPR84-165"},
            new StandardVessel {Type = "VCPR", Tag = "VCPR96-171"},

            new StandardVessel {Type = "VPR", Tag = "VPR10-48"},
            new StandardVessel {Type = "VPR", Tag = "VPR12-48"},
            new StandardVessel {Type = "VPR", Tag = "VPR16-60"},
            new StandardVessel {Type = "VPR", Tag = "VPR20-60"},
            new StandardVessel {Type = "VPR", Tag = "VPR24-72"},

            new StandardVessel {Type = "VR", Tag = "VR24-112"},
            new StandardVessel {Type = "VR", Tag = "VR30-115"},
            new StandardVessel {Type = "VR", Tag = "VR36-118"},
            new StandardVessel {Type = "VR", Tag = "VR42-144"},
            new StandardVessel {Type = "VR", Tag = "VR48-147"},
            new StandardVessel {Type = "VR", Tag = "VR54-150"},
            new StandardVessel {Type = "VR", Tag = "VR60-153"},
            new StandardVessel {Type = "VR", Tag = "VR72-159"},
            new StandardVessel {Type = "VR", Tag = "VR84-165"},
            new StandardVessel {Type = "VR", Tag = "VR96-171"},
            new StandardVessel {Type = "VR", Tag = "VR108-177"},
            new StandardVessel {Type = "VR", Tag = "VR120-183"},
            new StandardVessel {Type = "VR", Tag = "VR144-195"},

            new StandardVessel {Type = "HR", Tag = "HR24-135"},
            new StandardVessel {Type = "HR", Tag = "HR30-138"},
            new StandardVessel {Type = "HR", Tag = "HR36-141"},
            new StandardVessel {Type = "HR", Tag = "HR42-144"},
            new StandardVessel {Type = "HR", Tag = "HR48-147"},
            new StandardVessel {Type = "HR", Tag = "HR54-150"},
            new StandardVessel {Type = "HR", Tag = "HR60-153"},
            new StandardVessel {Type = "HR", Tag = "HR72-159"},
            new StandardVessel {Type = "HR", Tag = "HR84-165"},
            new StandardVessel {Type = "HR", Tag = "HR96-171"},
            new StandardVessel {Type = "HR", Tag = "HR108-177"},
            new StandardVessel {Type = "HR", Tag = "HR120-183"},
            new StandardVessel {Type = "HR", Tag = "HR144-195"},

            new StandardVessel {Type = "VI", Tag = "VI16-96"},
            new StandardVessel {Type = "VI", Tag = "VI20-108"},
            new StandardVessel {Type = "VI", Tag = "VI24-112"},
            new StandardVessel {Type = "VI", Tag = "VI30-115"},
            new StandardVessel {Type = "VI", Tag = "VI36-118"},
            new StandardVessel {Type = "VI", Tag = "VI42-144"},
            new StandardVessel {Type = "VI", Tag = "VI48-147"},
            new StandardVessel {Type = "VI", Tag = "VI54-150"},
            new StandardVessel {Type = "VI", Tag = "VI60-153"},
            new StandardVessel {Type = "VI", Tag = "VI72-159"},
            new StandardVessel {Type = "VI", Tag = "VI84-165"},
            new StandardVessel {Type = "VI", Tag = "VI96-171"},
            new StandardVessel {Type = "VI", Tag = "VI108-177"},
            new StandardVessel {Type = "VI", Tag = "VI120-183"},
            new StandardVessel {Type = "VI", Tag = "VI144-195"},

            new StandardVessel {Type = "VIC", Tag = "VIC16-96"},
            new StandardVessel {Type = "VIC", Tag = "VIC20-108"},
            new StandardVessel {Type = "VIC", Tag = "VIC24-112"},
            new StandardVessel {Type = "VIC", Tag = "VIC30-115"},
            new StandardVessel {Type = "VIC", Tag = "VIC36-118"},
            new StandardVessel {Type = "VIC", Tag = "VIC42-144"},
            new StandardVessel {Type = "VIC", Tag = "VIC48-147"},
            new StandardVessel {Type = "VIC", Tag = "VIC54-150"},
            new StandardVessel {Type = "VIC", Tag = "VIC60-153"},
            new StandardVessel {Type = "VIC", Tag = "VIC72-159"},
            new StandardVessel {Type = "VIC", Tag = "VIC84-165"},
            new StandardVessel {Type = "VIC", Tag = "VIC96-171"},
            new StandardVessel {Type = "VIC", Tag = "VIC108-177"},
            new StandardVessel {Type = "VIC", Tag = "VIC120-183"},
            new StandardVessel {Type = "VIC", Tag = "VIC144-195"},

            new StandardVessel {Type = "HA", Tag = "HA24-135"},
            new StandardVessel {Type = "HA", Tag = "HA30-138"},
            new StandardVessel {Type = "HA", Tag = "HA36-141"},
            new StandardVessel {Type = "HA", Tag = "HA42-144"},
            new StandardVessel {Type = "HA", Tag = "HA48-147"},
            new StandardVessel {Type = "HA", Tag = "HA54-150"},
            new StandardVessel {Type = "HA", Tag = "HA60-153"},
            new StandardVessel {Type = "HA", Tag = "HA72-159"},
            new StandardVessel {Type = "HA", Tag = "HA84-165"},
            new StandardVessel {Type = "HA", Tag = "HA96-171"},
            new StandardVessel {Type = "HA", Tag = "HA108-177"},
            new StandardVessel {Type = "HA", Tag = "HA120-183"},
            new StandardVessel {Type = "HA", Tag = "HA144-195"},

            new StandardVessel {Type = "VA", Tag = "VA12-72"},
            new StandardVessel {Type = "VA", Tag = "VA16-85"},
            new StandardVessel {Type = "VA", Tag = "VA20-87"},
            new StandardVessel {Type = "VA", Tag = "VA24-88"},
            new StandardVessel {Type = "VA", Tag = "VA30-115"},
            new StandardVessel {Type = "VA", Tag = "VA36-118"},
            new StandardVessel {Type = "VA", Tag = "VA42-121"},
            new StandardVessel {Type = "VA", Tag = "VA48-147"},
            new StandardVessel {Type = "VA", Tag = "VA54-150"},
            new StandardVessel {Type = "VA", Tag = "VA60-153"},
            new StandardVessel {Type = "VA", Tag = "VA72-159"},
            new StandardVessel {Type = "VA", Tag = "VA84-165"},
            new StandardVessel {Type = "VA", Tag = "VA96-171"},
            new StandardVessel {Type = "VA", Tag = "VA108-177"},
            new StandardVessel {Type = "VA", Tag = "VA120-183"},
            new StandardVessel {Type = "VA", Tag = "VA144-195"},

            new StandardVessel {Type = "VAC", Tag = "VAC16-85"},
            new StandardVessel {Type = "VAC", Tag = "VAC20-87"},
            new StandardVessel {Type = "VAC", Tag = "VAC24-88"},
            new StandardVessel {Type = "VAC", Tag = "VAC30-115"},
            new StandardVessel {Type = "VAC", Tag = "VAC36-118"},
            new StandardVessel {Type = "VAC", Tag = "VAC42-121"},
            new StandardVessel {Type = "VAC", Tag = "VAC48-147"},
            new StandardVessel {Type = "VAC", Tag = "VAC54-150"},
            new StandardVessel {Type = "VAC", Tag = "VAC60-153"},
            new StandardVessel {Type = "VAC", Tag = "VAC72-159"},
            new StandardVessel {Type = "VAC", Tag = "VAC84-165"},
            new StandardVessel {Type = "VAC", Tag = "VAC96-171"},
            new StandardVessel {Type = "VAC", Tag = "VAC108-177"},
            new StandardVessel {Type = "VAC", Tag = "VAC120-183"},
            new StandardVessel {Type = "VAC", Tag = "VAC144-195"},

            new StandardVessel {Type = "VSD", Tag = "VSD12-48"},
            new StandardVessel {Type = "VSD", Tag = "VSD16-54"},
            new StandardVessel {Type = "VSD", Tag = "VSD20-60"},
            new StandardVessel {Type = "VSD", Tag = "VSD24-60"},
            new StandardVessel {Type = "VSD", Tag = "VSD30-72"},
            new StandardVessel {Type = "VSD", Tag = "VSD36-78"},
            new StandardVessel {Type = "VSD", Tag = "VSD42-84"},

            new StandardVessel {Type = "HSD", Tag = "HSD12-48"},
            new StandardVessel {Type = "HSD", Tag = "HSD16-60"},
            new StandardVessel {Type = "HSD", Tag = "HSD20-72"},
            new StandardVessel {Type = "HSD", Tag = "HSD24-72"},
            new StandardVessel {Type = "HSD", Tag = "HSD30-96"},
            new StandardVessel {Type = "HSD", Tag = "HSD36-96"},
            new StandardVessel {Type = "HSD", Tag = "HSD42-120"},

            new StandardVessel {Type = "MHSD", Tag = "MHSD20-96"},
            new StandardVessel {Type = "MHSD", Tag = "MHSD24-96"},
            new StandardVessel {Type = "MHSD", Tag = "MHSD30-96"},
            new StandardVessel {Type = "MHSD", Tag = "MHSD36-96"},
            new StandardVessel {Type = "MHSD", Tag = "MHSD42-96"},
            new StandardVessel {Type = "MHSD", Tag = "MHSD48-120"},
            new StandardVessel {Type = "MHSD", Tag = "MHSD54-144"},
            new StandardVessel {Type = "MHSD", Tag = "MHSD60-144"},

            new StandardVessel {Type = "HOP", Tag = "HOP8-36"},
            new StandardVessel {Type = "HOP", Tag = "HOP10-36"}
        };
    }
}
