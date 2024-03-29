﻿using System;
using System.Data.OleDb;
using System.Text.Json;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using TrenYolPriceCalculating.Classes_CommonValues;
using WebSocketSharp;

namespace TrenYolPriceCalculating 
{
    public partial class yenimar : Form
    {
        Product pCalculate = new Product();
        Product pUpdate = new Product();
        CreatingExcel ex = new CreatingExcel();
        ProductValidator validator = new ProductValidator();
        ReadingExcel readExcel = new ReadingExcel();
        bool calculatingControl = false; // controls whether at first being done calculating before adding new product
      

        public yenimar(Product pFromCurrentExcelFile)
        {
            InitializeComponent();
            //
            this.StartPosition = FormStartPosition.CenterScreen;
            //
            this.AcceptButton = btnCalculate;
            //
            lblSatisFiyatiLabel.Visible = false;
            lblSellingPriceAmount.Visible = false;
            btnProductUpdate.Visible = false;
            //
            lblInvoiceLabel.Visible = false;

            //if user doesn't update sth, he/she can see menuStrip1
            menuStrip1.Visible = true;

            // to update product
            if(pFromCurrentExcelFile.ID != null)
            {
                //if user opens the yenimar Form to update sth, he/she can't see menuStrip1
                menuStrip1.Visible = false;

                this.pUpdate = pFromCurrentExcelFile;

                txtProductName.Text = pFromCurrentExcelFile.pName;
                numSupplyingPrice.Value = pFromCurrentExcelFile.supplyingPrice;
                numTrenyolComission.Value = pFromCurrentExcelFile.trendyolComissionRate;
                numCargoExpense.Value = pFromCurrentExcelFile.cargoExpense;
                numKDV.Value = pFromCurrentExcelFile.KDV;
                numProfitRate.Value = pFromCurrentExcelFile.profitRate;

                btnProductUpdate.Visible = true;
                this.AcceptButton = btnProductUpdate;
                this.Text = "YENİMAR - ÜRÜN GEÜLLEME";
            }

            //websocket connection function
            this.webSocketConnection();

        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            calculateProductsValues(pCalculate);
        }

        void showSellingAndgPrice_Labels()
        {
            lblSatisFiyatiLabel.Visible = true;
            lblSellingPriceAmount.Visible = true;
            //
            //invoie amount 
            lblInvoiceLabel.Visible = true;
        }
       
        void calculateProductsValues(Product product)
        {
            product.pName = txtProductName.Text;
            product.supplyingPrice = numSupplyingPrice.Value;
            product.trendyolComissionRate = numTrenyolComission.Value;
            product.cargoExpense = numCargoExpense.Value;
            product.KDV = numKDV.Value;
            product.profitRate = numProfitRate.Value;
            calculatingControl = true;

            if (validator.Validate(product))
            {
                product.calculateSellingPrice();

                lblSellingPriceAmount.Text = product.calculateSellingPrice().ToString("C2");
                lblTrenyolComissionAmount.Text = product.calculateTrendyolComisssionExpenseAmount().ToString("C2");
                lblKDVAmount.Text = product.calculateKDVExpenseAmount().ToString("C2");
                lblProfitAmount.Text = product.calculateprofitAmount().ToString("C2");
                lblCargoExpenseAmount.Text = product.cargoExpense.ToString("C2");
                lblInvoieAmount.Text = product.calculateInvoice().ToString("C2");
                showSellingAndgPrice_Labels();

            }
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
            if (CommonFunctions.controlTheFileExistBeforeInsertProduct(PCDocumentAndSettingsPath.filePath))
            {
                CurrentExcelFile f = new CurrentExcelFile();
                try
                {
                    f.ShowDialog();
                }
                catch (Exception)
                {
                }
            }
            else
                MessageBox.Show("Önce bir dosya oluşturmalısnız.");

        }      

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cleanTheForm();
        }

        void cleanTheForm()
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

            lblInvoieAmount.Text = "";
            lblInvoiceLabel.Visible = false;

