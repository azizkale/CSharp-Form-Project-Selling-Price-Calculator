using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace TrenYolPriceCalculating
{
    public partial class yenimar : Form
    {
        Product p = new Product();
        CreatingExcel ex = new CreatingExcel();
        ProductValidator validator = new ProductValidator();
        bool calculatingControl = false; // controls whether at first being done calculating before adding new product

        public yenimar()
        {
            InitializeComponent();
            lblSatisFiyatiLabel.Visible = false;
            lblSellingPriceAmount.Visible = false;
        }       

        private void bynCalculate_Click(object sender, EventArgs e)
        {
            p.pName = txtProductName.Text;
            p.supplyingPrice = numSupplyingPrice.Value;
            p.trendyolComissionRate = numTrenyolComission.Value;
            p.cargoExpense = numCargoExpense.Value;
            p.KDV = numKDV.Value;
            p.profitRate = numProfitRate.Value;
            calculatingControl = true;

            if (validator.Validate(p))
            {
                p.calculateSellingPrice();

                lblSellingPriceAmount.Text = p.calculateSellingPrice().ToString() + " TL";
                lblTrenyolComissionAmount.Text = p.calculateTrendyolComisssionExpenseAmount().ToString() + " TL";
                lblKDVAmount.Text = p.calculateKDVExpenseAmount().ToString() + " TL";
                lblProfitAmount.Text = p.calculateprofitAmount().ToString() + " TL";
                lblCargoExpenseAmount.Text = p.cargoExpense.ToString() + " TL";
                showSellingAndgPrice_Labels();
            }
        }

        void showSellingAndgPrice_Labels()
        {
            lblSatisFiyatiLabel.Visible = true;
            lblSellingPriceAmount.Visible = true;
        }
       
       

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yeniDosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            ex.createAndExportToExcel();
        }

        private void dosyayıAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentExcelFile f = new CurrentExcelFile();
            f.ShowDialog();
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            InsertNewRowToExcelFile ins = new InsertNewRowToExcelFile();            
            try
            {
                if (calculatingControl)
                {
                    ins.insertNewRow(p);                   
                }
                else
                    MessageBox.Show("Lütfen ilk önce ürünün fiyat hesaplamasını yapınız.");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
          
            
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "";

            numCargoExpense.Value = 0;
            lblCargoExpenseAmount.Text = "";

            numKDV.Value = 0;
            lblKDVAmount.Text = "";

            numProfitRate.Value = 0;
            lblProfitAmount.Text = "";

            numSupplyingPrice.Value = 0;

            numTrenyolComission.Value = 0;
            lblTrenyolComissionAmount.Text = "";

            lblSatisFiyatiLabel.Visible = false;
            lblSellingPriceAmount.Visible = false;
        }

        private void numSupplyingPrice_Enter(object sender, EventArgs e)
        {
            numSupplyingPrice.Select(0, numSupplyingPrice.Text.Length);
        }

        private void numTrenyolComission_Enter(object sender, EventArgs e)
        {
            numTrenyolComission.Select(0, numTrenyolComission.Text.Length);
        }

        private void numCargoExpense_Enter(object sender, EventArgs e)
        {
            numCargoExpense.Select(0, numCargoExpense.Text.Length);
        }

        private void numKDV_Enter(object sender, EventArgs e)
        {
            numKDV.Select(0, numKDV.Text.Length);

        }

        private void numProfitRate_Enter(object sender, EventArgs e)
        {
            numProfitRate.Select(0, numProfitRate.Text.Length);
        }
    }
}  