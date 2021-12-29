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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.yeniDosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dosyayıAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numSupplyingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCargoExpense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProfitRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrenyolComission)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(406, 47);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(398, 72);
            this.txtProductName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alış Fiyatı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trendyol Komisyon Oranı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kargo Ücreti:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "KDV:";
            // 
            // lblSatisFiyatiLabel
            // 
            this.lblSatisFiyatiLabel.AutoSize = true;
            this.lblSatisFiyatiLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatisFiyatiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSatisFiyatiLabel.Location = new System.Drawing.Point(13, 544);
            this.lblSatisFiyatiLabel.Name = "lblSatisFiyatiLabel";
            this.lblSatisFiyatiLabel.Size = new System.Drawing.Size(232, 42);
            this.lblSatisFiyatiLabel.TabIndex = 2;
            this.lblSatisFiyatiLabel.Text = "Satış Fiyatı:";
            // 
            // lblSellingPriceAmount
            // 
            this.lblSellingPriceAmount.AutoSize = true;
            this.lblSellingPriceAmount.Font = new System.Drawing.Font("NSimSun", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellingPriceAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSellingPriceAmount.Location = new System.Drawing.Point(285, 540);
            this.lblSellingPriceAmount.Name = "lblSellingPriceAmount";
            this.lblSellingPriceAmount.Size = new System.Drawing.Size(44, 46);
            this.lblSellingPriceAmount.TabIndex = 2;
            this.lblSellingPriceAmount.Text = "0";
            // 
            // bynCalculate
            // 
            this.bynCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bynCalculate.Location = new System.Drawing.Point(98, 461);
            this.bynCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bynCalculate.Name = "bynCalculate";
            this.bynCalculate.Size = new System.Drawing.Size(622, 55);
            this.bynCalculate.TabIndex = 7;
            this.bynCalculate.Text = "HESAPLA";
            this.bynCalculate.UseVisualStyleBackColor = true;
            this.bynCalculate.Click += new System.EventHandler(this.bynCalculate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kar Oranı:";
            // 
            // numSupplyingPrice
            // 
            this.numSupplyingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSupplyingPrice.Location = new System.Drawing.Point(406, 141);
            this.numSupplyingPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numSupplyingPrice.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numSupplyingPrice.Name = "numSupplyingPrice";
            this.numSupplyingPrice.Size = new System.Drawing.Size(216, 35);
            this.numSupplyingPrice.TabIndex = 2;
            this.numSupplyingPrice.Enter += new System.EventHandler(this.numSupplyingPrice_Enter);
            // 
            // numCargoExpense
            // 
            this.numCargoExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCargoExpense.Location = new System.Drawing.Point(406, 258);
            this.numCargoExpense.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numCargoExpense.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numCargoExpense.Name = "numCargoExpense";
            this.numCargoExpense.Size = new System.Drawing.Size(216, 35);
            this.numCargoExpense.TabIndex = 4;
            this.numCargoExpense.Enter += new System.EventHandler(this.numCargoExpense_Enter);
            // 
            // numKDV
            // 
            this.numKDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numKDV.Location = new System.Drawing.Point(406, 319);
            this.numKDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numKDV.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numKDV.Name = "numKDV";
            this.numKDV.Size = new System.Drawing.Size(216, 35);
            this.numKDV.TabIndex = 5;
            this.numKDV.Enter += new System.EventHandler(this.numKDV_Enter);
            // 
            // numProfitRate
            // 
            this.numProfitRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numProfitRate.Location = new System.Drawing.Point(406, 378);
            this.numProfitRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numProfitRate.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numProfitRate.Name = "numProfitRate";
            this.numProfitRate.Size = new System.Drawing.Size(216, 35);
            this.numProfitRate.TabIndex = 6;
            this.numProfitRate.Enter += new System.EventHandler(this.numProfitRate_Enter);
            // 
            // numTrenyolComission
            // 
            this.numTrenyolComission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTrenyolComission.Location = new System.Drawing.Point(406, 198);
            this.numTrenyolComission.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numTrenyolComission.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numTrenyolComission.Name = "numTrenyolComission";
            this.numTrenyolComission.Size = new System.Drawing.Size(216, 35);
            this.numTrenyolComission.TabIndex = 3;
            this.numTrenyolComission.Enter += new System.EventHandler(this.numTrenyolComission_Enter);
            // 
            // lblTrenyolComissionAmount
            // 
            this.lblTrenyolComissionAmount.AutoSize = true;
            this.lblTrenyolComissionAmount.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrenyolComissionAmount.Location = new System.Drawing.Point(640, 201);
            this.lblTrenyolComissionAmount.Name = "lblTrenyolComissionAmount";
            this.lblTrenyolComissionAmount.Size = new System.Drawing.Size(0, 29);
            this.lblTrenyolComissionAmount.TabIndex = 2;
            // 
            // lblCargoExpenseAmount
            // 
            this.lblCargoExpenseAmount.AutoSize = true;
            this.lblCargoExpenseAmount.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoExpenseAmount.Location = new System.Drawing.Point(640, 267);
            this.lblCargoExpenseAmount.Name = "lblCargoExpenseAmount";
            this.lblCargoExpenseAmount.Size = new System.Drawing.Size(0, 29);
            this.lblCargoExpenseAmount.TabIndex = 2;
            // 
            // lblKDVAmount
            // 
            this.lblKDVAmount.AutoSize = true;
            this.lblKDVAmount.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKDVAmount.Location = new System.Drawing.Point(640, 328);
            this.lblKDVAmount.Name = "lblKDVAmount";
            this.lblKDVAmount.Size = new System.Drawing.Size(0, 29);
            this.lblKDVAmount.TabIndex = 2;
            // 
            // lblProfitAmount
            // 
            this.lblProfitAmount.AutoSize = true;
            this.lblProfitAmount.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfitAmount.Location = new System.Drawing.Point(640, 387);
            this.lblProfitAmount.Name = "lblProfitAmount";
            this.lblProfitAmount.Size = new System.Drawing.Size(0, 29);
            this.lblProfitAmount.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.formİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.yeniDosyaToolStripMenuItem,
            this.toolStripSeparator2,
            this.dosyayıAçToolStripMenuItem,
            this.toolStripSeparator3,
            this.ürünEkleToolStripMenuItem,
            this.toolStripSeparator4,
            this.çıkışToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 29);
            this.toolStripMenuItem1.Text = "&Dosya İşlemleri";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(249, 6);
            // 
            // yeniDosyaToolStripMenuItem
            // 
            this.yeniDosyaToolStripMenuItem.Name = "yeniDosyaToolStripMenuItem";
            this.yeniDosyaToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.yeniDosyaToolStripMenuItem.Text = "Yeni Dosya";
            this.yeniDosyaToolStripMenuItem.Click += new System.EventHandler(this.yeniDosyaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(249, 6);
            // 
            // dosyayıAçToolStripMenuItem
            // 
            this.dosyayıAçToolStripMenuItem.Name = "dosyayıAçToolStripMenuItem";
            this.dosyayıAçToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.dosyayıAçToolStripMenuItem.Text = "Dosyayı Aç";
            this.dosyayıAçToolStripMenuItem.Click += new System.EventHandler(this.dosyayıAçToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(249, 6);
            // 
            // ürünEkleToolStripMenuItem
            // 
            this.ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            this.ürünEkleToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.ürünEkleToolStripMenuItem.Text = "Ürün Ekle";
            this.ürünEkleToolStripMenuItem.Click += new System.EventHandler(this.ürünEkleToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(249, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // formİşlemleriToolStripMenuItem
            // 
            this.formİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.temizleToolStripMenuItem});
            this.formİşlemleriToolStripMenuItem.Name = "formİşlemleriToolStripMenuItem";
            this.formİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(136, 29);
            this.formİşlemleriToolStripMenuItem.Text = "Form İşlemleri";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(249, 6);
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.temizleToolStripMenuItem.Text = "Temizle";
            this.temizleToolStripMenuItem.Click += new System.EventHandler(this.temizleToolStripMenuItem_Click);
            // 
            // yenimar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 614);
            this.Controls.Add(this.numProfitRate);
            this.Controls.Add(this.numKDV);
            this.Controls.Add(this.numTrenyolComission);
            this.Controls.Add(this.numCargoExpense);
            this.Controls.Add(this.numSupplyingPrice);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(841, 670);
            this.MinimumSize = new System.Drawing.Size(841, 670);
            this.Name = "yenimar";
            this.Text = "YENİMAR";
            ((System.ComponentModel.ISupportInitialize)(this.numSupplyingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCargoExpense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProfitRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrenyolComission)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem yeniDosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem dosyayıAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ürünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
    }
}

