﻿namespace LoanCalculator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.jdMonthlyPayment = new System.Windows.Forms.Label();
            this.txtAmountOfLoan = new System.Windows.Forms.TextBox();
            this.txtNumberOfYears = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.jdTotalPayment = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.printReceipt = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(96, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(447, 458);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(617, 458);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 38);
            this.button4.TabIndex = 3;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Loan Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Number of Years";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Interest Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monthly Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Payment";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(190, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 76);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(322, 36);
            this.label6.TabIndex = 10;
            this.label6.Text = "LOAN CALCULATOR";
            // 
            // jdMonthlyPayment
            // 
            this.jdMonthlyPayment.BackColor = System.Drawing.SystemColors.ControlDark;
            this.jdMonthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.jdMonthlyPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jdMonthlyPayment.Location = new System.Drawing.Point(335, 308);
            this.jdMonthlyPayment.Name = "jdMonthlyPayment";
            this.jdMonthlyPayment.Size = new System.Drawing.Size(224, 45);
            this.jdMonthlyPayment.TabIndex = 10;
            // 
            // txtAmountOfLoan
            // 
            this.txtAmountOfLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountOfLoan.Location = new System.Drawing.Point(335, 113);
            this.txtAmountOfLoan.Name = "txtAmountOfLoan";
            this.txtAmountOfLoan.Size = new System.Drawing.Size(224, 27);
            this.txtAmountOfLoan.TabIndex = 11;
            // 
            // txtNumberOfYears
            // 
            this.txtNumberOfYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfYears.Location = new System.Drawing.Point(335, 174);
            this.txtNumberOfYears.Name = "txtNumberOfYears";
            this.txtNumberOfYears.Size = new System.Drawing.Size(224, 27);
            this.txtNumberOfYears.TabIndex = 12;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterestRate.Location = new System.Drawing.Point(335, 242);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(224, 27);
            this.txtInterestRate.TabIndex = 13;
            // 
            // jdTotalPayment
            // 
            this.jdTotalPayment.BackColor = System.Drawing.SystemColors.ControlDark;
            this.jdTotalPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.jdTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jdTotalPayment.Location = new System.Drawing.Point(335, 370);
            this.jdTotalPayment.Name = "jdTotalPayment";
            this.jdTotalPayment.Size = new System.Drawing.Size(224, 45);
            this.jdTotalPayment.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(280, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Print Receipt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printReceipt
            // 
            this.printReceipt.Location = new System.Drawing.Point(696, 120);
            this.printReceipt.Name = "printReceipt";
            this.printReceipt.Size = new System.Drawing.Size(351, 295);
            this.printReceipt.TabIndex = 15;
            this.printReceipt.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(879, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(879, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 508);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.printReceipt);
            this.Controls.Add(this.jdTotalPayment);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtNumberOfYears);
            this.Controls.Add(this.txtAmountOfLoan);
            this.Controls.Add(this.jdMonthlyPayment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label jdMonthlyPayment;
        private System.Windows.Forms.TextBox txtAmountOfLoan;
        private System.Windows.Forms.TextBox txtNumberOfYears;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label jdTotalPayment;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox printReceipt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
    }
}

