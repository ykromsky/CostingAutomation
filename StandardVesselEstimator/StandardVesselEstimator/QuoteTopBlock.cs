using Excel = Microsoft.Office.Interop.Excel;

namespace StandardVesselEstimator
{
    class QuoteTopBlock
    {
        public ExcelItems xl;
        public QuoteSheet qs;

        private int relFirstRow, relLastRow;
        private int relFirstARow, relLastARow, relFirstBRow, relLastBRow;
        private double freightMultiplier, hourlyRate, netDivisor, listDivisor;
        private string formula;
        private int relQuantityCol, relHoursCol, relMaterialPriceCol;


        public QuoteTopBlock(QuoteSheet quoteSheet, ExcelItems excelItems)
        {
            qs = quoteSheet;
            xl = excelItems;

            freightMultiplier = 1.064;
            hourlyRate = 65.00;
            netDivisor = 0.6;
            listDivisor = 0.6;
        }


        public void Write_top_block()
        {
            switch (qs.productInfo.productClass)
            {
                case "vessel":
                    Write_title_block();
                    Write_subtotal_block();
                    Write_list_net_block();
                    Format_top_block();
                    break;

                case "package":
                    Write_package_top_block();
                    Format_package_top_block();
                    Write_section_blocks();
                    Format_section_blocks();
                    break;

                case "liquid feed":
                    Write_lf_top_block();
                    Format_lf_top_block();
                    break;

                default: break;
            }
            xl.Freeze_panes(qs.firstRow, 1);
        }


        private void Write_title_block()
        {
            xl.Cell_value(2, 2, "MODEL NUMBER:");
            xl.Cell_value(2, 3, qs.productInfo.Tag);

            xl.Cell_value(3, 2, "DESCRIPTION:");
            xl.Cell_value(3, 3, qs.productInfo.Description);

            xl.Cell_value(4, 2, "DESIGN P:");
            xl.Cell_value(4, 3, qs.productInfo.Pressure);

            xl.Cell_value(5, 2, "DESIGN T:");
            xl.Cell_value(5, 3, qs.productInfo.Temperature);

            xl.Cell_value(6, 2, "CORROSION:");
            xl.Cell_value(6, 3, qs.productInfo.CorrosionAllowance);
        }


        private void Write_subtotal_block()
        {
            xl.Cell_value(2, 5, "MATERIALS SUBTOTAL:");
            xl.Cell_value(3, 5, "MATERIALS TOTAL:");
            xl.Cell_value(4, 5, "HOURS COUNT:");
            xl.Cell_value(5, 5, "HOURLY RATE:");
            xl.Cell_value(6, 5, "LABOR TOTAL:");
            xl.Cell_value(7, 5, "COST TOTAL:");

            //switch to "R1C1" mode to make formulas easier to code
            xl.Switch_to_R1C1();

            //materials subtotal formula
            Relative_rows_and_columns(2, 6);
            //"=SUMPRODUCT(QTY COLUMN, MATERIAL $/EA COLUMN)"
            formula = "=SUMPRODUCT(R[" + relFirstRow + "]C[" + relQuantityCol + "]:R[" + relLastRow + "]C[" + relQuantityCol + "], " +
                                  "R[" + relFirstRow + "]C[" + relMaterialPriceCol + "]:R[" + relLastRow + "]C[" + relMaterialPriceCol + "])";
            xl.Cell_value(2, 6, formula);

            //materials total formula
            formula = "=R[-1]C*1.064"; //materials total = materials subtotal x freight multiplier
            xl.Cell_value(3, 6, formula);

            //hours count formula
            Relative_rows_and_columns(4, 6);
            //"=CEILING.MATH(SUMPRODUCT(QTY COLUMN, MATERIAL $/EA COLUMN), 0.125)"
            formula = "=CEILING.MATH(SUMPRODUCT(R[" + relFirstRow + "]C[" + relQuantityCol + "]:R[" + relLastRow + "]C[" + relQuantityCol + "], " +
                                  "R[" + relFirstRow + "]C[" + relHoursCol + "]:R[" + relLastRow + "]C[" + relHoursCol + "]), 0.05)";
            xl.Cell_value(4, 6, formula);

            //hourly rate
            xl.Cell_value(5, 6, hourlyRate);

            //labor total formula
            formula = "=R[-2]C*R[-1]C"; //labor total = hours count x hourly rate
            xl.Cell_value(6, 6, formula);

            //cost total formula
            formula = "=R[-4]C+R[-1]C"; //cost total = materials total + labor total
            xl.Cell_value(7, 6, formula);

            //switch back to "A1" mode to make worksheet easier to read
            xl.Switch_to_A1();
        }


