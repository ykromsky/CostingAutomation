
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace StandardVesselEstimator
{
    class QuoteBody
    {
        public QuoteSheet qs;
        public ExcelItems xl;
        private List<ListItem> ListItems;

        private HHPR hhpr;
        private VHPR vhpr;
        private VHPTSR vhptsr;
        private HTSR htsr;
        private VTSR vtsr;
        private VCPR vcpr;
        private VPR vpr;
        private VR vr;
        private HR hr;
        private VI vi;
        private VIC vic;
        private HA ha;
        private VA va;
        private VAC vac;
        private VSD vsd;
        private HSD hsd;
        private MHSD mhsd;
        private HOP hop;

        private MRP_V mrp_v;
        private MRP_H mrp_h;
        private MPC mpc;
        private MVI mvi;
        private MVIC mvic;

        private LiqFeed lf;

        public QuoteBody(QuoteSheet quoteSheet, ExcelItems excelItems)
        {
            qs = quoteSheet;
            xl = excelItems;
        }


        public void Write_quote_body()
        {
            switch (qs.productInfo.productClass)
            {
                case "vessel":
                    Write_headers();

                    Assemble_vessel_list();

                    Write_list_to_sheet();

                    Write_department_sum();

                    Format_quote_body();
                    break;

                case "package":
                    Write_headers();

                    Assemble_package_list();

                    Write_list_to_sheet();

                    Format_package_quote_body();
                    break;

                case "liquid feed":
                    Write_headers();

                    lf = new LiqFeed(qs.productInfo);

                    ListItems = lf.lfList();

                    Write_list_to_sheet();

                    Format_quote_body();
                    break;

                default: break;
            }
        }


        private void Write_headers()
        {
            xl.Cell_value(qs.headerRow, qs.quantityCol, "QTY");
            xl.Cell_value(qs.headerRow, qs.descriptionCol, "DESCRIPTION");
            xl.Cell_value(qs.headerRow, qs.serviceCol, "SERVICE/PROCESS");
            xl.Cell_value(qs.headerRow, qs.materialCol, "MATERIAL");
            xl.Cell_value(qs.headerRow, qs.sizeCol, "SIZE");
            xl.Cell_value(qs.headerRow, qs.ratingCol, "RATING");
            xl.Cell_value(qs.headerRow, qs.lengthCol, "LENGTH");

            xl.Cell_value(qs.headerRow, qs.aCol, "A");
            xl.Cell_value(qs.headerRow, qs.bCol, "B");
            xl.Cell_value(qs.headerRow, qs.cCol, "C");
            xl.Cell_value(qs.headerRow, qs.unitsCol, "UNITS");
            xl.Cell_value(qs.headerRow, qs.partNumCol, "PART #");
            xl.Cell_value(qs.headerRow, qs.partPriceCol, "PART $/UNIT");
            xl.Cell_value(qs.headerRow, qs.materialPriceCol, "MATERIAL $/EA");

            xl.Cell_value(qs.headerRow, qs.plasmaLaborCol, "PLASMA");
            xl.Cell_value(qs.headerRow, qs.rollerLaborCol, "ROLLER");
            xl.Cell_value(qs.headerRow, qs.subarcLaborCol, "SUBARC");
            xl.Cell_value(qs.headerRow, qs.cuttingLaborCol, "CUTTING");
            xl.Cell_value(qs.headerRow, qs.blastLaborCol, "BLAST");
            xl.Cell_value(qs.headerRow, qs.welderLaborCol, "WELDER");
            xl.Cell_value(qs.headerRow, qs.hoursCol, "HOURS");
        }


        private void Format_quote_body()
        {
            //set column widths
            //xl.worksheet.Cells[1, 1].ColumnWidth = 10;
            xl.worksheet.Cells[1, qs.quantityCol].ColumnWidth = 6;
            xl.worksheet.Cells[1, qs.descriptionCol].ColumnWidth = 26;
            xl.worksheet.Cells[1, qs.serviceCol].ColumnWidth = 35;
            xl.worksheet.Cells[1, qs.materialCol].ColumnWidth = 20;
            xl.worksheet.Cells[1, qs.sizeCol].ColumnWidth = 12;
            xl.worksheet.Cells[1, qs.ratingCol].ColumnWidth = 12;
            xl.worksheet.Cells[1, qs.lengthCol].ColumnWidth = 12;

            xl.worksheet.Cells[1, qs.materialBufferCol].ColumnWidth = 12;
            xl.worksheet.Cells[1, qs.aCol].ColumnWidth = 8;
            xl.worksheet.Cells[1, qs.bCol].ColumnWidth = 8;
            xl.worksheet.Cells[1, qs.cCol].ColumnWidth = 8;
            xl.worksheet.Cells[1, qs.unitsCol].ColumnWidth = 8;
            xl.worksheet.Cells[1, qs.partNumCol].ColumnWidth = 12;
            xl.worksheet.Cells[1, qs.partPriceCol].ColumnWidth = 14;
            xl.worksheet.Cells[1, qs.materialPriceCol].ColumnWidth = 14;

            xl.worksheet.Cells[1, qs.laborBufferCol].ColumnWidth = 12;
            xl.worksheet.Cells[1, qs.plasmaLaborCol].ColumnWidth = 8;
            xl.worksheet.Cells[1, qs.hoursCol].ColumnWidth = 8;

            ////hide material calculation columns
            //xl.range = xl.Select_range(1, qs.aCol, 1, qs.partPriceCol);
            //xl.range.EntireColumn.Hidden = true;

            //format column headers
            xl.range = xl.Select_range(qs.headerRow, qs.firstCol, qs.headerRow, qs.lastCol);
            xl.range.Font.Bold = true;
            xl.range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            //set top boundary
            xl.range = xl.Select_range(qs.headerRow + 1, qs.firstCol, qs.headerRow + 1, qs.lastCol);
            xl.range.EntireRow.RowHeight = 3;
            xl.range.Interior.Color = Excel.XlRgbColor.rgbBlack;

            //set bottom boundary
            xl.range = xl.Select_range(qs.lastRow + 1, qs.firstCol, qs.lastRow + 1, qs.lastCol);
            xl.range.EntireRow.RowHeight = 3;
            xl.range.Interior.Color = Excel.XlRgbColor.rgbBlack;

            //format item cells
            xl.range = xl.Select_range(qs.firstRow, qs.firstCol, qs.lastRow, qs.lastCol);
            xl.range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            xl.range = xl.Select_range(qs.firstRow, qs.partPriceCol, qs.lastRow, qs.partPriceCol);
            xl.range.Style = xl.workbook.Styles["Currency"];
            xl.range = xl.Select_range(qs.firstRow, qs.materialPriceCol, qs.lastRow, qs.materialPriceCol);
            xl.range.Style = xl.workbook.Styles["Currency"];
        }


        private void Format_package_quote_body()
        {
            //set column widths
            //xl.worksheet.Cells[1, 1].ColumnWidth = 10;
            xl.worksheet.Cells[1, qs.quantityCol].ColumnWidth = 6;
            xl.worksheet.Cells[1, qs.descriptionCol].ColumnWidth = 26;
            xl.worksheet.Cells[1, qs.serviceCol].ColumnWidth = 35;
            xl.worksheet.Cells[1, qs.materialCol].ColumnWidth = 20;
            xl.worksheet.Cells[1, qs.sizeCol].ColumnWidth = 12;
            xl.worksheet.Cells[1, qs.ratingCol].ColumnWidth = 12;
            xl.worksheet.Cells[1, qs.lengthCol].ColumnWidth = 12;

            xl.worksheet.Cells[1, qs.materialBufferCol].ColumnWidth = 12;
            xl.worksheet.Cells[1, qs.aCol].ColumnWidth = 8;
            xl.worksheet.Cells[1, qs.bCol].ColumnWidth = 8;
            xl.worksheet.Cells[1, qs.cCol].ColumnWidth = 8;
            xl.worksheet.Cells[1, qs.unitsCol].ColumnWidth = 8;
            xl.worksheet.Cells[1, qs.partNumCol].ColumnWidth = 12;
            xl.worksheet.Cells[1, qs.partPriceCol].ColumnWidth = 14;
            xl.worksheet.Cells[1, qs.materialPriceCol].ColumnWidth = 14;

            xl.worksheet.Cells[1, qs.laborBufferCol].ColumnWidth = 12;
            xl.worksheet.Cells[1, qs.plasmaLaborCol].ColumnWidth = 8;
            xl.worksheet.Cells[1, qs.hoursCol].ColumnWidth = 8;

            ////hide material calculation columns
            //xl.range = xl.Select_range(1, qs.aCol, 1, qs.partPriceCol);
            //xl.range.EntireColumn.Hidden = true;

            //format column headers
            xl.range = xl.Select_range(qs.headerRow, qs.firstCol, qs.headerRow, qs.lastCol);
            xl.range.Font.Bold = true;
            xl.range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            //set top boundary
            xl.range = xl.Select_range(qs.headerRow + 1, qs.firstCol, qs.headerRow + 1, qs.lastCol);
            xl.range.EntireRow.RowHeight = 3;
            xl.range.Interior.Color = Excel.XlRgbColor.rgbBlack;

            //set bottom boundary
            xl.range = xl.Select_range(qs.lastRow + 1, qs.firstCol, qs.lastRow + 1, qs.lastCol);
            xl.range.EntireRow.RowHeight = 3;
            xl.range.Interior.Color = Excel.XlRgbColor.rgbBlack;

            //format item cells
            xl.range = xl.Select_range(qs.firstRow, qs.firstCol, qs.lastRow, qs.lastCol);
            xl.range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            xl.range = xl.Select_range(qs.firstRow, qs.partPriceCol, qs.lastRow, qs.partPriceCol);
            xl.range.Style = xl.workbook.Styles["Currency"];
            xl.range = xl.Select_range(qs.firstRow, qs.materialPriceCol, qs.lastRow, qs.materialPriceCol);
            xl.range.Style = xl.workbook.Styles["Currency"];
        }


        private void Write_list_to_sheet()
        {
            foreach (ListItem item in ListItems) { Write_item(item); }
        }


        private void Write_item(ListItem item)
        {
            xl.Switch_to_R1C1();

            xl.Cell_value(qs.lastRow, qs.quantityCol, item.Quantity);
            xl.Cell_value(qs.lastRow, qs.descriptionCol, item.Description);
            xl.Cell_value(qs.lastRow, qs.serviceCol, item.Service);
            xl.Cell_value(qs.lastRow, qs.materialCol, item.Material);
            xl.Cell_value(qs.lastRow, qs.sizeCol, item.Size);
            xl.Cell_value(qs.lastRow, qs.ratingCol, item.Rating);
            xl.Cell_value(qs.lastRow, qs.lengthCol, item.Length);

            xl.Cell_value(qs.lastRow, qs.aCol, item.A);
            xl.Cell_value(qs.lastRow, qs.bCol, item.B);
            xl.Cell_value(qs.lastRow, qs.cCol, item.C);
            xl.Cell_value(qs.lastRow, qs.unitsCol, item.Units);
            xl.Cell_value(qs.lastRow, qs.partNumCol, item.PartNumber);
            xl.Cell_value(qs.lastRow, qs.partPriceCol, item.PriceEach);
            xl.Cell_value(qs.lastRow, qs.materialPriceCol, item.PriceTotal);

            xl.Cell_value(qs.lastRow, qs.plasmaLaborCol, item.PlasmaLabor);
            xl.Cell_value(qs.lastRow, qs.rollerLaborCol, item.RollingLabor);
            xl.Cell_value(qs.lastRow, qs.subarcLaborCol, item.SubarcLabor);
            xl.Cell_value(qs.lastRow, qs.cuttingLaborCol, item.CuttingLabor);
            xl.Cell_value(qs.lastRow, qs.blastLaborCol, item.BlastLabor);
            xl.Cell_value(qs.lastRow, qs.welderLaborCol, item.WelderLabor);
            xl.Cell_value(qs.lastRow, qs.hoursCol, item.Hours);

            xl.Switch_to_A1();

            if (item.Description == "SECTION A") qs.sectionARow = qs.lastRow;
            if (item.Description == "SECTION B") qs.sectionBRow = qs.lastRow;
            qs.lastRow++;  
        }


        private void Write_department_sum()
        {
            string f_department_sum = "";
            int departmentSumRow = qs.lastRow + 2;
            int relFirstRow = qs.firstRow - departmentSumRow;
            int relLastRow = qs.lastRow - departmentSumRow;

            xl.Switch_to_R1C1();

            for (int column = qs.plasmaLaborCol; column <= qs.hoursCol; column++)
            {
                int relQuantityCol = qs.quantityCol - column;

                f_department_sum = "=SUMPRODUCT(R[" + relFirstRow + "]C:R[" + relLastRow + "]C," +
                                               "R[" + relFirstRow + "]C[" + relQuantityCol + "]:R[" + relLastRow + "]C[" + relQuantityCol + "])";
                xl.Cell_value(departmentSumRow, column, f_department_sum);
            }

            xl.range = xl.Select_range(departmentSumRow, qs.hoursCol, departmentSumRow, qs.hoursCol);
            xl.range.Font.Bold = true;

            xl.Switch_to_A1();
        }


        private List<ListItem> empty_list()
        {
            List<ListItem> emptyList = new List<ListItem>();
            return emptyList;
        }


        private void Assemble_vessel_list()
        {
            switch (qs.productInfo.VesselType)
            {
                case "HHPR":
                    assemble_hhpr();
                    break;

                case "VHPR":
                    assemble_vhpr();
                    break;

                case "VHPTSR":
                    assemble_vhptsr();
                    break;
                    
                case "HTSR":
                    assemble_htsr();
                    break;

                case "VTSR":
                    assemble_vtsr();
                    break;

                case "VCPR":
                    assemble_vcpr();
                    break;

                case "VPR":
                    assemble_vpr();
                    break;

                case "VR":
                    assemble_vr();
                    break;

                case "HR":
                    assemble_hr();
                    break;

                case "VI":
                    assemble_vi();
                    break;

                case "VIC":
                    assemble_vic();
                    break;

                case "HA":
                    assemble_ha();
                    break;

                case "VA":
                    assemble_va();
                    break;

                case "VAC":
                    assemble_vac();
                    break;

                case "VSD":
                    assemble_vsd();
                    break;

                case "HSD":
                    assemble_hsd();
                    break;

                case "MHSD":
                    assemble_mhsd();
                    break;

                case "HOP":
                    assemble_hop();
                    break;

                default:
                    break;
            }
        }


        private void assemble_hhpr()
        {
            hhpr = new HHPR(qs.productInfo);
            switch (qs.productInfo.Tag)
            {
                case "HHPR20-96":
                    ListItems = hhpr.HHPR_20_96();
                    break;

                case "HHPR20-144":
                    ListItems = hhpr.HHPR_20_144();
                    break;

                case "HHPR24-144":
                    ListItems = hhpr.HHPR_24_144();
                    break;

                case "HHPR24-192":
                    ListItems = hhpr.HHPR_24_192();
                    break;

                case "HHPR30-138":
                    ListItems = hhpr.HHPR_30_138();
                    break;

                case "HHPR36-141":
                    ListItems = hhpr.HHPR_36_141();
                    break;

                case "HHPR42-144":
                    ListItems = hhpr.HHPR_42_144();
                    break;

                case "HHPR48-147":
                    ListItems = hhpr.HHPR_48_147();
                    break;

                case "HHPR48-266":
                    ListItems = hhpr.HHPR_48_266();
                    break;

                case "HHPR54-150":
                    ListItems = hhpr.HHPR_54_150();
                    break;

                case "HHPR54-269":
                    ListItems = hhpr.HHPR_54_269();
                    break;

                case "HHPR60-153":
                    ListItems = hhpr.HHPR_60_153();
                    break;

                case "HHPR60-272":
                    ListItems = hhpr.HHPR_60_272();
                    break;

                case "HHPR72-159":
                    ListItems = hhpr.HHPR_72_159();
                    break;

                case "HHPR72-276":
                    ListItems = hhpr.HHPR_72_276();
                    break;

                case "HHPR84-165":
                    ListItems = hhpr.HHPR_84_165();
                    break;

                case "HHPR84-282":
                    ListItems = hhpr.HHPR_84_282();
                    break;

                case "HHPR96-171":
                    ListItems = hhpr.HHPR_96_171();
                    break;

                case "HHPR96-288":
                    ListItems = hhpr.HHPR_96_288();
                    break;

                case "HHPR108-177":
                    ListItems = hhpr.HHPR_108_177();
                    break;

                case "HHPR108-296":
                    ListItems = hhpr.HHPR_108_296();
                    break;

                case "HHPR120-183":
                    ListItems = hhpr.HHPR_120_183();
                    break;

                case "HHPR120-302":
                    ListItems = hhpr.HHPR_120_302();
                    break;

                case "HHPR144-195":
                    ListItems = hhpr.HHPR_144_195();
                    break;

                case "HHPR144-314":
                    ListItems = hhpr.HHPR_144_314();
                    break;

                default:
                    ListItems = empty_list();
                    break;
            }
        }


        private void assemble_vhpr()
        {
            vhpr = new VHPR(qs.productInfo);
            switch (qs.productInfo.Tag)
            {
                case "VHPR20-144":
                    ListItems = vhpr.VHPR_20_144();
                    break;

                case "VHPR24-144":
                    ListItems = vhpr.VHPR_24_144();
                    break;

                case "VHPR30-138":
                    ListItems = vhpr.VHPR_30_138();
                    break;

                case "VHPR36-141":
                    ListItems = vhpr.VHPR_36_141();
                    break;

                case "VHPR42-144":
                    ListItems = vhpr.VHPR_42_144();
                    break;

                case "VHPR48-147":
                    ListItems = vhpr.VHPR_48_147();
                    break;

                case "VHPR48-195":
                    ListItems = vhpr.VHPR_48_195();
                    break;

                case "VHPR54-150":
                    ListItems = vhpr.VHPR_54_150();
                    break;

                case "VHPR54-198":
                    ListItems = vhpr.VHPR_54_198();
                    break;

                case "VHPR60-153":
                    ListItems = vhpr.VHPR_60_153();
                    break;

                case "VHPR60-201":
                    ListItems = vhpr.VHPR_60_201();
                    break;

                case "VHPR72-159":
                    ListItems = vhpr.VHPR_72_159();
                    break;

                case "VHPR72-207":
                    ListItems = vhpr.VHPR_72_207();
                    break;

                case "VHPR84-165":
                    ListItems = vhpr.VHPR_84_165();
                    break;

                case "VHPR84-213":
                    ListItems = vhpr.VHPR_84_213();
                    break;

                case "VHPR96-171":
                    ListItems = vhpr.VHPR_96_171();
                    break;

                case "VHPR96-219":
                    ListItems = vhpr.VHPR_96_219();
                    break;

                case "VHPR108-177":
                    ListItems = vhpr.VHPR_108_177();
                    break;

                case "VHPR108-225":
                    ListItems = vhpr.VHPR_108_225();
                    break;

                case "VHPR120-183":
                    ListItems = vhpr.VHPR_120_183();
                    break;

                case "VHPR120-231":
                    ListItems = vhpr.VHPR_120_231();
                    break;

                case "VHPR144-195":
                    ListItems = vhpr.VHPR_144_195();
                    break;

                case "VHPR144-243":
                    ListItems = vhpr.VHPR_144_243();
                    break;

                default:
                    ListItems = empty_list();
                    break;
            }
        }


        private void assemble_vhptsr()
        {
            vhptsr = new VHPTSR(qs.productInfo);
            switch (qs.productInfo.Tag)
            {
                case "VHPTSR36-141":
                    ListItems = vhptsr.VHPTSR_36_141();
                    break;

                case "VHPTSR48-195":
                    ListItems = vhptsr.VHPTSR_48_195();
                    break;

                case "VHPTSR54-198":
                    ListItems = vhptsr.VHPTSR_54_198();
                    break;

                case "VHPTSR60-201":
                    ListItems = vhptsr.VHPTSR_60_201();
                    break;

                case "VHPTSR72-207":
                    ListItems = vhptsr.VHPTSR_72_207();
                    break;

                case "VHPTSR84-213":
                    ListItems = vhptsr.VHPTSR_84_213();
                    break;

                case "VHPTSR96-219":
                    ListItems = vhptsr.VHPTSR_96_219();
                    break;

                case "VHPTSR108-225":
                    ListItems = vhptsr.VHPTSR_108_225();
                    break;

                case "VHPTSR120-231":
                    ListItems = vhptsr.VHPTSR_120_231();
                    break;

                case "VHPTSR144-243":
                    ListItems = vhptsr.VHPTSR_144_243();
                    break;

                default:
                    ListItems = empty_list();
                    break;
            }
        }


        private void assemble_htsr()
        {
            htsr = new HTSR(qs.productInfo);
            switch (qs.productInfo.Tag)
            {
                case "HTSR8-48":
                    ListItems = htsr.HTSR_8_48();
                    break;

                case "HTSR10-48":
                    ListItems = htsr.HTSR_10_48();
                    break;

                case "HTSR12-48":
                    ListItems = htsr.HTSR_12_48();
                    break;

                case "HTSR12-72":
                    ListItems = htsr.HTSR_12_72();
                    break;

                case "HTSR16-72":
                    ListItems = htsr.HTSR_16_72();
                    break;

                case "HTSR20-72":
                    ListItems = htsr.HTSR_20_72();
                    break;

                case "HTSR24-72":
                    ListItems = htsr.HTSR_24_72();
                    break;

                case "HTSR30-84":
                    ListItems = htsr.HTSR_30_84();
                    break;

                case "HTSR36-96":
                    ListItems = htsr.HTSR_36_96();
                    break;

                case "HTSR42-120":
                    ListItems = htsr.HTSR_42_120();
                    break;

                case "HTSR48-147":
                    ListItems = htsr.HTSR_48_147();
                    break;

                default:
                    ListItems = empty_list();
                    break;
            }
        }


        private void assemble_vtsr()
        {
            vtsr = new VTSR(qs.productInfo);
            switch (qs.productInfo.Tag)
            {
                case "VTSR8-48":
                    ListItems = vtsr.VTSR_8_48();
                    break;

                case "VTSR10-48":
                    ListItems = vtsr.VTSR_10_48();
                    break;

                case "VTSR12-48":
                    ListItems = vtsr.VTSR_12_48();
                    break;

                case "VTSR12-72":
                    ListItems = vtsr.VTSR_12_72();
                    break;

                case "VTSR16-72":
                    ListItems = vtsr.VTSR_16_72();
                    break;

                case "VTSR20-72":
                    ListItems = vtsr.VTSR_20_72();
                    break;

                case "VTSR24-72":
                    ListItems = vtsr.VTSR_24_72();
                    break;

                case "VTSR30-84":
                    ListItems = vtsr.VTSR_30_84();
                    break;

                default:
                    ListItems = empty_list();
                    break;
            }
        }


        private void assemble_vcpr()
        {
            vcpr = new VCPR(qs.productInfo);
            switch (qs.productInfo.Tag)
            {
                case "VCPR20-144":
                    ListItems = vcpr.VCPR_20_144();
                    break;

                case "VCPR24-144":
                    ListItems = vcpr.VCPR_24_144();
                    break;

                case "VCPR30-138":
                    ListItems = vcpr.VCPR_30_138();
                    break;

                case "VCPR36-141":
                    ListItems = vcpr.VCPR_36_141();
                    break;

                case "VCPR42-144":
                    ListItems = vcpr.VCPR_42_144();
                    break;

                case "VCPR48-147":
                    ListItems = vcpr.VCPR_48_147();
                    break;

                case "VCPR54-150":
                    ListItems = vcpr.VCPR_54_150();
                    break;

                case "VCPR60-153":
                    ListItems = vcpr.VCPR_60_153();
                    break;

                case "VCPR72-159":
                    ListItems = vcpr.VCPR_72_159();
                    break;

                case "VCPR84-165":
                    ListItems = vcpr.VCPR_84_165();
                    break;

                case "VCPR96-171":
                    ListItems = vcpr.VCPR_96_171();
                    break;

                default:
                    ListItems = empty_list();
                    break;
            }
        }


        private void assemble_vpr()
        {
            vpr = new VPR(qs.productInfo);
            switch (qs.productInfo.Tag)
            {
                case "VPR10-48":
                    ListItems = vpr.VPR_10_48();
                    break;

                case "VPR12-48":
                    ListItems = vpr.VPR_12_48();
                    break;

                case "VPR16-60":
                    ListItems = vpr.VPR_16_60();
                    break;

                case "VPR20-60":
                    ListItems = vpr.VPR_20_60();
                    break;

                case "VPR24-72":
                    ListItems = vpr.VPR_24_72();
                    break;

                default:
                    ListItems = empty_list();
                    break;
            }
        }


        private void assemble_vr()
        {
            vr = new VR(qs.productInfo);
            switch (qs.productInfo.Tag)
            {
                case "VR24-112":
                    ListItems = vr.VR_24_112();
                    break;

                case "VR30-115":
                    ListItems = vr.VR_30_115();
                    break;

                case "VR36-118":
                    ListItems = vr.VR_36_118();
                    break;

                case "VR42-144":
                    ListItems = vr.VR_42_144();
                    break;

                case "VR48-147":
                    ListItems = vr.VR_48_147();
                    break;

                case "VR54-150":
                    ListItems = vr.VR_54_150();
                    break;

                case "VR60-153":
                    ListItems = vr.VR_60_153();
                    break;

                case "VR72-159":
                    ListItems = vr.VR_72_159();
                    break;

                case "VR84-165":
                    ListItems = vr.VR_84_165();
                    break;

                case "VR96-171":
                    ListItems = vr.VR_96_171();
                    break;

                case "VR108-177":
                    ListItems = vr.VR_108_177();
                    break;

                case "VR120-183":
                    ListItems = vr.VR_120_183();
                    break;

                case "VR144-195":
                    ListItems = vr.VR_144_195();
                    break;

                default:
                    ListItems = empty_list();
                    break;
            }
        }


        private void assemble_hr()
        {
            hr = new HR(qs.productInfo);
            switch (qs.productInfo.Tag)
            {
                case "HR24-135":
                    ListItems = hr.HR_24_135();
                    break;

                case "HR30-138":
                    ListItems = hr.HR_30_138();
                    break;

                case "HR36-141":
                    ListItems = hr.HR_36_141();
                    break;

                case "HR42-144":
                    ListItems = hr.HR_42_144();
                    break;

                case "HR48-147":
                    ListItems = hr.HR_48_147();
                    break;

                case "HR54-150":
                    ListItems = hr.HR_54_150();
                    break;

                case "HR60-153":
                    ListItems = hr.HR_60_153();
                    break;

                case "HR72-159":
                    ListItems = hr.HR_72_159();
                    break;

                case "HR84-165":
                    ListItems = hr.HR_84_165();
                    break;

                case "HR96-171":
                    ListItems = hr.HR_96_171();
                    break;

                case "HR108-177":
                    ListItems = hr.HR_108_177();
                    break;

                case "HR120-183":
                    ListItems = hr.HR_120_183();
                    break;

                case "HR144-195":
                    ListItems = hr.HR_144_195();
                    break;

                default:
                    ListItems = empty_list();
                    break;
            }
        }


        private void assemble_vi()
        {
            vi = new VI(qs.productInfo);
            switch (qs.productInfo.Tag)
            {
                case "VI16-96":
                    ListItems = vi.VI_16_96();
                    break;

                case "VI20-108":
                    ListItems = vi.VI_20_108();
                    break;

                case "VI24-112":
                    ListItems = vi.VI_24_112();
                    break;

                case "VI30-115":
                    ListItems = vi.VI_30_115();
                    break;

                case "VI36-118":
                    ListItems = vi.VI_36_118();
                    break;

                case "VI42-144":
                    ListItems = vi.VI_42_144();
                    break;

                case "VI48-147":
                    ListItems = vi.VI_48_147();
                    break;

                case "VI54-150":
                    ListItems = vi.VI_54_150();
                    break;

                case "VI60-153":
                    ListItems = vi.VI_60_153();
                    break;

                case "VI72-159":
                    ListItems = vi.VI_72_159();
                    break;

                case "VI84-165":
                    ListItems = vi.VI_84_165();
                    break;

                case "VI96-171":
                    ListItems = vi.VI_96_171();
                    break;

                case "VI108-177":
                    ListItems = vi.VI_108_177();
                    break;

                case "VI120-183":
                    ListItems = vi.VI_120_183();
                    break;

                case "VI144-195":
                    ListItems = vi.VI_144_195();
                    break;

                default:
                    ListItems = empty_list();
                    break;
            }
        }


        private void assemble_vic()
        {
            vic = new VIC(qs.productInfo);
            switch (qs.productInfo.Tag)
            {
                case "VIC16-96":
                    ListItems = vic.VIC_16_96();
                    break;

                case "VIC20-108":
                    ListItems = vic.VIC_20_108();
                    break;

                case "VIC24-112":
                    ListItems = vic.VIC_24_112();
                    break;

                case "VIC30-115":
                    ListItems = vic.VIC_30_115();
                    break;

                case "VIC36-118":
                    ListItems = vic.VIC_36_118();
                    break;

                case "VIC42-144":
                    ListItems = vic.VIC_42_144();
                    break;

                case "VIC48-147":
                    ListItems = vic.VIC_48_147();
                    break;

                case "VIC54-150":
                    ListItems = vic.VIC_54_150();
                    break;

                case "VIC60-153":
                    ListItems = vic.VIC_60_153();
                    break;

                case "VIC72-159":
                    ListItems = vic.VIC_72_159();
                    break;

                case "VIC84-165":
                    ListItems = vic.VIC_84_165();
                    break;

                case "VIC96-171":
                    ListItems = vic.VIC_96_171();
                    break;

                case "VIC108-177":
                    ListItems = vic.VIC_108_177();
                    break;

                case "VIC120-183":
                    ListItems = vic.VIC_120_183();
                    break;

                case "VIC144-195":
                    ListItems = vic.VIC_144_195();
                    break;

                default:
                    ListItems = empty_list();
                    break;
            }
        }


        private void assemble_ha()
        {
            ha = new HA(qs.productInfo);
            switch (qs.productInfo.Tag)
            {
                case "HA24-135":
                    ListItems = ha.HA_24_135();
                    break;

                case "HA30-138":
                    ListItems = ha.HA_30_138();
                    break;

                case "HA36-141":
                    ListItems = ha.HA_36_141();
                    break;

                case "HA42-144":
                    ListItems = ha.HA_42_144();
                    break;

                case "HA48-147":
                    ListItems = ha.HA_48_147();
                    break;

                case "HA54-150":
                    ListItems = ha.HA_54_150();
                    break;

                case "HA60-153":
                    ListItems = ha.HA_60_153();
                    break;

                case "HA72-159":
                    ListItems = ha.HA_72_159();
                    break;

                case "HA84-165":
                    ListItems = ha.HA_84_165();
                    break;

                case "HA96-171":
                    ListItems = ha.HA_96_171();
                    break;

                case "HA108-177":
                    ListItems = ha.HA_108_177();
                    break;

                case "HA120-183":
                    ListItems = ha.HA_120_183();
                    break;

                case "HA144-195":
                    ListItems = ha.HA_144_195();
                    break;

                default:
                    ListItems = empty_list();
                    break;
            }
        }


        private void assemble_va()
        {
            va = new VA(qs.productInfo);
            switch (qs.productInfo.Tag)
            {
                case "VA12-72":
                    ListItems = va.VA_12_72();
                    break;

                case "VA16-85":
                    ListItems = va.VA_16_85();
                    break;

                case "VA20-87":
                    ListItems = va.VA_20_87();
                    break;

                case "VA24-88":
                    ListItems = va.VA_24_88();
                    break;

                case "VA30-115":
                    ListItems = va.VA_30_115();
                    break;

                case "VA36-118":
                    ListItems = va.VA_36_118();
                    break;

                case "VA42-121":
                    ListItems = va.VA_42_121();
                    break;

                case "VA48-147":
                    ListItems = va.VA_48_147();
                    break;

                case "VA54-150":
                    ListItems = va.VA_54_150();
                    break;

                case "VA60-153":
                    ListItems = va.VA_60_153();
                    break;

                case "VA72-159":
                    ListItems = va.VA_72_159();
                    break;

                case "VA84-165":
                    ListItems = va.VA_84_165();
                    break;

                case "VA96-171":
                    ListItems = va.VA_96_171();
                    break;

                case "VA108-177":
                    ListItems = va.VA_108_177();
                    break;

                case "VA120-183":
                    ListItems = va.VA_120_183();
                    break;

                case "VA144-195":
                    ListItems = va.VA_144_195();
                    break;

                default:
                    ListItems = empty_list();
                    break;
            }
        }


        private void assemble_vac()
        {
            vac = new VAC(qs.productInfo);
            switch (qs.productInfo.Tag)
            {
                case "VAC16-85":
                    ListItems = vac.VAC_16_85();
                    break;

                case "VAC20-87":
                    ListItems = vac.VAC_20_87();
                    break;

                case "VAC24-88":
                    ListItems = vac.VAC_24_88();
                    break;

                case "VAC30-115":
                    ListItems = vac.VAC_30_115();
                    break;

                case "VAC36-118":
                    ListItems = vac.VAC_36_118();
                    break;

                case "VAC42-121":
                    ListItems = vac.VAC_42_121();
                    break;

                case "VAC48-147":
                    ListItems = vac.VAC_48_147();
                    break;

                case "VAC54-150":
                    ListItems = vac.VAC_54_150();
                    break;

                case "VAC60-153":
                    ListItems = vac.VAC_60_153();
                    break;

                case "VAC72-159":
                    ListItems = vac.VAC_72_159();
                    break;

                case "VAC84-165":
                    ListItems = vac.VAC_84_165();
                    break;

                case "VAC96-171":
                    ListItems = vac.VAC_96_171();
                    break;

                case "VAC108-177":
                    ListItems = vac.VAC_108_177();
                    break;

                case "VAC120-183":
                    ListItems = vac.VAC_120_183();
                    break;

                case "VAC144-195":
                    ListItems = vac.VAC_144_195();
                    break;

                default:
                    ListItems = empty_list();
                    break;
            }
        }


        private void assemble_vsd()
        {
            vsd = new VSD(qs.productInfo);
            switch (qs.productInfo.Tag)
            {
                case "VSD12-48":
                    ListItems = vsd.VSD_12_48();
                    break;

                case "VSD16-54":
                    ListItems = vsd.VSD_16_54();
                    break;

                case "VSD20-60":
                    ListItems = vsd.VSD_20_60();
                    break;

                case "VSD24-60":
                    ListItems = vsd.VSD_24_60();
                    break;

                case "VSD30-72":
                    ListItems = vsd.VSD_30_72();
                    break;

                case "VSD36-78":
                    ListItems = vsd.VSD_36_78();
                    break;

                case "VSD42-84":
                    ListItems = vsd.VSD_42_84();
                    break;

                default:
                    ListItems = empty_list();
                    break;
            }
        }


        private void assemble_hsd()
        {
            hsd = new HSD(qs.productInfo);
            switch (qs.productInfo.Tag)
            {
                case "HSD12-48":
                    ListItems = hsd.HSD_12_48();
                    break;

                case "HSD16-60":
                    ListItems = hsd.HSD_16_60();
                    break;

                case "HSD20-72":
                    ListItems = hsd.HSD_20_72();
                    break;

                case "HSD24-72":
                    ListItems = hsd.HSD_24_72();
                    break;

                case "HSD30-96":
                    ListItems = hsd.HSD_30_96();
                    break;

                case "HSD36-96":
                    ListItems = hsd.HSD_36_96();
                    break;

                case "HSD42-120":
                    ListItems = hsd.HSD_42_120();
                    break;

                default:
                    ListItems = empty_list();
                    break;
            }
        }


        private void assemble_mhsd()
        {
            mhsd = new MHSD(qs.productInfo);
            switch (qs.productInfo.Tag)
            {
                case "MHSD20-96":
                    ListItems = mhsd.MHSD_20_96();
                    break;

                case "MHSD24-96":
                    ListItems = mhsd.MHSD_24_96();
                    break;

                case "MHSD30-96":
                    ListItems = mhsd.MHSD_30_96();
                    break;

                case "MHSD36-96":
                    ListItems = mhsd.MHSD_36_96();
                    break;

                case "MHSD42-96":
                    ListItems = mhsd.MHSD_42_96();
                    break;

                case "MHSD48-120":
                    ListItems = mhsd.MHSD_48_120();
                    break;

                case "MHSD54-144":
                    ListItems = mhsd.MHSD_54_144();
                    break;

                case "MHSD60-144":
                    ListItems = mhsd.MHSD_60_144();
                    break;

                default:
                    ListItems = empty_list();
                    break;
            }
        }


        private void assemble_hop()
        {
            hop = new HOP(qs.productInfo);
            switch (qs.productInfo.Tag)
            {
                case "HOP8-36":
                    ListItems = hop.HOP_8_36();
                    break;

                case "HOP10-36":
                    ListItems = hop.HOP_10_36();
                    break;

                default:
                    ListItems = empty_list();
                    break;
            }
        }


        //-----------PACKAGE--------------------


        private void Assemble_package_list()
        {
            switch (qs.productInfo.PackageType)
            {
                case "MRP-V":
                    mrp_v = new MRP_V(qs.productInfo);
                    ListItems = mrp_v.Assemble_package_list();
                    break;

                case "MRP-H":
                    mrp_h = new MRP_H(qs.productInfo);
                    ListItems = mrp_h.Assemble_package_list();
                    break;

                case "MPC":
                    mpc = new MPC(qs.productInfo);
                    ListItems = mpc.Assemble_package_list();
                    break;

                case "MVI":
                    mvi = new MVI(qs.productInfo);
                    ListItems = mvi.Assemble_package_list();
                    break;

                case "MVIC":
                    mvic = new MVIC(qs.productInfo);
                    ListItems = mvic.Assemble_package_list();
                    break;

                default:
                    break;
            }
        }
    }
}
