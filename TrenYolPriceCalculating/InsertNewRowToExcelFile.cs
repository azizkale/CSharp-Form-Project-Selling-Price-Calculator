using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TrenYolPriceCalculating
{
   
    class InsertNewRowToExcelFile
    {
       ReadingExcel readEx = new ReadingExcel();

       public void insertNewRow(Product p)
        {
            string DocumentsAndSettingsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = DocumentsAndSettingsPath + "\\Ürünler.xls";
            string fileExt = string.Empty;

            try
            {
               OleDbConnection MyConnection;
                OleDbCommand myCommand = new OleDbCommand();
                string sql = null;
                MyConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source="+ filePath + ";Extended Properties=Excel 8.0;");
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
                    "'"+generateID()+"'," +
                    "'"+p.pName+"'," +
                    "'"+p.supplyingPrice+"'," +
                    "'"+p.trendyolComissionRate+"'," +
                    "'"+p.trendyolComissionExpenseAmount+"'," +
                    "'"+p.KDV+"'," +
                    "'"+p.kdvExpenseAmount+"'," +
                    "'"+p.cargoExpense+"'," +
                    "'"+p.profitRate+"'," +
                    "'"+p.profitAmount+"'," +
                    "'"+p.totalExpenseAmount+"'," +
                    "'"+p.sellingingPrice+"')";

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
        public string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
   
}
