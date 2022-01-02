using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using TrenYolPriceCalculating.Classes_CommonValues;
using System.IO;
using System;

namespace TrenYolPriceCalculating
{
    class CreatingExcel
    {
        ExcelFileColumns columns = new ExcelFileColumns();

        public DataTable createAndExportToExcel()
        {
            string DocumentsAndSettingsPath = PCDocumentAndSettingsPath.DocumentsAndSettingsPath;
            string filePath = PCDocumentAndSettingsPath.filePath;

            //if there is no file in PC
            if (!CommonFunctions.controlTheFileExistBeforeInsertProduct(filePath))
            {
                try
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

                    // Columns creating - creates only columns' names with turkish charachters            
                    columns.excelFileColumns(xlWorkSheet, 2);

                    // creates the file============
                    DialogResult dialogResult = MessageBox.Show("Yeni bir dosya oluşturmak üzeresiniz. Devam etmek istiyor musunuz?", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        xlWorkBook.SaveAs(filePath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                        xlWorkBook.Close(true, misValue, misValue);
                        xlApp.Quit();

                        Marshal.ReleaseComObject(xlWorkSheet);
                        Marshal.ReleaseComObject(xlWorkBook);
                        Marshal.ReleaseComObject(xlApp);

                        MessageBox.Show("Dosyanız " + DocumentsAndSettingsPath + " yolunda başarı ile oluşturuldu.");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return null;
                    }
                    
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
                MessageBox.Show(DocumentsAndSettingsPath + " yolunda zaten bir dosyanız mevcut.");

            return ReadingExcel.dtExcel;
        }

        
    }
}
