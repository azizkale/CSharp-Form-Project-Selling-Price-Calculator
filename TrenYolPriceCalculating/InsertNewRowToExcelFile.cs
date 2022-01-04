using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using TrenYolPriceCalculating.Classes_CommonValues;

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

            if (CommonFunctions.controlTheFileExistBeforeInsertProduct(filePath))
            {
                try
                {
                    OleDbConnection MyConnection;
                    OleDbCommand myCommand = new OleDbCommand();
                    string sql = null;
                    MyConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=Excel 8.0;");
                    MyConnection.Open();

                    myCommand.Connection = MyConnection;
                    sql = "Insert into [Sayfa1$] (" +
                        "ID," +
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
                        "'" + p.supplyingPrice.ToString("C2") + "'," +
                        "'" + p.trendyolComissionRate.ToString("F2") + "'," +
                        "'" + p.trendyolComissionExpenseAmount.ToString("C2") + "'," +
                        "'" + p.KDV.ToString("F2") + "'," +
                        "'" + p.kdvExpenseAmount.ToString("C2") + "'," +
                        "'" + p.cargoExpense.ToString("C2") + "'," +
                        "'" + p.profitRate.ToString("F2") + "'," +
                        "'" + p.profitAmount.ToString("C2") + "'," +
                        "'" + p.totalExpenseAmount.ToString("C2") + "'," +
                        "'" + p.sellingingPrice.ToString("C2") + "')";

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
       
    }
   
}
