using System.Drawing;
using System.Windows.Forms;
using TrenYolPriceCalculating;

namespace YENİMAR.Classes_CommonValues
{
    class DataGridView_ProductList_Styles
    {
        public void giveStyleToDatagridView1(DataGridView dgv)
        {
            ExcelFileColumns exfileCol = new ExcelFileColumns();

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;//auto cell heights

            dgv.Rows[0].DefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dgv.Columns[0].Visible = false; // hides the ID column
            dgv.RowTemplate.Height = 30;
            dgv.ColumnHeadersVisible = true;
            dgv.Font = new Font("Tahoma", 12);

            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;//wrapping text into cells 

            // to color the columns
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (i % 2 == 0)
                    dgv.Columns[i].DefaultCellStyle.BackColor = Color.Beige;
                else
                    dgv.Columns[i].DefaultCellStyle.BackColor = Color.Bisque;
            }

            // colorss the last colum with different color
            dgv.Columns[dgv.Columns.Count - 1].DefaultCellStyle.BackColor = Color.Turquoise;

            //define the color of the selectedRow
            dgv.DefaultCellStyle.SelectionBackColor = Color.MediumAquamarine;

            //gives names with charachters taht are unknown according to sql
            exfileCol.giveTurkishNamesToColumnsHeaderTexts(dgv);

            //centers the text of columns' headers
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }
    }
}
