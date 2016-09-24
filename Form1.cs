using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enhanced_invoice_form_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        int numberOfInvoices = 0;
        decimal totalOfInvoices = 0m;
        decimal invoiceAverage = 0m;

        private void btnCalulate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(txtEnterSubtotal.Text);
            decimal discountPercent = 0m;
            if (subtotal >= 500)
            {
                discountPercent = .2m;
            }
            else if (subtotal >= 250 && subtotal < 500)
            {
                discountPercent = .15m;
                    }
            else if (subtotal >= 100 && subtotal < 250)
            {
                discountPercent = .1m;
            }

            decimal discountAmount = Math.Round(subtotal * discountPercent, 2);
            decimal invoiceTotal = subtotal - discountAmount;

            txtSubtotal.Text = subtotal.ToString("c");
            txtDiscountPercentage.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            numberOfInvoices++;
            totalOfInvoices += invoiceTotal;
            invoiceAverage = totalOfInvoices / numberOfInvoices;

            txtnumberOfInvoices.Text = numberOfInvoices.ToString();
            txttotalOfInvoices.Text = totalOfInvoices.ToString("c");
            txtinvoiceAverage.Text = invoiceAverage.ToString("c");
            txtEnterSubtotal.Text = "";
            txtEnterSubtotal.Focus();

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnClearTotals_Click(object sender, EventArgs e)
        {

            numberOfInvoices = 0;
            totalOfInvoices = 0m;
            invoiceAverage = 0m;

            txtnumberOfInvoices.Text = "";
            txttotalOfInvoices.Text = "";
            txtinvoiceAverage.Text = "";
            txtEnterSubtotal.Focus();
        }
    }
}
