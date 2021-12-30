using Excel = Microsoft.Office.Interop.Excel;


namespace TrenYolPriceCalculating
{
    class ExcelFileColumns
    {
        // to inser columns name and new rows
        public Excel.Worksheet excelFileColumns(Excel.Worksheet worksheet, int rowNumber)
        {
            //this names are used on OLEDB connection to manipulate the rows
            worksheet.Cells[1, 1] = "ID";
            worksheet.Cells[1, 2] = "Ürün_Adi";
            worksheet.Cells[1, 3] = "Alis_Fiyati";
            worksheet.Cells[1, 4] = "Trendyol_Komisyon_Orani";
            worksheet.Cells[1, 5] = "Trendyol_Komisyon_Tutari";
            worksheet.Cells[1, 6] = "KDV_Orani";
            worksheet.Cells[1, 7] = "KDV_Tutari";
            worksheet.Cells[1, 8] = "Kargo_Gideri";
            worksheet.Cells[1, 9] = "Kar_Orani";
            worksheet.Cells[1, 10] = "Kar_Tutari";
            worksheet.Cells[1, 11] = "Toplam_Gider";
            worksheet.Cells[1, 12] = "SATIS_FIYATI";

            worksheet.Rows[1].Visible = false;

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