        private void Write_list_net_block()
        {
            xl.Cell_value(2, 8, "DIVISOR (NET):");
            xl.Cell_value(3, 8, "NET SELL:");
            xl.Cell_value(5, 8, "DIVISOR (LIST):");
            xl.Cell_value(6, 8, "LIST PRICE:");

            //switch to "R1C1" mode to make formulas easier to code
            xl.Switch_to_R1C1();

            //divisor (net)
            xl.Cell_value(2, 9, netDivisor);

            //net sell formula
            formula = "=R[4]C[-3]/R[-1]C"; //net sell = total cost / divisor
            xl.Cell_value(3, 9, formula);

            //divisor (list)
            xl.Cell_value(5, 9, listDivisor);

            //list price formula
            formula = "=R[-3]C/R[-1]C"; //list price = net price / divisor
            xl.Cell_value(6, 9, formula);

            //switch back to "A1" mode to make worksheet easier to read
            xl.Switch_to_A1();
        }


        private void Format_top_block()
        {
            //format title block
            xl.range = xl.Select_range(2, 2, 6, 2);
            xl.range.Font.Bold = true;
            xl.range.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            xl.range = xl.Select_range(2, 3, 6, 3);
            xl.range.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

            //format subtotals block
            xl.range = xl.Select_range(2, 5, 7, 5);
            xl.range.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

            xl.range = xl.Select_range(2, 6, 3, 6);
            xl.range.Style = xl.workbook.Styles["Currency"];

            xl.range = xl.Select_range(4, 5, 4, 6);
            xl.range.Font.Bold = true;

            xl.range = xl.Select_range(5, 6, 7, 6);
            xl.range.Style = xl.workbook.Styles["Currency"];

            xl.range = xl.Select_range(7, 5, 7, 6);
            xl.range.Font.Bold = true;

            xl.range = xl.Select_range(2, 8, 6, 8);
            xl.range.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

            xl.range = xl.Select_range(3, 9, 3, 9);
            xl.range.Style = xl.workbook.Styles["Currency"];

            xl.range = xl.Select_range(6, 9, 6, 9);
            xl.range.Style = xl.workbook.Styles["Currency"];
        }


        //-------------PACKAGE---------------

