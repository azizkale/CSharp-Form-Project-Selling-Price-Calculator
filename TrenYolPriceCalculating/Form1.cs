﻿using System;
using System.Windows.Forms;

namespace TrenYolPriceCalculating
{
    public partial class yenimar : Form
    {
        Product p = new Product();
        ExcelClass ex = new ExcelClass();
        public yenimar()
        {
            InitializeComponent();
        }       

        private void bynCalculate_Click(object sender, EventArgs e)
        {
            p.pName = txtProductName.Text;
            p.supplyingPrice = numSupplyingPrice.Value;
            p.trendyolComissionRate = numTrenyolComission.Value;
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


        
        private void btnCreateExcell_Click(object sender, EventArgs e)
        {
            ex.ExportToExcel(p);
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            CurrentExcelFile f = new CurrentExcelFile();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // adds new product to current excell
            excelPageDataTableClass.dtExcel.Rows.Add(
               p.pName,
               p.supplyingPrice,
               p.trendyolComissionRate,
               p.trendyolComissionExpenseAmount,
               p.KDV,
               p.kdvExpenseAmount,
               p.cargoExpense,
               p.profitRate,
               p.profitAmount,
               p.sellingingPrice);

            ex.printToExcel();
        }
    }
}  