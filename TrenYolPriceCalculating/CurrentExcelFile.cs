﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;


using System.Windows.Forms;

namespace TrenYolPriceCalculating
{
    public partial class CurrentExcelFile : Form
    {
        ReadingExcel expage = new ReadingExcel();
        Product productForUpdate;

        public CurrentExcelFile()
        {
            InitializeComponent();
            expage.LoadExcelFromPC(dataGridView1);//loading excel file
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;//auto cell heights

            dataGridView1.Rows[0].DefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dataGridView1.Columns[0].Visible = false; // hides the ID column
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Font = new Font("Tahoma", 12);

            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;//wrapping text into cells           

        }

        private void txtSearch_TextChanged(object sender, System.EventArgs e)
        {
            string DocumentsAndSettingsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = DocumentsAndSettingsPath + "\\Ürünler.xls";

            try
            {
                OleDbConnection MyConnection;
                OleDbCommand myCommand = new OleDbCommand();
                string sql = null;
                MyConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=Excel 8.0;");
                MyConnection.Open();

                myCommand.Connection = MyConnection;
                sql = "Select * from [Sayfa1$] where Urun_Adi like '%" + txtSearch.Text + "%' OR Urun_Adi = 'Ürün Adı'";

                DataTable dtexcel = new DataTable();
                OleDbDataAdapter oleAdpt = new OleDbDataAdapter(sql,MyConnection);
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
        }       
        

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            /* !!!!!!CODE BELOW WORKS WELL.!!!!! */
           
            //string DocumentsAndSettingsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //string filePath = DocumentsAndSettingsPath + "\\Ürünler.xls";
            //try
            //{
            //    OleDbConnection MyConnection;
            //    OleDbCommand myCommand = new OleDbCommand();
            //    string sql = null;
            //    MyConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=Excel 8.0;");
            //    MyConnection.Open();

            //    myCommand.Connection = MyConnection;
            //    int columnindex = dataGridView1.CurrentCell.ColumnIndex;  
                
            //    sql = "update [Sayfa1$] set "+ dataGridView1.Rows[e.RowIndex].Cells[columnindex].OwningColumn.HeaderText + " = '" + dataGridView1.Rows[e.RowIndex].Cells[columnindex].Value.ToString() + "' where ID = '"+ dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";

            //    OleDbDataAdapter oleAdpt = new OleDbDataAdapter(sql, MyConnection);
            //    oleAdpt.UpdateCommand = MyConnection.CreateCommand();
            //    oleAdpt.UpdateCommand.CommandText = sql;
            //    oleAdpt.UpdateCommand.ExecuteNonQuery();               
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productForUpdate = new Product();           
            try
            {
                productForUpdate.pName = dataGridView1.SelectedRows[0].Cells["Urun_Adi"].Value.ToString();
                productForUpdate.supplyingPrice = Decimal.Parse(dataGridView1.SelectedRows[0].Cells["Alis_Fiyati"].Value.ToString());
                productForUpdate.trendyolComissionRate = Decimal.Parse(dataGridView1.SelectedRows[0].Cells["Trendyol_Komisyon_Orani"].Value.ToString());
                productForUpdate.cargoExpense = Decimal.Parse(dataGridView1.SelectedRows[0].Cells["Kargo_Gideri"].Value.ToString());
                productForUpdate.KDV = Decimal.Parse(dataGridView1.SelectedRows[0].Cells["KDV_Orani"].Value.ToString());
                productForUpdate.profitRate = Decimal.Parse(dataGridView1.SelectedRows[0].Cells["Kar_Orani"].Value.ToString());
                productForUpdate.ID = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();

                this.Close(); // closes the product list window

                yenimar ye = new yenimar(productForUpdate);
                ye.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Geçerli bir satırı tam olarak seçtiğinizden emin olnuz.");
            }
          
        }
    }

    
}
