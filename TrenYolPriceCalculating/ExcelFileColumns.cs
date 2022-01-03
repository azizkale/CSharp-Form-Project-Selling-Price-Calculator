using Excel = Microsoft.Office.Interop.Excel;


namespace TrenYolPriceCalculating
{
    class ExcelFileColumns
    {
        // to inser columns name and new rows
        public Excel.Worksheet excelFileColumns(Excel.Worksheet worksheet, int rowNumber)
        {
            //this names are used on OLEDB connection to manipulate the rows(on sql commands)
            worksheet.Cells[1, 1] = "ID";
            worksheet.Cells[1, 2] = "No";
            worksheet.Cells[1, 3] = "Urun_Adi";
            worksheet.Cells[1, 4] = "Alis_Fiyati";
            worksheet.Cells[1, 5] = "Trendyol_Komisyon_Orani";
            worksheet.Cells[1, 6] = "Trendyol_Komisyon_Tutari";
            worksheet.Cells[1, 7] = "KDV_Orani";
            worksheet.Cells[1, 8] = "KDV_Tutari";
            worksheet.Cells[1, 9] = "Kargo_Gideri";
            worksheet.Cells[1, 10] = "Kar_Orani";
            worksheet.Cells[1, 11] = "Kar_Tutari";
            worksheet.Cells[1, 12] = "Toplam_Gider";
            worksheet.Cells[1, 13] = "SATIS_FIYATI";
            //these are turkish column names
            worksheet.Cells[rowNumber, 1] = "ID";
            worksheet.Cells[rowNumber, 2] = "No.";
            worksheet.Cells[rowNumber, 3] = "Ürün Adı";
            worksheet.Cells[rowNumber, 4] = "Alış Fiyatı" + "\n" +"(TL)";
            worksheet.Cells[rowNumber, 5] = "Trendyol Komisyon Oranı" + "\n" + "(%)";
            worksheet.Cells[rowNumber, 6] = "Trendyol Komisyon Tutarı" + "\n" + "(TL)";
            worksheet.Cells[rowNumber, 7] = "KDV Oranı" + "\n" + "(%)";
            worksheet.Cells[rowNumber, 8] = "KDV Tutarı" + "\n" + "(TL)";
            worksheet.Cells[rowNumber, 9] = "Kargo Gideri" + "\n" + "(TL)";
            worksheet.Cells[rowNumber, 10] ="Kar Oranı" + "\n" + "(%)";
            worksheet.Cells[rowNumber, 11] = "Kar Tutarı" + "\n" + "(TL)";
            worksheet.Cells[rowNumber, 12] = "Toplam Gider" + "\n" + "(TL)";
            worksheet.Cells[rowNumber, 13] = "SATIŞ FİYATI" + "\n" + "(TL)";            
            return worksheet;
        }
    }
}