        private void Write_package_top_block()
        {
            //switch to "R1C1" mode to make formulas easier to code
            xl.Switch_to_R1C1();

            //INFO----------

            xl.Cell_value(2, 2, "MODEL NUMBER:");
            xl.Cell_value(2, 3, qs.productInfo.Tag);
            xl.Cell_value(3, 2, "DESCRIPTION:");
            xl.Cell_value(3, 3, qs.productInfo.Description);
            xl.Cell_value(4, 2, "DESIGN P:");
            xl.Cell_value(4, 3, qs.productInfo.Pressure);
            xl.Cell_value(5, 2, "DESIGN T:");
            xl.Cell_value(5, 3, qs.productInfo.Temperature);
            xl.Cell_value(6, 2, "CORROSION:");
            xl.Cell_value(6, 3, qs.productInfo.CorrosionAllowance);

            //SUBTOTALS-----

            //"materials subtotal =SUMPRODUCT(QTY COLUMN, MATERIAL $/EA COLUMN)"
            xl.Cell_value(2, 5, "MATERIALS SUBTOTAL:");
            Relative_rows_and_columns(2, 6);
            formula = "=SUMPRODUCT(R[" + relFirstRow + "]C[" + relQuantityCol + "]:R[" + relLastRow + "]C[" + relQuantityCol + "], " +
                                  "R[" + relFirstRow + "]C[" + relMaterialPriceCol + "]:R[" + relLastRow + "]C[" + relMaterialPriceCol + "])";
            xl.Cell_value(2, 6, formula);

            //materials total = materials subtotal x freight multiplier
            xl.Cell_value(3, 5, "MATERIALS TOTAL:");
            formula = "=R[-1]C*RC[3]";
            xl.Cell_value(3, 6, formula);

            //"hours count =CEILING.MATH(SUMPRODUCT(QTY COLUMN, MATERIAL $/EA COLUMN), 0.125)"
            xl.Cell_value(4, 5, "HOURS COUNT:");
            Relative_rows_and_columns(4, 6);
            formula = "=CEILING.MATH(SUMPRODUCT(R[" + relFirstRow + "]C[" + relQuantityCol + "]:R[" + relLastRow + "]C[" + relQuantityCol + "], " +
                                  "R[" + relFirstRow + "]C[" + relHoursCol + "]:R[" + relLastRow + "]C[" + relHoursCol + "]), 0.05)";
            xl.Cell_value(4, 6, formula);

            //labor total = hours count x hourly rate
            xl.Cell_value(5, 5, "LABOR TOTAL:");
            formula = "=R[-1]C*RC[3]";
            xl.Cell_value(5, 6, formula);

            //cost total = materials total + labor total
            xl.Cell_value(6, 5, "COST TOTAL:");
            formula = "=R[-3]C+R[-1]C";
            xl.Cell_value(6, 6, formula);

            //net sell = total cost / divisor
            xl.Cell_value(7, 5, "NET SELL:");
            formula = "=R[-1]C/RC[3]";
            xl.Cell_value(7, 6, formula);

            //list price = net price / divisor
            xl.Cell_value(8, 5, "LIST PRICE:");
            formula = "=R[-1]C/RC[3]";
            xl.Cell_value(8, 6, formula);

            //freight multiplier
            xl.Cell_value(3, 8, "FREIGHT MULTIPLIER:");
            xl.Cell_value(3, 9, freightMultiplier);

            //hourly rate
            xl.Cell_value(5, 8, "HOURLY RATE:");
            xl.Cell_value(5, 9, hourlyRate);

            //net divisor
            xl.Cell_value(7, 8, "DIVISOR (NET):");
            xl.Cell_value(7, 9, netDivisor);

            //list divisor
            xl.Cell_value(8, 8, "DIVISOR (LIST):");
            xl.Cell_value(8, 9, listDivisor);

            //switch back to "A1" mode to make worksheet easier to read
            xl.Switch_to_A1();
        }


        private void Format_package_top_block()
        {
            //format title block
            xl.range = xl.Select_range(2, 2, 6, 2);
            xl.range.Font.Bold = true;
            xl.range.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            xl.range = xl.Select_range(2, 3, 6, 3);
            xl.range.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

            //format subtotals block
            xl.range = xl.Select_range(2, 5, 11, 5);
            xl.range.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

            xl.range = xl.Select_range(2, 6, 3, 6);
            xl.range.Style = xl.workbook.Styles["Currency"];

            xl.range = xl.Select_range(5, 6, 11, 6);
            xl.range.Style = xl.workbook.Styles["Currency"];

            xl.range = xl.Select_range(2, 8, 8, 8);
            xl.range.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

            xl.range = xl.Select_range(5, 9, 5, 9);
            xl.range.Style = xl.workbook.Styles["Currency"];
        }


