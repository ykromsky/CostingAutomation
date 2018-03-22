

namespace StandardVesselEstimator
{
    public class QuoteSheet
    {
        private ExcelItems excelItems;
        private QuoteBody quoteBody;
        private QuoteTopBlock topBlock;
        public ProductInfo productInfo;

        public int headerRow, firstRow, lastRow, sectionARow, sectionBRow,  firstCol, lastCol;
        public int firstBufferCol, quantityCol, descriptionCol, serviceCol, materialCol, sizeCol, ratingCol, lengthCol;
        public int materialBufferCol, aCol, bCol, cCol, unitsCol, partNumCol, partPriceCol, materialPriceCol;
        public int laborBufferCol, plasmaLaborCol, rollerLaborCol, subarcLaborCol, blastLaborCol, cuttingLaborCol, welderLaborCol, hoursCol;

        public QuoteSheet(ProductInfo info)
        {
            productInfo = info;

            excelItems = new ExcelItems();
            quoteBody = new QuoteBody(this, excelItems);
            topBlock = new QuoteTopBlock(this, excelItems);

            firstBufferCol = 1;
            quantityCol = 2;
            descriptionCol = 3;
            serviceCol = 4;
            materialCol = 5;
            sizeCol = 6;
            ratingCol = 7;
            lengthCol = 8;

            materialBufferCol = 9;
            aCol = 10;
            bCol = 11;
            cCol = 12;
            unitsCol = 13;
            partNumCol = 14;
            partPriceCol = 15;
            materialPriceCol = 16;

            laborBufferCol = 17;
            plasmaLaborCol = 18;
            rollerLaborCol = 19;
            subarcLaborCol = 20;
            cuttingLaborCol = 21;
            blastLaborCol = 22;
            welderLaborCol = 23;
            hoursCol = 24;

            switch(productInfo.productClass)
            {
                case "vessel":
                case "liquid feed":
                    headerRow = 10;
                    firstRow = 12;
                    break;

                case "package":
                    headerRow = 13;
                    firstRow = 15;
                    break;

                default:
                    break;
            }
            
            lastRow = firstRow;
            sectionARow = 0;
            sectionBRow = 0;
            firstCol = quantityCol;
            lastCol = hoursCol;
        }


        public void Run_quotesheet()
        {
            excelItems.New_quotesheet(productInfo);
            excelItems.application.ScreenUpdating = false;

            quoteBody.Write_quote_body();
            topBlock.Write_top_block();

            excelItems.application.ScreenUpdating = true;
        }


        //for full report only so far
        public void Get_quote_sums(out double materialTotal, out double laborTotal)
        {
            excelItems.New_quotesheet(productInfo);

            excelItems.application.ScreenUpdating = false;

            quoteBody.Write_quote_body();

            topBlock.Write_top_block();

            materialTotal = excelItems.worksheet.Cells[3, 6].Value2;
            laborTotal = excelItems.worksheet.Cells[6, 6].Value2;

            excelItems.application.DisplayAlerts = false;
            excelItems.worksheet.Delete();
            excelItems.application.DisplayAlerts = true;

            lastRow = firstRow;
            excelItems.application.ScreenUpdating = true;
        }
    } 
}
