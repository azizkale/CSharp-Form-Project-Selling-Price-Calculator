using System;
using System.Data;
using System.Windows.Forms;

namespace TrenYolPriceCalculating
{
    class ExcelClass: Product
    {
        public DataTable table { get; set; }

        public DataTable ExportToExcel(Product product)
        {
            createAndFillExcellColumns(product);
            printToExcel();
            return table;
        }

        public void createAndFillExcellColumns(Product product)
        {
            ExcelColumns excol = new ExcelColumns();
            this.table = new DataTable();
            excol.createExcelColumns(this.table);


            this.table.Rows.Add(
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
                foreach (DataRow datarow in table.Rows)
                {
                    rowcount += 1;
                    for (int i = 1; i <= table.Columns.Count; i++)
                    {
                        if (rowcount == 3)
                        {
                            worKsheeT.Cells[2, i] = table.Columns[i - 1].ColumnName;
                            worKsheeT.Cells.Font.Color = System.Drawing.Color.Black;
                        }
                        worKsheeT.Cells[rowcount, i] = datarow[i - 1].ToString();
                        if (rowcount > 3)
                        {
                            if (i == table.Columns.Count)
                            {
                                if (rowcount % 2 == 0)
                                {
                                    celLrangE = worKsheeT.Range[worKsheeT.Cells[rowcount, 1], worKsheeT.Cells[rowcount, table.Columns.Count]];
                                }
                            }
                        }

                    }

                }

                celLrangE = worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[rowcount, table.Columns.Count]];
                celLrangE.EntireColumn.AutoFit();
                Microsoft.Office.Interop.Excel.Borders border = celLrangE.Borders;
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                border.Weight = 2d;

                celLrangE = worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[2, table.Columns.Count]];

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