        private void Write_section_blocks()
        {
            //switch to "R1C1" mode to make formulas easier to code
            xl.Switch_to_R1C1();

            xl.Cell_value(10, 5, "SECTION A COST:");
            Relative_rows_and_columns(10, 6);
            formula = "=SUMPRODUCT(R[" + relFirstARow + "]C[" + relQuantityCol + "]:R[" + relLastARow + "]C[" + relQuantityCol + "], " +
                                  "R[" + relFirstARow + "]C[" + relMaterialPriceCol + "]:R[" + relLastARow + "]C[" + relMaterialPriceCol + "])" +
                                  "*R3C9 + " +
                       "SUMPRODUCT(R[" + relFirstARow + "]C[" + relQuantityCol + "]:R[" + relLastARow + "]C[" + relQuantityCol + "], " +
                                  "R[" + relFirstARow + "]C[" + relHoursCol + "]:R[" + relLastARow + "]C[" + relHoursCol + "])" +
                                  "*R5C9";
            xl.Cell_value(10, 6, formula);

            xl.Cell_value(11, 5, "SECTION B COST:");
            Relative_rows_and_columns(11, 6);
            formula = "=SUMPRODUCT(R[" + relFirstBRow + "]C[" + relQuantityCol + "]:R[" + relLastBRow + "]C[" + relQuantityCol + "], " +
                                  "R[" + relFirstBRow + "]C[" + relMaterialPriceCol + "]:R[" + relLastBRow + "]C[" + relMaterialPriceCol + "])" +
                                  "*R3C9 + " +
                       "SUMPRODUCT(R[" + relFirstBRow + "]C[" + relQuantityCol + "]:R[" + relLastBRow + "]C[" + relQuantityCol + "], " +
                                  "R[" + relFirstBRow + "]C[" + relHoursCol + "]:R[" + relLastBRow + "]C[" + relHoursCol + "])" +
                                  "*R5C9";
            xl.Cell_value(11, 6, formula);

            // --Section A
            Relative_rows_and_columns(qs.sectionARow, qs.serviceCol);
            formula = "=CONCATENATE(\"MATERIALS TOTAL: \", TEXT(SUMPRODUCT(R[" + relFirstARow + "]C[" + relQuantityCol + "]:R[" + relLastARow + "]C[" + relQuantityCol + "], " +
                                                                          "R[" + relFirstARow + "]C[" + relMaterialPriceCol + "]:R[" + relLastARow + "]C[" + relMaterialPriceCol + "])" + 
                                                                          "*R3C9,\"$0.00\"))";
            xl.Cell_value(qs.sectionARow, qs.serviceCol, formula);


            Relative_rows_and_columns(qs.sectionARow, qs.materialCol);
            formula = "=CONCATENATE(\"LABOR TOTAL: \", TEXT(SUMPRODUCT(R[" + relFirstARow + "]C[" + relQuantityCol + "]:R[" + relLastARow + "]C[" + relQuantityCol + "], " +
                                                                      "R[" + relFirstARow + "]C[" + relHoursCol + "]:R[" + relLastARow + "]C[" + relHoursCol + "])" + 
                                                                      "*R5C9,\"$0.00\"))";
            xl.Cell_value(qs.sectionARow, qs.materialCol, formula);

            Relative_rows_and_columns(qs.sectionARow, qs.ratingCol);
            formula = "=CONCATENATE(\"COST TOTAL: \", TEXT(SUMPRODUCT(R[" + relFirstARow + "]C[" + relQuantityCol + "]:R[" + relLastARow + "]C[" + relQuantityCol + "], " +
                                                                     "R[" + relFirstARow + "]C[" + relMaterialPriceCol + "]:R[" + relLastARow + "]C[" + relMaterialPriceCol + "])" + 
                                                                      "*R3C9 + " +
                                                          "SUMPRODUCT(R[" + relFirstARow + "]C[" + relQuantityCol + "]:R[" + relLastARow + "]C[" + relQuantityCol + "], " +
                                                                     "R[" + relFirstARow + "]C[" + relHoursCol + "]:R[" + relLastARow + "]C[" + relHoursCol + "])" +
                                                                     "*R5C9,\"$0.00\"))";
            xl.Cell_value(qs.sectionARow, qs.ratingCol, formula);


            // --Section B
            Relative_rows_and_columns(qs.sectionBRow, qs.serviceCol);
            formula = "=CONCATENATE(\"MATERIALS TOTAL: \", TEXT(SUMPRODUCT(R[" + relFirstBRow + "]C[" + relQuantityCol + "]:R[" + relLastBRow + "]C[" + relQuantityCol + "], " +
                                                                          "R[" + relFirstBRow + "]C[" + relMaterialPriceCol + "]:R[" + relLastBRow + "]C[" + relMaterialPriceCol + "])" +
                                                                          "*R3C9,\"$0.00\"))";
            xl.Cell_value(qs.sectionBRow, qs.serviceCol, formula);


            Relative_rows_and_columns(qs.sectionBRow, qs.materialCol);
            formula = "=CONCATENATE(\"LABOR TOTAL: \", TEXT(SUMPRODUCT(R[" + relFirstBRow + "]C[" + relQuantityCol + "]:R[" + relLastBRow + "]C[" + relQuantityCol + "], " +
                                                                      "R[" + relFirstBRow + "]C[" + relHoursCol + "]:R[" + relLastBRow + "]C[" + relHoursCol + "])" +
                                                                      "*R5C9,\"$0.00\"))";
            xl.Cell_value(qs.sectionBRow, qs.materialCol, formula);

            Relative_rows_and_columns(qs.sectionBRow, qs.ratingCol);
            formula = "=CONCATENATE(\"COST TOTAL: \", TEXT(SUMPRODUCT(R[" + relFirstBRow + "]C[" + relQuantityCol + "]:R[" + relLastBRow + "]C[" + relQuantityCol + "], " +
                                                                     "R[" + relFirstBRow + "]C[" + relMaterialPriceCol + "]:R[" + relLastBRow + "]C[" + relMaterialPriceCol + "])" +
                                                                      "*R3C9 + " +
                                                          "SUMPRODUCT(R[" + relFirstBRow + "]C[" + relQuantityCol + "]:R[" + relLastBRow + "]C[" + relQuantityCol + "], " +
                                                                     "R[" + relFirstBRow + "]C[" + relHoursCol + "]:R[" + relLastBRow + "]C[" + relHoursCol + "])" +
                                                                     "*R5C9,\"$0.00\"))";
            xl.Cell_value(qs.sectionBRow, qs.ratingCol, formula);

            //switch back to "A1" mode to make worksheet easier to read
            xl.Switch_to_A1();
        }


