using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using TrenYolPriceCalculating.Classes_CommonValues;
using Excel = Microsoft.Office.Interop.Excel;

namespace TrenYolPriceCalculating
{
   
    class InsertNewRowToExcelFile
    {
       ReadingExcel readEx = new ReadingExcel();

       public void insertNewRow(Product p)
        {
            string DocumentsAndSettingsPath = PCDocumentAndSettingsPath.DocumentsAndSettingsPath;
            string filePath = PCDocumentAndSettingsPath.filePath;
            string fileExt = string.Empty;

            if (controlTheFileExistBeforeInsertProduct(filePath))
            {
                try
                {
                    OleDbConnection MyConnection;
                    OleDbCommand myCommand = new OleDbCommand();
                    string sql = null;
                    MyConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=Excel 8.0;");
                    MyConnection.Open();

                    myCommand.Connection = MyConnection;
                    sql = "Insert into [Sayfa1$] (ID," +
                        "Urun_Adi," +
                        "Alis_Fiyati," +
                        "Trendyol_Komisyon_Orani," +
                        "Trendyol_Komisyon_Tutari," +
                        "KDV_Orani," +
                        "KDV_Tutari," +
                        "Kargo_Gideri," +
                        "Kar_Orani," +
                        "Kar_Tutari," +
                        "Toplam_Gider," +
                        "SATIS_FIYATI) " +
                        "values(" +
                        "'" + generateID() + "'," +
                        "'" + p.pName + "'," +
                        "'" + p.supplyingPrice + "'," +
                        "'" + p.trendyolComissionRate + "'," +
                        "'" + p.trendyolComissionExpenseAmount + "'," +
                        "'" + p.KDV + "'," +
                        "'" + p.kdvExpenseAmount + "'," +
                        "'" + p.cargoExpense + "'," +
                        "'" + p.profitRate + "'," +
                        "'" + p.profitAmount + "'," +
                        "'" + p.totalExpenseAmount + "'," +
                        "'" + p.sellingingPrice + "')";

                    myCommand.CommandText = sql;
                    myCommand.ExecuteNonQuery();
                    MyConnection.Close();

                    MessageBox.Show(p.pName + " adlı ürün başarı ile kaydedilmiştir.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Ürün ekleme işleminden önce bir dosya oluşturmalısnız.");
            }

        }
       

    private string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }

        private bool controlTheFileExistBeforeInsertProduct(string path)
        {
            return File.Exists(path);
        }
    }
   
}
