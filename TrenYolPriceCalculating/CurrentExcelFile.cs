using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TrenYolPriceCalculating.Classes_CommonValues;
using YENİMAR.Classes_CommonValues;

namespace TrenYolPriceCalculating
{
    public partial class CurrentExcelFile : Form
    {
        ReadingExcel expage = new ReadingExcel();
        Product productForUpdate;
        DataGridView_ProductList_Styles dgvStyle = new DataGridView_ProductList_Styles();

        public CurrentExcelFile()
        {
            InitializeComponent();
            expage.LoadExcelFromPC(dataGridView1);//loading excel file
            this.StartPosition = FormStartPosition.CenterScreen; // positions the window

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvStyle.giveStyleToDatagridView1(dataGridView1);           
        }

        private void txtSearch_TextChanged(object sender, System.EventArgs e)
        {
            string DocumentsAndSettingsPath = PCDocumentAndSettingsPath.DocumentsAndSettingsPath;
            string filePath = PCDocumentAndSettingsPath.filePath;

            try
            {
                OleDbConnection MyConnection;
                OleDbCommand myCommand = new OleDbCommand();
                string sql = null;
                MyConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=Excel 8.0;");
                MyConnection.Open();

                myCommand.Connection = MyConnection;
                sql = "Select * from [Sayfa1$] where Urun_Adi like '%" + txtSearch.Text + "%'";

                DataTable dtexcel = new DataTable();
                OleDbDataAdapter oleAdpt = new OleDbDataAdapter(sql, MyConnection);
                oleAdpt.Fill(dtexcel);//fill excel data into dataTable
                dataGridView1.DataSource = dtexcel;

                myCommand.CommandText = sql;
                myCommand.ExecuteNonQuery();
                MyConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnClearSearchTextBox_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtInvoiceAmount.Text = "";
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productForUpdate = new Product();
            try
            {
                productForUpdate.pName = dataGridView1.SelectedRows[0].Cells["Urun_Adi"].Value.ToString();
                productForUpdate.supplyingPrice =Decimal.Parse(dataGridView1.SelectedRows[0].Cells["Alis_Fiyati"].Value.ToString());
                productForUpdate.trendyolComissionRate = Decimal.Parse(dataGridView1.SelectedRows[0].Cells["Trendyol_Komisyon_Orani"].Value.ToString());
                productForUpdate.cargoExpense = Decimal.Parse(dataGridView1.SelectedRows[0].Cells["Kargo_Gideri"].Value.ToString());
                productForUpdate.KDV = Decimal.Parse(dataGridView1.SelectedRows[0].Cells["KDV_Orani"].Value.ToString());
                productForUpdate.profitRate = Decimal.Parse(dataGridView1.SelectedRows[0].Cells["Kar_Orani"].Value.ToString());
                productForUpdate.ID = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();


                yenimar ye = new yenimar(productForUpdate);
                ye.ShowDialog();
               
            }
            catch (Exception)
            {
                MessageBox.Show("Geçerli bir satırı tam olarak seçtiğinizden emin olnuz.");
            }
            
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string DocumentsAndSettingsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Ürünler.xls";
          
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                try
                {
                    Excel.Application xlexcel;
                    Excel.Workbook xlWorkBook;
                    Excel.Worksheet xlWorkSheet;
                    Excel.Range xlRange;
                    object misValue = System.Reflection.Missing.Value;
                    xlexcel = new Excel.Application();

                    xlexcel.Visible = true;

                    //~~>  Open a File
                    xlWorkBook = xlexcel.Workbooks.Open(DocumentsAndSettingsPath, 0, false, 5, "", "", true,
                    Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

                    //~~> Work with Sheet1
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    //determines the row that be wanted to delete
                    xlRange = (Excel.Range)xlWorkSheet.Cells[dataGridView1.CurrentCell.RowIndex + 2, 1];

                    //~~> Remove any filters if there are
                    xlWorkSheet.AutoFilterMode = false;

                    //~~> Delete the range in one go
                    xlRange.EntireRow.Delete(Excel.XlDirection.xlToRight);

                    //~~> Remove filters
                    xlWorkSheet.AutoFilterMode = false;

                    //~~> Close and cleanup
                    xlWorkBook.Close(true, misValue, misValue);
                    xlexcel.Quit();

                    Marshal.ReleaseComObject(xlRange);
                    Marshal.ReleaseComObject(xlWorkSheet);
                    Marshal.ReleaseComObject(xlWorkBook);
                    Marshal.ReleaseComObject(xlexcel);

                    //the file is loaded again after deleting
                    expage.LoadExcelFromPC(dataGridView1);
                }
                catch (Exception)
                {
                    MessageBox.Show("Silme işlemi sırasında bir hata oluştu.");
                }
               
            }             

                    
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
           
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, new Font("Times Roman", 18, FontStyle.Regular), SystemBrushes.ControlText, headerBounds, centerFormat);
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                txtSearch.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();               txtInvoiceAmount.Text = "";
            }
        }       

        private void cmbKdv_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbKdv.SelectedItem.ToString());
            string productSellingPrice =dataGridView1.SelectedRows[0].Cells[11].Value.ToString();

            decimal kdvAmount = Decimal.Parse(String.Format("{0:0.##}",cmbKdv.SelectedItem.ToString()));
            decimal invoiceAmount = Decimal.Parse(String.Format("{0:0.##}",productSellingPrice))*100  /(100M + kdvAmount);

            txtInvoiceAmount.Text = invoiceAmount.ToString("C2");
        }
    }
    
}