        private void Format_section_blocks()
        {
            xl.range = xl.Select_range(qs.sectionARow, qs.quantityCol, qs.sectionARow, qs.hoursCol);
            xl.range.Interior.Color = Excel.XlRgbColor.rgbLightSteelBlue;
            xl.range.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            xl.range.Font.Bold = true;

            xl.range = xl.Select_range(qs.sectionARow, qs.descriptionCol, qs.sectionARow, qs.descriptionCol);
            xl.range.Font.Size = 20;

            xl.range = xl.Select_range(qs.sectionBRow, qs.quantityCol, qs.sectionBRow, qs.hoursCol);
            xl.range.Interior.Color = Excel.XlRgbColor.rgbLightSteelBlue;
            xl.range.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            xl.range.Font.Bold = true;

            xl.range = xl.Select_range(qs.sectionBRow, qs.descriptionCol, qs.sectionBRow, qs.descriptionCol);
            xl.range.Font.Size = 20;
        }


        private void Relative_rows_and_columns(int row, int col)
        {
            relFirstRow = qs.firstRow - row;
            relLastRow = qs.lastRow - row;

            relFirstARow = qs.firstRow - row + 2;
            relLastARow = qs.sectionBRow - row - 2;
            relFirstBRow = qs.sectionBRow - row + 2;
            relLastBRow = qs.lastRow - row - 1;

            relQuantityCol = qs.quantityCol - col;
            relHoursCol = qs.hoursCol - col;
            relMaterialPriceCol = qs.materialPriceCol - col;
        }


        //-------------LIQUID FEED-----------

