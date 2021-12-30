using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TrenYolPriceCalculating
{
   
    class InsertNewRowToExcelFile
    {
       ReadingExcel readEx = new ReadingExcel();

       public void insertNewRow(Product p)
        {
            //DataTable dt = new DataTable();
            //DataGridView dgv = new DataGridView();
            //ExcelFileColumns columns = new ExcelFileColumns();

            //readEx.LoadExcelFromPC(dgv); // it runs the the function "LoadExcelFromPC" and ReadingExcel.dtExcel is able to be filled

            //dt = ReadingExcel.dtExcel;

            //int rowCountInTheAvailableExcelFile = 0 +1; // column headers row and another rows
            //rowCountInTheAvailableExcelFile = dt.Rows.Count;      

          


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
                sql = "Insert into [Sayfa1$] (ID,Urun_Adi) values('7','asdgfdgdfd')";
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
