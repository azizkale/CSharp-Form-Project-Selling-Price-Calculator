namespace TrenYolPriceCalculating
{
    partial class yenimar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSatisFiyatiLabel = new System.Windows.Forms.Label();
            this.lblSellingPriceAmount = new System.Windows.Forms.Label();
            this.bynCalculate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numSupplyingPrice = new System.Windows.Forms.NumericUpDown();
            this.numCargoExpense = new System.Windows.Forms.NumericUpDown();
            this.numKDV = new System.Windows.Forms.NumericUpDown();
            this.numProfitRate = new System.Windows.Forms.NumericUpDown();
            this.numTrenyolComission = new System.Windows.Forms.NumericUpDown();
            this.lblTrenyolComissionAmount = new System.Windows.Forms.Label();
            this.lblCargoExpenseAmount = new System.Windows.Forms.Label();
            this.lblKDVAmount = new System.Windows.Forms.Label();
            this.lblProfitAmount = new System.Windows.Forms.Label();
            this.btnCreateExcell = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSupplyingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCargoExpense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProfitRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrenyolComission)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(271, 48);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(267, 48);
            this.txtProductName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alış Fiyatı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trendyol Komisyon Oranı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(11, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trendyol Fiyat Hesaplama Programı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kargo Ücreti:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "KDV:";
            // 
            // lblSatisFiyatiLabel
            // 
            this.lblSatisFiyatiLabel.AutoSize = true;
            this.lblSatisFiyatiLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatisFiyatiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSatisFiyatiLabel.Location = new System.Drawing.Point(8, 423);
            this.lblSatisFiyatiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSatisFiyatiLabel.Name = "lblSatisFiyatiLabel";
            this.lblSatisFiyatiLabel.Size = new System.Drawing.Size(121, 20);
            this.lblSatisFiyatiLabel.TabIndex = 2;
            this.lblSatisFiyatiLabel.Text = "Satış Fiyatı:";
            this.lblSatisFiyatiLabel.Visible = false;
            // 
            // lblSellingPriceAmount
            // 
            this.lblSellingPriceAmount.AutoSize = true;
            this.lblSellingPriceAmount.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellingPriceAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSellingPriceAmount.Location = new System.Drawing.Point(221, 414);
            this.lblSellingPriceAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSellingPriceAmount.Name = "lblSellingPriceAmount";
            this.lblSellingPriceAmount.Size = new System.Drawing.Size(0, 29);
            this.lblSellingPriceAmount.TabIndex = 2;
            this.lblSellingPriceAmount.Visible = false;
            // 
            // bynCalculate
            // 
            this.bynCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bynCalculate.Location = new System.Drawing.Point(15, 335);
            this.bynCalculate.Name = "bynCalculate";
            this.bynCalculate.Size = new System.Drawing.Size(188, 58);
            this.bynCalculate.TabIndex = 7;
            this.bynCalculate.Text = "HESAPLA";
            this.bynCalculate.UseVisualStyleBackColor = true;
            this.bynCalculate.Click += new System.EventHandler(this.bynCalculate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 269);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kar Oranı:";
            // 
            // numSupplyingPrice
            // 
            this.numSupplyingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSupplyingPrice.Location = new System.Drawing.Point(271, 109);
            this.numSupplyingPrice.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numSupplyingPrice.Name = "numSupplyingPrice";
            this.numSupplyingPrice.Size = new System.Drawing.Size(144, 26);
            this.numSupplyingPrice.TabIndex = 2;
            this.numSupplyingPrice.Enter += new System.EventHandler(this.numSupplyingPrice_Enter);
            // 
            // numCargoExpense
            // 
            this.numCargoExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCargoExpense.Location = new System.Drawing.Point(271, 185);
            this.numCargoExpense.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numCargoExpense.Name = "numCargoExpense";
            this.numCargoExpense.Size = new System.Drawing.Size(144, 26);
            this.numCargoExpense.TabIndex = 4;
            this.numCargoExpense.Enter += new System.EventHandler(this.numCargoExpense_Enter);
            // 
            // numKDV
            // 
            this.numKDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numKDV.Location = new System.Drawing.Point(271, 225);
            this.numKDV.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numKDV.Name = "numKDV";
            this.numKDV.Size = new System.Drawing.Size(144, 26);
            this.numKDV.TabIndex = 5;
            this.numKDV.Enter += new System.EventHandler(this.numKDV_Enter);
            // 
            // numProfitRate
            // 
            this.numProfitRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numProfitRate.Location = new System.Drawing.Point(271, 263);
            this.numProfitRate.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numProfitRate.Name = "numProfitRate";
            this.numProfitRate.Size = new System.Drawing.Size(144, 26);
            this.numProfitRate.TabIndex = 6;
            this.numProfitRate.Enter += new System.EventHandler(this.numProfitRate_Enter);
            // 
            // numTrenyolComission
            // 
            this.numTrenyolComission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTrenyolComission.Location = new System.Drawing.Point(271, 146);
            this.numTrenyolComission.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numTrenyolComission.Name = "numTrenyolComission";
            this.numTrenyolComission.Size = new System.Drawing.Size(144, 26);
            this.numTrenyolComission.TabIndex = 3;
            this.numTrenyolComission.Enter += new System.EventHandler(this.numTrenyolComission_Enter);
            // 
            // lblTrenyolComissionAmount
            // 
            this.lblTrenyolComissionAmount.AutoSize = true;
            this.lblTrenyolComissionAmount.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrenyolComissionAmount.Location = new System.Drawing.Point(427, 148);
            this.lblTrenyolComissionAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrenyolComissionAmount.Name = "lblTrenyolComissionAmount";
            this.lblTrenyolComissionAmount.Size = new System.Drawing.Size(0, 20);
            this.lblTrenyolComissionAmount.TabIndex = 2;
            // 
            // lblCargoExpenseAmount
            // 
            this.lblCargoExpenseAmount.AutoSize = true;
            this.lblCargoExpenseAmount.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoExpenseAmount.Location = new System.Drawing.Point(427, 191);
            this.lblCargoExpenseAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargoExpenseAmount.Name = "lblCargoExpenseAmount";
            this.lblCargoExpenseAmount.Size = new System.Drawing.Size(0, 20);
            this.lblCargoExpenseAmount.TabIndex = 2;
            // 
            // lblKDVAmount
            // 
            this.lblKDVAmount.AutoSize = true;
            this.lblKDVAmount.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKDVAmount.Location = new System.Drawing.Point(427, 231);
            this.lblKDVAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKDVAmount.Name = "lblKDVAmount";
            this.lblKDVAmount.Size = new System.Drawing.Size(0, 20);
            this.lblKDVAmount.TabIndex = 2;
            // 
            // lblProfitAmount
            // 
            this.lblProfitAmount.AutoSize = true;
            this.lblProfitAmount.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfitAmount.Location = new System.Drawing.Point(427, 269);
            this.lblProfitAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfitAmount.Name = "lblProfitAmount";
            this.lblProfitAmount.Size = new System.Drawing.Size(0, 20);
            this.lblProfitAmount.TabIndex = 2;
            // 
            // btnCreateExcell
            // 
            this.btnCreateExcell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateExcell.Location = new System.Drawing.Point(227, 335);
            this.btnCreateExcell.Name = "btnCreateExcell";
            this.btnCreateExcell.Size = new System.Drawing.Size(188, 58);
            this.btnCreateExcell.TabIndex = 8;
            this.btnCreateExcell.Text = "Excell Dosyası Oluştur";
            this.btnCreateExcell.UseVisualStyleBackColor = true;
            this.btnCreateExcell.Click += new System.EventHandler(this.btnCreateExcell_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yenimar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numProfitRate);
            this.Controls.Add(this.numKDV);
            this.Controls.Add(this.numTrenyolComission);
            this.Controls.Add(this.numCargoExpense);
            this.Controls.Add(this.numSupplyingPrice);
            this.Controls.Add(this.btnCreateExcell);
            this.Controls.Add(this.bynCalculate);
            this.Controls.Add(this.lblSellingPriceAmount);
            this.Controls.Add(this.lblSatisFiyatiLabel);
            this.Controls.Add(this.lblProfitAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblKDVAmount);
            this.Controls.Add(this.lblCargoExpenseAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTrenyolComissionAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "yenimar";
            this.Text = "YENİMAR";
            ((System.ComponentModel.ISupportInitialize)(this.numSupplyingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCargoExpense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProfitRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrenyolComission)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSatisFiyatiLabel;
        private System.Windows.Forms.Label lblSellingPriceAmount;
        private System.Windows.Forms.Button bynCalculate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numSupplyingPrice;
        private System.Windows.Forms.NumericUpDown numCargoExpense;
        private System.Windows.Forms.NumericUpDown numKDV;
        private System.Windows.Forms.NumericUpDown numProfitRate;
        private System.Windows.Forms.NumericUpDown numTrenyolComission;
        private System.Windows.Forms.Label lblTrenyolComissionAmount;
        private System.Windows.Forms.Label lblCargoExpenseAmount;
        private System.Windows.Forms.Label lblKDVAmount;
        private System.Windows.Forms.Label lblProfitAmount;
        private System.Windows.Forms.Button btnCreateExcell;
        private System.Windows.Forms.Button button1;
    }
}

