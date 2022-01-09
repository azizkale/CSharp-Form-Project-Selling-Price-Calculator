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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yenimar));
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSatisFiyatiLabel = new System.Windows.Forms.Label();
            this.lblSellingPriceAmount = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
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
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.formİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProductUpdate = new System.Windows.Forms.Button();
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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtProductName
            // 
            resources.ApplyResources(this.txtProductName, "txtProductName");
            this.txtProductName.Name = "txtProductName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lblSatisFiyatiLabel
            // 
            resources.ApplyResources(this.lblSatisFiyatiLabel, "lblSatisFiyatiLabel");
            this.lblSatisFiyatiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSatisFiyatiLabel.Name = "lblSatisFiyatiLabel";
            // 
            // lblSellingPriceAmount
            // 
            resources.ApplyResources(this.lblSellingPriceAmount, "lblSellingPriceAmount");
            this.lblSellingPriceAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSellingPriceAmount.Name = "lblSellingPriceAmount";
            // 
            // btnCalculate
            // 
            resources.ApplyResources(this.btnCalculate, "btnCalculate");
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // numSupplyingPrice
            // 
            this.numSupplyingPrice.DecimalPlaces = 2;
            resources.ApplyResources(this.numSupplyingPrice, "numSupplyingPrice");
            this.numSupplyingPrice.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numSupplyingPrice.Name = "numSupplyingPrice";
            this.numSupplyingPrice.Enter += new System.EventHandler(this.numSupplyingPrice_Enter);
            this.numSupplyingPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numSupplyingPrice_KeyPress);
            // 
            // numCargoExpense
            // 
            this.numCargoExpense.DecimalPlaces = 2;
            resources.ApplyResources(this.numCargoExpense, "numCargoExpense");
            this.numCargoExpense.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numCargoExpense.Name = "numCargoExpense";
            this.numCargoExpense.Enter += new System.EventHandler(this.numCargoExpense_Enter);
            this.numCargoExpense.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numCargoExpense_KeyPress);
            // 
            // numKDV
            // 
            this.numKDV.DecimalPlaces = 2;
            resources.ApplyResources(this.numKDV, "numKDV");
            this.numKDV.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numKDV.Name = "numKDV";
            this.numKDV.Enter += new System.EventHandler(this.numKDV_Enter);
            this.numKDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numKDV_KeyPress);
            // 
            // numProfitRate
            // 
            this.numProfitRate.DecimalPlaces = 2;
            resources.ApplyResources(this.numProfitRate, "numProfitRate");
            this.numProfitRate.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numProfitRate.Name = "numProfitRate";
            this.numProfitRate.Enter += new System.EventHandler(this.numProfitRate_Enter);
            this.numProfitRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numProfitRate_KeyPress);
            // 
            // numTrenyolComission
            // 
            this.numTrenyolComission.DecimalPlaces = 2;
            resources.ApplyResources(this.numTrenyolComission, "numTrenyolComission");
            this.numTrenyolComission.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numTrenyolComission.Name = "numTrenyolComission";
            this.numTrenyolComission.Enter += new System.EventHandler(this.numTrenyolComission_Enter);
            this.numTrenyolComission.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numTrenyolComission_KeyPress);
            // 
            // lblTrenyolComissionAmount
            // 
            resources.ApplyResources(this.lblTrenyolComissionAmount, "lblTrenyolComissionAmount");
            this.lblTrenyolComissionAmount.Name = "lblTrenyolComissionAmount";
            // 
            // lblCargoExpenseAmount
            // 
            resources.ApplyResources(this.lblCargoExpenseAmount, "lblCargoExpenseAmount");
            this.lblCargoExpenseAmount.Name = "lblCargoExpenseAmount";
            // 
            // lblKDVAmount
            // 
            resources.ApplyResources(this.lblKDVAmount, "lblKDVAmount");
            this.lblKDVAmount.Name = "lblKDVAmount";
            // 
            // lblProfitAmount
            // 
            resources.ApplyResources(this.lblProfitAmount, "lblProfitAmount");
            this.lblProfitAmount.Name = "lblProfitAmount";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ürünlerToolStripMenuItem,
            this.formİşlemleriToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.yeniDosyaToolStripMenuItem,
            this.toolStripSeparator2,
            this.dosyayıAçToolStripMenuItem,
            this.toolStripSeparator4,
            this.çıkışToolStripMenuItem,
            this.toolStripSeparator8});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // yeniDosyaToolStripMenuItem
            // 
            this.yeniDosyaToolStripMenuItem.Name = "yeniDosyaToolStripMenuItem";
            resources.ApplyResources(this.yeniDosyaToolStripMenuItem, "yeniDosyaToolStripMenuItem");
            this.yeniDosyaToolStripMenuItem.Click += new System.EventHandler(this.yeniDosyaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // dosyayıAçToolStripMenuItem
            // 
            this.dosyayıAçToolStripMenuItem.Name = "dosyayıAçToolStripMenuItem";
            resources.ApplyResources(this.dosyayıAçToolStripMenuItem, "dosyayıAçToolStripMenuItem");
            this.dosyayıAçToolStripMenuItem.Click += new System.EventHandler(this.dosyayıAçToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            resources.ApplyResources(this.çıkışToolStripMenuItem, "çıkışToolStripMenuItem");
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator7,
            this.ürünEkleToolStripMenuItem,
            this.toolStripSeparator6});
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            resources.ApplyResources(this.ürünlerToolStripMenuItem, "ürünlerToolStripMenuItem");
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // ürünEkleToolStripMenuItem
            // 
            this.ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            resources.ApplyResources(this.ürünEkleToolStripMenuItem, "ürünEkleToolStripMenuItem");
            this.ürünEkleToolStripMenuItem.Click += new System.EventHandler(this.ürünEkleToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // formİşlemleriToolStripMenuItem
            // 
            this.formİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.temizleToolStripMenuItem,
            this.toolStripSeparator3});
            this.formİşlemleriToolStripMenuItem.Name = "formİşlemleriToolStripMenuItem";
            resources.ApplyResources(this.formİşlemleriToolStripMenuItem, "formİşlemleriToolStripMenuItem");
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            resources.ApplyResources(this.temizleToolStripMenuItem, "temizleToolStripMenuItem");
            this.temizleToolStripMenuItem.Click += new System.EventHandler(this.temizleToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // btnProductUpdate
            // 
            resources.ApplyResources(this.btnProductUpdate, "btnProductUpdate");
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // yenimar
            // 
            this.AcceptButton = this.btnCalculate;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnProductUpdate);
            this.Controls.Add(this.numProfitRate);
            this.Controls.Add(this.numKDV);
            this.Controls.Add(this.numTrenyolComission);
            this.Controls.Add(this.numCargoExpense);
            this.Controls.Add(this.numSupplyingPrice);
            this.Controls.Add(this.btnCalculate);
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
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "yenimar";
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
        private System.Windows.Forms.Button btnCalculate;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünEkleToolStripMenuItem;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