        private void Write_lf_top_block()
        {
            //switch to "R1C1" mode to make formulas easier to code
            xl.Switch_to_R1C1();

            //INFO----------

            xl.Cell_value(2, 2, "MODEL NUMBER:");
            xl.Cell_value(2, 3, qs.productInfo.Tag);
            xl.Cell_value(3, 2, "DESCRIPTION:");
            xl.Cell_value(3, 3, qs.productInfo.Description);

            //SUBTOTALS-----

            //"materials subtotal =SUMPRODUCT(QTY COLUMN, MATERIAL $/EA COLUMN)"
            xl.Cell_value(2, 5, "MATERIALS SUBTOTAL:");
            Relative_rows_and_columns(2, 6);
            formula = "=SUMPRODUCT(R[" + relFirstRow + "]C[" + relQuantityCol + "]:R[" + relLastRow + "]C[" + relQuantityCol + "], " +
                                  "R[" + relFirstRow + "]C[" + relMaterialPriceCol + "]:R[" + relLastRow + "]C[" + relMaterialPriceCol + "])";
            xl.Cell_value(2, 6, formula);

            //materials total = materials subtotal x freight multiplier
            xl.Cell_value(3, 5, "MATERIALS TOTAL:");
            formula = "=R[-1]C*RC[3]";
            xl.Cell_value(3, 6, formula);

            //"hours count =CEILING.MATH(SUMPRODUCT(QTY COLUMN, MATERIAL $/EA COLUMN), 0.125)"
            xl.Cell_value(4, 5, "HOURS COUNT:");
            Relative_rows_and_columns(4, 6);
            formula = "=CEILING.MATH(SUMPRODUCT(R[" + relFirstRow + "]C[" + relQuantityCol + "]:R[" + relLastRow + "]C[" + relQuantityCol + "], " +
                                  "R[" + relFirstRow + "]C[" + relHoursCol + "]:R[" + relLastRow + "]C[" + relHoursCol + "]), 0.05)";
            xl.Cell_value(4, 6, formula);

            //labor total = hours count x hourly rate
            xl.Cell_value(5, 5, "LABOR TOTAL:");
            formula = "=R[-1]C*RC[3]";
            xl.Cell_value(5, 6, formula);

            //cost total = materials total + labor total
            xl.Cell_value(6, 5, "COST TOTAL:");
            formula = "=R[-3]C+R[-1]C";
            xl.Cell_value(6, 6, formula);

            //net sell = total cost / divisor
            xl.Cell_value(7, 5, "NET SELL:");
            formula = "=R[-1]C/RC[3]";
            xl.Cell_value(7, 6, formula);

            //list price = net price / divisor
            xl.Cell_value(8, 5, "LIST PRICE:");
            formula = "=R[-1]C/RC[3]";
            xl.Cell_value(8, 6, formula);

            //freight multiplier
            xl.Cell_value(3, 8, "FREIGHT MULTIPLIER:");
            xl.Cell_value(3, 9, freightMultiplier);

            //hourly rate
            xl.Cell_value(5, 8, "HOURLY RATE:");
            xl.Cell_value(5, 9, hourlyRate);

            //net divisor
            xl.Cell_value(7, 8, "DIVISOR (NET):");
            xl.Cell_value(7, 9, netDivisor);

            //list divisor
            xl.Cell_value(8, 8, "DIVISOR (LIST):");
            xl.Cell_value(8, 9, listDivisor);

            //switch back to "A1" mode to make worksheet easier to read
            xl.Switch_to_A1();
        }


        private void Format_lf_top_block()
        {
            //format title block
            xl.range = xl.Select_range(2, 2, 6, 2);
            xl.range.Font.Bold = true;
            xl.range.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            xl.range = xl.Select_range(2, 3, 6, 3);
            xl.range.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

            //format subtotals block
            xl.range = xl.Select_range(2, 5, 7, 5);
            xl.range.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

            xl.range = xl.Select_range(2, 6, 3, 6);
            xl.range.Style = xl.workbook.Styles["Currency"];

            xl.range = xl.Select_range(4, 5, 4, 6);
            xl.range.Font.Bold = true;

            xl.range = xl.Select_range(5, 6, 7, 6);
            xl.range.Style = xl.workbook.Styles["Currency"];

            xl.range = xl.Select_range(7, 5, 7, 6);
            xl.range.Font.Bold = true;

            xl.range = xl.Select_range(2, 8, 6, 8);
            xl.range.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

            xl.range = xl.Select_range(3, 9, 3, 9);
            xl.range.Style = xl.workbook.Styles["Currency"];

            xl.range = xl.Select_range(6, 9, 6, 9);
            xl.range.Style = xl.workbook.Styles["Currency"];
        }
    }
}
