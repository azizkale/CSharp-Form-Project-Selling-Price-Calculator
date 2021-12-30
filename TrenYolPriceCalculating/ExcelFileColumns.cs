using Excel = Microsoft.Office.Interop.Excel;


namespace TrenYolPriceCalculating
{
    class ExcelFileColumns
    {
        // to inser columns name and new rows
        public Excel.Worksheet excelFileColumns(Excel.Worksheet worksheet, int rowNumber)
        {
            worksheet.Cells[rowNumber, 1] = "ID";
            worksheet.Cells[rowNumber, 2] = "Ürün Adı";
            worksheet.Cells[rowNumber, 3] = "Alış Fiyatı";
            worksheet.Cells[rowNumber, 4] = "Trendyol Komisyon Oranı";
            worksheet.Cells[rowNumber, 5] = "Trendyol Komisyon Tutarı";
            worksheet.Cells[rowNumber, 6] = "KDV Oranı";
            worksheet.Cells[rowNumber, 7] = "KDV Tutarı";
            worksheet.Cells[rowNumber, 8] = "Kargo Gideri";
            worksheet.Cells[rowNumber, 9] = "Kar Oranı";
            worksheet.Cells[rowNumber, 10] = "Kar Tutarı";
            worksheet.Cells[rowNumber, 11] = "Toplam Gider";
            worksheet.Cells[rowNumber, 12] = "SATIŞ FİYATI";
            return worksheet;
        }
    }
}
