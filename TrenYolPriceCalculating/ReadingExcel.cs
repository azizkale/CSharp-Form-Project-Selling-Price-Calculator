using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TrenYolPriceCalculating
{
    class ReadingExcel
    {
        //only DataTable in the App
        public static DataTable dtExcel = new DataTable();

        public void LoadExcelFromPC(DataGridView dataGridView1)
        {
            string DocumentsAndSettingsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = DocumentsAndSettingsPath+ "\\Ürünler.xls";
            string fileExt = string.Empty;

            fileExt = Path.GetExtension(filePath); //get the file extension  
            if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xls") == 0)
            {
                try
                {
                    ReadingExcel.dtExcel = new DataTable();
                    ReadingExcel.dtExcel = ReadExcel(filePath, fileExt); //read excel file           
                    dataGridView1.DataSource = ReadingExcel.dtExcel;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please choose .xls or .xlsx file only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); //custom messageBox to show error  
            }
        }


        public DataTable ReadExcel(string fileName, string fileExt)
        {
            string conn = string.Empty;
            DataTable dtexcel = new DataTable();
            if (fileExt.CompareTo(".xlsx") == 0)//compare the extension of the file
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';";//for below excel 2007
            else
                conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1';";//for above excel 2007

            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [Sayfa1$]", con);//here we read data from sheet1
                    oleAdpt.Fill(dtexcel);//fill excel data into dataTable
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            return dtexcel;
        }
    }
}
