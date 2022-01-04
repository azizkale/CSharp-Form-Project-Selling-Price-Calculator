using System.Windows.Forms;
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
            worksheet.Cells[1, 2] = "Urun_Adi";
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
            return worksheet;
        }

        public void giveTurkishNamesToColumnsHeaderTexts(DataGridView dgv)
        {
           dgv.Columns[0].HeaderText = "ID";
           dgv.Columns[1].HeaderText = "Ürün Adı";
           dgv.Columns[2].HeaderText = "Alış Fiyatı" + "\n" + "(TL)";
           dgv.Columns[3].HeaderText = "Trendyol Komisyon Oranı" + "\n" + "(%)";
           dgv.Columns[4].HeaderText = "Trendyol Komisyon Tutarı" + "\n" + "(TL)";
           dgv.Columns[5].HeaderText = "KDV Oranı" + "\n" + "(%)";
           dgv.Columns[6].HeaderText = "KDV Tutarı" + "\n" + "(TL)";
           dgv.Columns[7].HeaderText = "Kargo Gideri" + "\n" + "(TL)";
           dgv.Columns[8].HeaderText = "Kar Oranı" + "\n" + "(%)";
           dgv.Columns[9].HeaderText  = "Kar Tutarı" + "\n" + "(TL)";
           dgv.Columns[10].HeaderText = "Toplam Gider" + "\n" + "(TL)";
           dgv.Columns[11].HeaderText = "SATIŞ FİYATI" + "\n" + "(TL)";
        }
    }
}
