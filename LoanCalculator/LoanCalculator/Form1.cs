using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanCalculator
{
    public partial class Form1 : Form
    {
        double InterestRate, monthlyInterestRate, loanAmount, MonthlyPayment, TotalPayment;
        int numberOfYears;
        string cMonthlyPayment, cTotalPayment;

        //Calculate button
        private void button1_Click(object sender, EventArgs e)
        {
            InterestRate = Convert.ToDouble(txtInterestRate.Text);
            monthlyInterestRate = InterestRate / 1200;
            numberOfYears = Convert.ToInt32(txtNumberOfYears.Text);
            loanAmount = Convert.ToDouble(txtAmountOfLoan.Text);

            MonthlyPayment = loanAmount * monthlyInterestRate / (1 - 1 / Math.Pow(1 + monthlyInterestRate, numberOfYears * 12));
            cMonthlyPayment = Convert.ToString(MonthlyPayment);
            cMonthlyPayment = string.Format("{0:c}", MonthlyPayment);
            jdMonthlyPayment.Text = (cMonthlyPayment);

            TotalPayment = MonthlyPayment * numberOfYears * 12;
            cTotalPayment = string.Format("{0:c}", TotalPayment);
            jdTotalPayment.Text = (cTotalPayment);

            txtAmountOfLoan.Text = string.Format("{0:c}", loanAmount);
        }

        //Print Receipt button
        private void button2_Click(object sender, EventArgs e)
        {
            printReceipt.AppendText("Loan Calculator" + "\n");
            printReceipt.AppendText("-----------------------" + "\n");
            printReceipt.AppendText("Enter amount of Loan" + "\t" + txtAmountOfLoan.Text + "\n");
            printReceipt.AppendText("Enter Number of Years" + "\t" + txtNumberOfYears.Text + "\n");
            printReceipt.AppendText("Enter Interest Rate" + "\t" + "\t" + txtInterestRate.Text + "\n");
            printReceipt.AppendText("Monthly Payment" + "\t" + "\t" + jdMonthlyPayment.Text + "\n");
            printReceipt.AppendText("Total Payment" + "\t" + "\t" + jdTotalPayment.Text);
        }

        //Clear data button
        private void button3_Click(object sender, EventArgs e)
        {
            txtAmountOfLoan.Clear();
            txtInterestRate.Clear();
            txtNumberOfYears.Clear();
            jdMonthlyPayment.Text = "";
            jdTotalPayment.Text = "";
            printReceipt.Clear();
        }

        //Exit Program button
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult cExit;
            cExit = MessageBox.Show("Are you sure you want to exit?", "Loan Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Date and Clock labels
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label7.Text = DateTime.Now.ToLongTimeString();

            label8.Text = DateTime.Now.ToLongDateString();
        }

        //Seconds counter for clock
        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        public Form1()
        {
            InitializeComponent();
        }

    }
}
