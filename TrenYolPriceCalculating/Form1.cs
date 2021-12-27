using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrenYolPriceCalculating
{
    public partial class yenimar : Form
    {
        Product p = new Product();
        public yenimar()
        {
            InitializeComponent();
        }       

        private void bynCalculate_Click(object sender, EventArgs e)
        {
            p.pName = txtProductName.Text;
            p.supplyingPrice = numSupplyingPrice.Value;
            p.trenyolComission = numTrenyolComission.Value;
            p.cargoExpense = numCargoExpense.Value;
            p.KDV = numKDV.Value;
            p.profitRate = numProfitRate.Value;
            p.calculateSellingPrice();

            lblSellingPriceAmount.Text = p.calculateSellingPrice().ToString()+" TL";

            lblTrenyolComissionAmount.Text = p.calculateTrendyolComisssionExpenseAmount().ToString() + " TL";

            lblKDVAmount.Text = p.calculateKDVExpenseAmount().ToString() + " TL";

            lblProfitAmount.Text = p.calculateprofitAmount().ToString() + " TL";

            lblCargoExpenseAmount.Text = p.cargoExpense.ToString() + " TL";

            showSellingAndgPrice_Labels();

        }

        void showSellingAndgPrice_Labels()
        {
            lblSatisFiyatiLabel.Visible = true;
            lblSellingPriceAmount.Visible = true;
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