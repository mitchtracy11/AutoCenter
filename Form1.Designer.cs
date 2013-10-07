namespace AutoCenter
{
    partial class AutoCenter
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddIteam = new System.Windows.Forms.GroupBox();
            this.Stereo = new System.Windows.Forms.CheckBox();
            this.LeatherInt = new System.Windows.Forms.CheckBox();
            this.CompNav = new System.Windows.Forms.CheckBox();
            this.ExFin = new System.Windows.Forms.GroupBox();
            this.StanFin = new System.Windows.Forms.RadioButton();
            this.PearlFin = new System.Windows.Forms.RadioButton();
            this.CustDet = new System.Windows.Forms.RadioButton();
            this.BasePriceTextBox = new System.Windows.Forms.TextBox();
            this.AddOptTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.TradeTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.BasePrice = new System.Windows.Forms.Label();
            this.AddOpt = new System.Windows.Forms.Label();
            this.SubTotal = new System.Windows.Forms.Label();
            this.SalesTax = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Trade = new System.Windows.Forms.Label();
            this.AmountDue = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.AddIteam.SuspendLayout();
            this.ExFin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // AddIteam
            // 
            this.AddIteam.Controls.Add(this.CompNav);
            this.AddIteam.Controls.Add(this.LeatherInt);
            this.AddIteam.Controls.Add(this.Stereo);
            this.AddIteam.Location = new System.Drawing.Point(12, 46);
            this.AddIteam.Name = "AddIteam";
            this.AddIteam.Size = new System.Drawing.Size(149, 90);
            this.AddIteam.TabIndex = 1;
            this.AddIteam.TabStop = false;
            this.AddIteam.Text = "Additional Items";
            this.AddIteam.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Stereo
            // 
            this.Stereo.AutoSize = true;
            this.Stereo.Location = new System.Drawing.Point(3, 16);
            this.Stereo.Name = "Stereo";
            this.Stereo.Size = new System.Drawing.Size(94, 17);
            this.Stereo.TabIndex = 0;
            this.Stereo.Text = "Stereo System";
            this.Stereo.UseVisualStyleBackColor = true;
            // 
            // LeatherInt
            // 
            this.LeatherInt.AutoSize = true;
            this.LeatherInt.Location = new System.Drawing.Point(3, 39);
            this.LeatherInt.Name = "LeatherInt";
            this.LeatherInt.Size = new System.Drawing.Size(97, 17);
            this.LeatherInt.TabIndex = 2;
            this.LeatherInt.Text = "Leather Interior";
            this.LeatherInt.UseVisualStyleBackColor = true;
            // 
            // CompNav
            // 
            this.CompNav.AutoSize = true;
            this.CompNav.Location = new System.Drawing.Point(3, 61);
            this.CompNav.Name = "CompNav";
            this.CompNav.Size = new System.Drawing.Size(125, 17);
            this.CompNav.TabIndex = 2;
            this.CompNav.Text = "Computer Navigation";
            this.CompNav.UseVisualStyleBackColor = true;
            // 
            // ExFin
            // 
            this.ExFin.Controls.Add(this.CustDet);
            this.ExFin.Controls.Add(this.PearlFin);
            this.ExFin.Controls.Add(this.StanFin);
            this.ExFin.Location = new System.Drawing.Point(12, 142);
            this.ExFin.Name = "ExFin";
            this.ExFin.Size = new System.Drawing.Size(149, 106);
            this.ExFin.TabIndex = 2;
            this.ExFin.TabStop = false;
            this.ExFin.Text = "Exterior Finish";
            // 
            // StanFin
            // 
            this.StanFin.AutoSize = true;
            this.StanFin.Location = new System.Drawing.Point(7, 20);
            this.StanFin.Name = "StanFin";
            this.StanFin.Size = new System.Drawing.Size(98, 17);
            this.StanFin.TabIndex = 0;
            this.StanFin.TabStop = true;
            this.StanFin.Text = "Standard Finish";
            this.StanFin.UseVisualStyleBackColor = true;
            this.StanFin.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // PearlFin
            // 
            this.PearlFin.AutoSize = true;
            this.PearlFin.Location = new System.Drawing.Point(7, 44);
            this.PearlFin.Name = "PearlFin";
            this.PearlFin.Size = new System.Drawing.Size(98, 17);
            this.PearlFin.TabIndex = 1;
            this.PearlFin.TabStop = true;
            this.PearlFin.Text = "Pearlized Finish";
            this.PearlFin.UseVisualStyleBackColor = true;
            // 
            // CustDet
            // 
            this.CustDet.AutoSize = true;
            this.CustDet.Location = new System.Drawing.Point(7, 68);
            this.CustDet.Name = "CustDet";
            this.CustDet.Size = new System.Drawing.Size(104, 17);
            this.CustDet.TabIndex = 2;
            this.CustDet.TabStop = true;
            this.CustDet.Text = "Custom Detailing";
            this.CustDet.UseVisualStyleBackColor = true;
            this.CustDet.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // BasePriceTextBox
            // 
            this.BasePriceTextBox.Location = new System.Drawing.Point(302, 46);
            this.BasePriceTextBox.Name = "BasePriceTextBox";
            this.BasePriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.BasePriceTextBox.TabIndex = 3;
            // 
            // AddOptTextBox
            // 
            this.AddOptTextBox.Location = new System.Drawing.Point(302, 72);
            this.AddOptTextBox.Name = "AddOptTextBox";
            this.AddOptTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddOptTextBox.TabIndex = 4;
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(301, 99);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.SubTotalTextBox.TabIndex = 5;
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(302, 127);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalesTaxTextBox.TabIndex = 6;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(302, 153);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 7;
            // 
            // TradeTextBox
            // 
            this.TradeTextBox.Location = new System.Drawing.Point(302, 179);
            this.TradeTextBox.Name = "TradeTextBox";
            this.TradeTextBox.Size = new System.Drawing.Size(100, 20);
            this.TradeTextBox.TabIndex = 8;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(302, 209);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.AmountTextBox.TabIndex = 9;
            // 
            // BasePrice
            // 
            this.BasePrice.AutoSize = true;
            this.BasePrice.Location = new System.Drawing.Point(214, 49);
            this.BasePrice.Name = "BasePrice";
            this.BasePrice.Size = new System.Drawing.Size(64, 13);
            this.BasePrice.TabIndex = 10;
            this.BasePrice.Text = "Base Price :";
            // 
            // AddOpt
            // 
            this.AddOpt.AutoSize = true;
            this.AddOpt.Location = new System.Drawing.Point(180, 75);
            this.AddOpt.Name = "AddOpt";
            this.AddOpt.Size = new System.Drawing.Size(98, 13);
            this.AddOpt.TabIndex = 11;
            this.AddOpt.Text = "Additional Options :";
            this.AddOpt.Click += new System.EventHandler(this.AddOpt_Click);
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSize = true;
            this.SubTotal.Location = new System.Drawing.Point(219, 102);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(59, 13);
            this.SubTotal.TabIndex = 12;
            this.SubTotal.Text = "Sub Total :";
            // 
            // SalesTax
            // 
            this.SalesTax.AutoSize = true;
            this.SalesTax.Location = new System.Drawing.Point(218, 130);
            this.SalesTax.Name = "SalesTax";
            this.SalesTax.Size = new System.Drawing.Size(60, 13);
            this.SalesTax.TabIndex = 13;
            this.SalesTax.Text = "Sales Tax :";
            this.SalesTax.Click += new System.EventHandler(this.label4_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(241, 156);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(37, 13);
            this.Total.TabIndex = 14;
            this.Total.Text = "Total :";
            this.Total.Click += new System.EventHandler(this.label5_Click);
            // 
            // Trade
            // 
            this.Trade.AutoSize = true;
            this.Trade.Location = new System.Drawing.Point(173, 182);
            this.Trade.Name = "Trade";
            this.Trade.Size = new System.Drawing.Size(105, 13);
            this.Trade.TabIndex = 15;
            this.Trade.Text = "Trade In Allowance :";
            // 
            // AmountDue
            // 
            this.AmountDue.AutoSize = true;
            this.AmountDue.Location = new System.Drawing.Point(206, 212);
            this.AmountDue.Name = "AmountDue";
            this.AmountDue.Size = new System.Drawing.Size(72, 13);
            this.AmountDue.TabIndex = 16;
            this.AmountDue.Text = "Amount Due :";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(42, 261);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(221, 261);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 18;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(403, 260);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 19;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // AutoCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 296);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.AmountDue);
            this.Controls.Add(this.Trade);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.SalesTax);
            this.Controls.Add(this.SubTotal);
            this.Controls.Add(this.AddOpt);
            this.Controls.Add(this.BasePrice);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.TradeTextBox);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.SalesTaxTextBox);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.AddOptTextBox);
            this.Controls.Add(this.BasePriceTextBox);
            this.Controls.Add(this.ExFin);
            this.Controls.Add(this.AddIteam);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AutoCenter";
            this.Text = "AutoCenter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AddIteam.ResumeLayout(false);
            this.AddIteam.PerformLayout();
            this.ExFin.ResumeLayout(false);
            this.ExFin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox AddIteam;
        private System.Windows.Forms.CheckBox CompNav;
        private System.Windows.Forms.CheckBox LeatherInt;
        private System.Windows.Forms.CheckBox Stereo;
        private System.Windows.Forms.GroupBox ExFin;
        private System.Windows.Forms.RadioButton StanFin;
        private System.Windows.Forms.RadioButton CustDet;
        private System.Windows.Forms.RadioButton PearlFin;
        private System.Windows.Forms.TextBox BasePriceTextBox;
        private System.Windows.Forms.TextBox AddOptTextBox;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox TradeTextBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label BasePrice;
        private System.Windows.Forms.Label AddOpt;
        private System.Windows.Forms.Label SubTotal;
        private System.Windows.Forms.Label SalesTax;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Trade;
        private System.Windows.Forms.Label AmountDue;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Exit;
    }
}