            lblSatisFiyatiLabel.Visible = false;
            lblSellingPriceAmount.Visible = false;
        }

        private void ürünEkleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            InsertNewRowToExcelFile ins = new InsertNewRowToExcelFile();
            try
            {
                if (calculatingControl)
                {
                    ins.insertNewRow(pCalculate);
                    cleanTheForm();
                }
                else
                {
                    MessageBox.Show("Lütfen ilk önce ürünün fiyat hesaplamasını yapınız.");

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void numSupplyingPrice_Enter(object sender, EventArgs e)
        {
            numSupplyingPrice.Select(0, numSupplyingPrice.Text.Length);          
        }

        private void numSupplyingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(','))
            {
                e.KeyChar = ((System.Globalization.CultureInfo)System.Globalization.CultureInfo.CurrentCulture).NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }

        private void numTrenyolComission_Enter(object sender, EventArgs e)
        {
            numTrenyolComission.Select(0, numTrenyolComission.Text.Length);
        }

        private void numTrenyolComission_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(','))
            {
                e.KeyChar = ((System.Globalization.CultureInfo)System.Globalization.CultureInfo.CurrentCulture).NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }

        private void numCargoExpense_Enter(object sender, EventArgs e)
        {
            numCargoExpense.Select(0, numCargoExpense.Text.Length);
        }

        private void numCargoExpense_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(','))
            {
                e.KeyChar = ((System.Globalization.CultureInfo)System.Globalization.CultureInfo.CurrentCulture).NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }

        private void numKDV_Enter(object sender, EventArgs e)
        {
            numKDV.Select(0, numKDV.Text.Length);

        }

        private void numKDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(','))
            {
                e.KeyChar = ((System.Globalization.CultureInfo)System.Globalization.CultureInfo.CurrentCulture).NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }

        private void numProfitRate_Enter(object sender, EventArgs e)
        {
            numProfitRate.Select(0, numProfitRate.Text.Length);
        }

        private void numProfitRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(','))
            {
                e.KeyChar = ((System.Globalization.CultureInfo)System.Globalization.CultureInfo.CurrentCulture).NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {            
            calculateProductsValues(this.pUpdate);

            string DocumentsAndSettingsPath = PCDocumentAndSettingsPath.DocumentsAndSettingsPath;
            string filePath = PCDocumentAndSettingsPath.filePath;
            string fileExt = string.Empty;
           
            try{
                OleDbConnection MyConnection;
                OleDbCommand myCommand = new OleDbCommand();
                string sql = null;
                MyConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=Excel 8.0;");
                MyConnection.Open();

                myCommand.Connection = MyConnection;

                sql = "update [Sayfa1$] set " +
                    "Urun_Adi = '"+txtProductName.Text+"'," +
                    "Alis_Fiyati = '"+pUpdate.supplyingPrice+"'," +
                    " Trendyol_Komisyon_Orani = '"+pUpdate.trendyolComissionRate+"'," +
                    "Trendyol_Komisyon_Tutari = '"+ pUpdate.calculateTrendyolComisssionExpenseAmount() + "'," +
                    "KDV_Orani = '"+numKDV.Value+"'," +
                    "KDV_Tutari = '"+ pUpdate.calculateKDVExpenseAmount() + "'," +
                    "Kargo_Gideri = '"+this.pUpdate.cargoExpense+"'," +
                    "Kar_Orani = '"+pUpdate.profitRate+"'," +
                    "Kar_Tutari = '"+ pUpdate.calculateprofitAmount() + "'," +
                    "Toplam_Gider = '"+pUpdate.totalExpenseAmount+"'," +
                    "SATIS_FIYATI = '"+ pUpdate.calculateSellingPrice().ToString() + "'  where ID = '" + this.pUpdate.ID +"'";

                OleDbDataAdapter oleAdpt = new OleDbDataAdapter(sql, MyConnection);
                oleAdpt.UpdateCommand = MyConnection.CreateCommand();
                oleAdpt.UpdateCommand.CommandText = sql;
                oleAdpt.UpdateCommand.ExecuteNonQuery();
                MyConnection.Close();


                // reloads datagridview to refresh the table on datagridview
                FormCollection forms = Application.OpenForms;
                DataGridView dgv = (DataGridView)forms["CurrentExcelFile"].Controls["dataGridView1"];
                readExcel.LoadExcelFromPC(dgv);                    
                    
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        WebSocket ws;
        private void webSocketConnection()
        {
            // we use "using" scope to dispose it after using it
            ws = new WebSocket("ws://frozen-earth-60865.herokuapp.com");
            //ws = new WebSocket("ws://localhost:5000");
            ws.OnMessage += Ws_OnMessage;
            ws.OnOpen += Ws_OnOpen;       
            ws.Connect();
        }

        private void Ws_OnOpen(object sender, EventArgs e)
        {
            Product controlAnyProductOnServer = new Product();
            controlAnyProductOnServer.requestInfo = "connectingReq";
            string json = JsonSerializer.Serialize(controlAnyProductOnServer);
            ws.Send(json);
        }

        private void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false; // this is for "Cross-thread operation not valid" error           
          
            try
            {  // the code below deserializes the data comes from websocket server
                Product productFromWebsocket = new JavaScriptSerializer().Deserialize<Product>(e.Data);
                //insert new row (product) to excel file
                InsertNewRowToExcelFile ins = new InsertNewRowToExcelFile();
                ins.insertNewRow(productFromWebsocket);

                // gets data from websocket server, which were sent while PC was close
                Product controlAnyProductOnServer = new Product();
                controlAnyProductOnServer.requestInfo ="insertingReq";
                string json = JsonSerializer.Serialize(controlAnyProductOnServer);
                ws.Send(json);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //sends the app to system tray
        private void yenimar_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        //calls the application to back from system tray
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }
    }
}  