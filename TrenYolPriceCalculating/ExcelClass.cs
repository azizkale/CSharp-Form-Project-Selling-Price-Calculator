using System;
using System.Data;
using System.Windows.Forms;

namespace TrenYolPriceCalculating
{
    class ExcelClass: Product
    {
        public DataTable ExportToExcel(Product product)
        {
            createAndFillExcellColumns(product);
            printToExcel();
            return excelPageDataTableClass.dtExcel;
        }

        public DataTable createAndFillExcellColumns(Product product)
        {
            ExcelColumns excol = new ExcelColumns();
            excol.createExcelColumns(excelPageDataTableClass.dtExcel);


            excelPageDataTableClass.dtExcel.Rows.Add(
                product.pName,
                product.supplyingPrice,
                product.trendyolComissionRate,
                product.trendyolComissionExpenseAmount,
                product.KDV,
                product.kdvExpenseAmount,
                product.cargoExpense,
                product.profitRate,
                product.profitAmount,
                product.sellingingPrice);

            return excelPageDataTableClass.dtExcel;          
        }

        public void printToExcel()
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbook worKbooK = excel.Workbooks.Add(Type.Missing);

            Microsoft.Office.Interop.Excel.Worksheet worKsheeT = (Microsoft.Office.Interop.Excel.Worksheet)worKbooK.ActiveSheet;
            worKsheeT.Name = "myExcell";

            Microsoft.Office.Interop.Excel.Range celLrangE;

            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                worKbooK = excel.Workbooks.Add(Type.Missing);


                worKsheeT = (Microsoft.Office.Interop.Excel.Worksheet)worKbooK.ActiveSheet;
                worKsheeT.Name = "Sheet1";



                int rowcount = 2; // table row count

                //creating empty rows with border================
                foreach (DataRow datarow in excelPageDataTableClass.dtExcel.Rows)
                {
                    rowcount += 1;
                    for (int i = 1; i <= excelPageDataTableClass.dtExcel.Columns.Count; i++)
                    {
                        if (rowcount == 3)
                        {
                            worKsheeT.Cells[2, i] = excelPageDataTableClass.dtExcel.Columns[i - 1].ColumnName;
                            worKsheeT.Cells.Font.Color = System.Drawing.Color.Black;
                        }
                        worKsheeT.Cells[rowcount, i] = datarow[i - 1].ToString();
                        if (rowcount > 3)
                        {
                            if (i == excelPageDataTableClass.dtExcel.Columns.Count)
                            {
                                if (rowcount % 2 == 0)
                                {
                                    celLrangE = worKsheeT.Range[worKsheeT.Cells[rowcount, 1], worKsheeT.Cells[rowcount, excelPageDataTableClass.dtExcel.Columns.Count]];
                                }
                            }
                        }

                    }

                }

                celLrangE = worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[rowcount, excelPageDataTableClass.dtExcel.Columns.Count]];
                celLrangE.EntireColumn.AutoFit();
                Microsoft.Office.Interop.Excel.Borders border = celLrangE.Borders;
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                border.Weight = 2d;

                celLrangE = worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[2, excelPageDataTableClass.dtExcel.Columns.Count]];

                worKbooK.SaveAs("Ürün Listesi"); ;
                worKbooK.Close();
                excel.Quit();
                //==================================================                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                worKsheeT = null;
                celLrangE = null;
                worKbooK = null;
            }

        }

    }
}
