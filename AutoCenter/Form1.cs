using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCenter
{
    public partial class AutoCenter : Form
    {
        // Declare  constants.
        const decimal TAX_RATE_Decimal = 0.13m;
        const decimal STANDARD_FINISH_Decimal = 0m;
        const decimal PEARLIZED_FINISH_Decimal = 400m;
        const decimal CUSTOM_DETAILING_Decimal = 800m;
        const int BASE_PRICE = 120000;
        public AutoCenter()
        {
            InitializeComponent();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddOpt_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
             //clears fields
            BasePriceTextBox.Clear();
            AddOptTextBox.Clear();
            SubTotalTextBox.Clear();
            SalesTaxTextBox.Clear();
            TotalTextBox.Clear();
            TradeTextBox.Clear();
            AmountTextBox.Clear();
        }//end the clear

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AutoCenter_Load(object sender, EventArgs e)
        {
           // MitchImage.Image = Properties.Resources.MitchLogo;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            // Terminate the Project
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Terminate the Project
            this.Close();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            decimal ExteriorPrice = 0;

            // Find the price.
            if (StanFinRadioButton.Checked)
            {
                ExteriorPrice = STANDARD_FINISH_Decimal;
            } // end if
            else if (PearlFin.Checked)
            {
                ExteriorPrice = PEARLIZED_FINISH_Decimal;
            } // end else if
            else if (CustDet.Checked)
            {
                ExteriorPrice = CUSTOM_DETAILING_Decimal;
            } // end else if
        }

        private void PearlFin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ExFin_Enter(object sender, EventArgs e)
        {

        }

        private void BasePriceTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set the text color to blue.

            this.ForeColor = Color.Blue;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set the text color to red.

            this.ForeColor = Color.Red;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set the text color to black.

            this.ForeColor = Color.Black;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set the text color to green.

            this.ForeColor = Color.Green;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Font = new Font("Arial", 14, FontStyle.Bold);
        }

        private void fontSizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Font = new Font("Arial", 24, FontStyle.Bold);
        }

        private void fontSizeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void fontSizeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Font = new Font("Arial", 8, FontStyle.Bold);
        }

       }
   }
