using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;

namespace TrenYolPriceCalculating
{
//    class ExcelClass: Product
//    {
//        public DataTable ExportToExcel(Product product)
//        {
//            Excel.Application xlApp = new Excel.Application();

//            if (xlApp == null)
//            {
//                MessageBox.Show("Excel is not properly installed!!");
//                return null;
//            }


//            Excel.Workbook xlWorkBook;
//            Excel.Worksheet xlWorkSheet;
//            object misValue = System.Reflection.Missing.Value;

//            xlWorkBook = xlApp.Workbooks.Add(misValue);
//            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

//            xlWorkSheet.Cells[1, 1] = "ID";
//            xlWorkSheet.Cells[1, 2] = "Ürün Adı";
//            xlWorkSheet.Cells[1, 3] = "Alış Fiyatı";
//            xlWorkSheet.Cells[1, 4] = "Trendyol Komisyon Oranı";
//            xlWorkSheet.Cells[1, 5] = "Trendyol Komisyon Tutarı";
//            xlWorkSheet.Cells[1, 6] = "KDV Oranı";
//            xlWorkSheet.Cells[1, 7] = "KDV Tutarı";
//            xlWorkSheet.Cells[1, 8] = "Kargo Gideri";
//            xlWorkSheet.Cells[1, 9] = "Kar Oranı";
//            xlWorkSheet.Cells[1, 10] = "Kar Tutarı";
//            xlWorkSheet.Cells[1, 11] = "Toplam Gider";
//            xlWorkSheet.Cells[1, 12] = "SATIŞ FİYATI";



//            xlWorkBook.SaveAs("d:\\csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
//            xlWorkBook.Close(true, misValue, misValue);
//            xlApp.Quit();

//            Marshal.ReleaseComObject(xlWorkSheet);
//            Marshal.ReleaseComObject(xlWorkBook);
//            Marshal.ReleaseComObject(xlApp);

//            MessageBox.Show("Excel file created , you can find the file d:\\csharp-Excel.xls");
        
//            //createAndFillExcellColumns(product);
//            //printToExcel();
//            return excelPageDataTableClass.dtExcel;
//        }

//        //public DataTable createAndFillExcellColumns(Product product)
//        //{
//        //    ExcelColumns excol = new ExcelColumns();
//        //    excol.createExcelColumns(excelPageDataTableClass.dtExcel);


//        //    excelPageDataTableClass.dtExcel.Rows.Add(
//        //        product.pName,
//        //        product.supplyingPrice,
//        //        product.trendyolComissionRate,
//        //        product.trendyolComissionExpenseAmount,
//        //        product.KDV,
//        //        product.kdvExpenseAmount,
//        //        product.cargoExpense,
//        //        product.profitRate,
//        //        product.profitAmount,
//        //        product.sellingingPrice);

//        //    return excelPageDataTableClass.dtExcel;          
//        //}

//        //public void printToExcel()
//        //{
//        //    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

//        //    Microsoft.Office.Interop.Excel.Workbook worKbooK = excel.Workbooks.Add(Type.Missing);

//        //    Microsoft.Office.Interop.Excel.Worksheet worKsheeT = (Microsoft.Office.Interop.Excel.Worksheet)worKbooK.ActiveSheet;
//        //    worKsheeT.Name = "myExcell";

//        //    Microsoft.Office.Interop.Excel.Range celLrangE;

//        //    try
//        //    {
//        //        excel = new Microsoft.Office.Interop.Excel.Application();
//        //        excel.Visible = false;
//        //        excel.DisplayAlerts = false;
//        //        worKbooK = excel.Workbooks.Add(Type.Missing);


//        //        worKsheeT = (Microsoft.Office.Interop.Excel.Worksheet)worKbooK.ActiveSheet;
//        //        worKsheeT.Name = "Sheet1";



//        //        int rowcount = 2; // table row count

//        //        //creating empty rows with border================
//        //        foreach (DataRow datarow in excelPageDataTableClass.dtExcel.Rows)
//        //        {
//        //            rowcount += 1;
//        //            for (int i = 1; i <= excelPageDataTableClass.dtExcel.Columns.Count; i++)
//        //            {
//        //                if (rowcount == 3)
//        //                {
//        //                    worKsheeT.Cells[2, i] = excelPageDataTableClass.dtExcel.Columns[i - 1].ColumnName;
//        //                    worKsheeT.Cells.Font.Color = System.Drawing.Color.Black;
//        //                }
//        //                worKsheeT.Cells[rowcount, i] = datarow[i - 1].ToString();
//        //                if (rowcount > 3)
//        //                {
//        //                    if (i == excelPageDataTableClass.dtExcel.Columns.Count)
//        //                    {
//        //                        if (rowcount % 2 == 0)
//        //                        {
//        //                            celLrangE = worKsheeT.Range[worKsheeT.Cells[rowcount, 1], worKsheeT.Cells[rowcount, excelPageDataTableClass.dtExcel.Columns.Count]];
//        //                        }
//        //                    }
//        //                }

//        //            }

//        //        }

//        //        celLrangE = worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[rowcount, excelPageDataTableClass.dtExcel.Columns.Count]];
//        //        celLrangE.EntireColumn.AutoFit();
//        //        Microsoft.Office.Interop.Excel.Borders border = celLrangE.Borders;
//        //        border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
//        //        border.Weight = 2d;

//        //        celLrangE = worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[2, excelPageDataTableClass.dtExcel.Columns.Count]];

//        //        worKbooK.SaveAs("Ürün Listesi"); ;
//        //        worKbooK.Close();
//        //        excel.Quit();
//        //        //==================================================                
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        MessageBox.Show(ex.Message);

//        //    }
//        //    finally
//        //    {
//        //        worKsheeT = null;
//        //        celLrangE = null;
//        //        worKbooK = null;
//        //    }

//        //}

//    }
}
