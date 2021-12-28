using System;
using System.Data;
using System.Data.OleDb;
using System.IO;

using System.Windows.Forms;

namespace TrenYolPriceCalculating
{
    public partial class CurrentExcelFile : Form
    {
        excelPageDataTableClass expage = new excelPageDataTableClass();
        public CurrentExcelFile()
        {
            InitializeComponent();
            expage.LoadExcelFromPC(dataGridView1);
        }
        
              

       

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
