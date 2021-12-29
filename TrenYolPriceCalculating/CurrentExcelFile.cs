using System;
using System.Data;
using System.Data.OleDb;
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
        }
    }
}
