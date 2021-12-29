using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System;

namespace TrenYolPriceCalculating
{
    class CreatingExcel
    {
        public DataTable ExportToExcel(Product product)
        {
            Excel.Application xlApp = new Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return null;
            }


            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Cells[1, 1] = "ID";
            xlWorkSheet.Cells[1, 2] = "Ürün Adı";
            xlWorkSheet.Cells[1, 3] = "Alış Fiyatı";
            xlWorkSheet.Cells[1, 4] = "Trendyol Komisyon Oranı";
            xlWorkSheet.Cells[1, 5] = "Trendyol Komisyon Tutarı";
            xlWorkSheet.Cells[1, 6] = "KDV Oranı";
            xlWorkSheet.Cells[1, 7] = "KDV Tutarı";
            xlWorkSheet.Cells[1, 8] = "Kargo Gideri";
            xlWorkSheet.Cells[1, 9] = "Kar Oranı";
            xlWorkSheet.Cells[1, 10] = "Kar Tutarı";
            xlWorkSheet.Cells[1, 11] = "Toplam Gider";
            xlWorkSheet.Cells[1, 12] = "SATIŞ FİYATI";


            string DocumentsAndSettingsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            xlWorkBook.SaveAs(DocumentsAndSettingsPath + "\\Ürünler.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file " + DocumentsAndSettingsPath);

            //createAndFillExcellColumns(product);
            //printToExcel();
            return ReadingExcel.dtExcel;
        }
    }
}
