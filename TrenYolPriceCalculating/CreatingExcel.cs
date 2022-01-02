using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System;
using TrenYolPriceCalculating.Classes_CommonValues;

namespace TrenYolPriceCalculating
{
    class CreatingExcel
    {
        ExcelFileColumns columns = new ExcelFileColumns();

        public DataTable createAndExportToExcel()
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
            string DocumentsAndSettingsPath = PCDocumentAndSettingsPath.DocumentsAndSettingsPath;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            
            // Columns creating - creates only columns' names with turkish charachters            
            columns.excelFileColumns(xlWorkSheet,2);

            //Controls if the file that is wanted to create is already exist=====
            try
            {
                // reads the file if it already exist
                xlWorkBook = xlApp.Workbooks.Open(DocumentsAndSettingsPath + "\\Ürünler.xls", 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

                MessageBox.Show(DocumentsAndSettingsPath + "\\Ürünler.xls" + " yolunda zaten bir dosyanız bulunmaktadır.");
            }
            catch
            {
                // creates the file============
                DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    xlWorkBook.SaveAs(DocumentsAndSettingsPath + "\\Ürünler.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();

                    Marshal.ReleaseComObject(xlWorkSheet);
                    Marshal.ReleaseComObject(xlWorkBook);
                    Marshal.ReleaseComObject(xlApp);

                    MessageBox.Show("Excel file created , you can find the file " + DocumentsAndSettingsPath);
                }
                else if (dialogResult == DialogResult.No)
                {
                    return null;
                }

                //================== creates the file END =============================
            }
            //===== Controls if the file that is wanted to create is already exist END ==========

            return ReadingExcel.dtExcel;
        }      
    }
}
