
using System.Diagnostics;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace StandardVesselEstimator
{
    class ExcelItems
    {
        public Excel.Application application;
        public Excel.Workbook workbook;
        public Excel.Worksheet worksheet;
        public Excel.Range range;

        public void New_quotesheet(ProductInfo info)
        {
            try
            {
                //MessageBox.Show("GetActiveObject(Excel.Application)");
                application = (Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");
            }
            catch (COMException cex)
            {
                MessageBox.Show("GetActiveObject(Excel.Application) FAILED \n\n" + cex.ToString());
            }
            application.Visible = true;
            workbook = application.ActiveWorkbook;
            worksheet = workbook.Worksheets.Add(After: workbook.Sheets[workbook.Sheets.Count]);

            try  //avoids crash on identical sheet names
            {
                worksheet.Name = info.Tag;
            }
            catch
            {
                MessageBox.Show("That vessel sheet already exists!");
            }
        }


        public void New_report_sheet()
        {
            try { application = (Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application"); }
            catch (COMException cex) { MessageBox.Show("GetActiveObject(Excel.Application) FAILED \n\n" + cex.ToString()); }

            workbook = application.ActiveWorkbook;
            worksheet = workbook.Worksheets[1];
            worksheet.Name = "REPORT";
        }


        public void Cell_value(int row, int col, string value)
        {
            double number;
            worksheet = workbook.ActiveSheet;
            range = worksheet.Cells[row, col];

            //parse string for number just in case
            if (double.TryParse(value, out number)) range.Value2 = number;
            else range.Value2 = value;
        }
        public void Cell_value(int row, int col, double value)
        {
            worksheet = workbook.ActiveSheet;
            range = worksheet.Cells[row, col];
            range.Value2 = value;
        }


        public Excel.Range Select_range(int row1, int col1, int row2, int col2)
        {
            return worksheet.Range[worksheet.Cells[row1, col1], worksheet.Cells[row2, col2]];
        }


        public void Freeze_panes(int row, int col)
        {
            Excel.Range myCell = worksheet.Cells[row, col];
            myCell.Activate();
            myCell.Application.ActiveWindow.FreezePanes = true;
        }


        public void Switch_to_R1C1() { application.ReferenceStyle = Excel.XlReferenceStyle.xlR1C1; }
        public void Switch_to_A1() { application.ReferenceStyle = Excel.XlReferenceStyle.xlA1; }
    }
}
