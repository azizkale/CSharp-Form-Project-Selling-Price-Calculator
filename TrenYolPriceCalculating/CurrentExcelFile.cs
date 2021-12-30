using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;

using System.Windows.Forms;

namespace TrenYolPriceCalculating
{
    public partial class CurrentExcelFile : Form
    {
        ReadingExcel expage = new ReadingExcel();
        public CurrentExcelFile()
        {
            InitializeComponent();
            expage.LoadExcelFromPC(dataGridView1);//loading excel file
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Rows[0].DefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dataGridView1.Visible = true;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Font = new Font("Tahoma", 12);

        }
    }
}
