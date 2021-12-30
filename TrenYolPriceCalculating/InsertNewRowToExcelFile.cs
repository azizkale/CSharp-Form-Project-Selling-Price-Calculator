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
                sql = "Insert into [Sayfa1$] (ID,Urun_Adi,KDV_Orani) values('7','asdgfdgdfd','2')";
                myCommand.CommandText = sql;
                myCommand.ExecuteNonQuery();
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }         

        }

      





    }
}
