namespace MyBank1
{
    partial class Mortage
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.amountLoanTextBox = new System.Windows.Forms.TextBox();
            this.annualInterestTextBox = new System.Windows.Forms.TextBox();
            this.numberYearsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.monthlyPaymentLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalLoansLabel = new System.Windows.Forms.Label();
            this.totalMonthlyPaymentsLabel = new System.Windows.Forms.Label();
            this.averageMonthlyPaymentsLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount of Loan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount of Annual Interest:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Years:";
            // 
            // amountLoanTextBox
            // 
            this.amountLoanTextBox.Location = new System.Drawing.Point(177, 35);
            this.amountLoanTextBox.Name = "amountLoanTextBox";
            this.amountLoanTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountLoanTextBox.TabIndex = 3;
            // 
            // annualInterestTextBox
            // 
            this.annualInterestTextBox.Location = new System.Drawing.Point(177, 72);
            this.annualInterestTextBox.Name = "annualInterestTextBox";
            this.annualInterestTextBox.Size = new System.Drawing.Size(100, 20);
            this.annualInterestTextBox.TabIndex = 4;
            // 
            // numberYearsTextBox
            // 
            this.numberYearsTextBox.Location = new System.Drawing.Point(177, 108);
            this.numberYearsTextBox.Name = "numberYearsTextBox";
            this.numberYearsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberYearsTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Monthly Payment:";
            // 
            // monthlyPaymentLabel
            // 
            this.monthlyPaymentLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.monthlyPaymentLabel.Location = new System.Drawing.Point(177, 145);
            this.monthlyPaymentLabel.Name = "monthlyPaymentLabel";
            this.monthlyPaymentLabel.Size = new System.Drawing.Size(100, 23);
            this.monthlyPaymentLabel.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.averageMonthlyPaymentsLabel);
            this.groupBox1.Controls.Add(this.totalMonthlyPaymentsLabel);
            this.groupBox1.Controls.Add(this.totalLoansLabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(35, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 161);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total of All Loans:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total of Monthly Payments:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Average Monthly Payment:";
            // 
            // totalLoansLabel
            // 
            this.totalLoansLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalLoansLabel.Location = new System.Drawing.Point(187, 35);
            this.totalLoansLabel.Name = "totalLoansLabel";
            this.totalLoansLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLoansLabel.TabIndex = 3;
            // 
            // totalMonthlyPaymentsLabel
            // 
            this.totalMonthlyPaymentsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalMonthlyPaymentsLabel.Location = new System.Drawing.Point(187, 73);
            this.totalMonthlyPaymentsLabel.Name = "totalMonthlyPaymentsLabel";
            this.totalMonthlyPaymentsLabel.Size = new System.Drawing.Size(100, 23);
            this.totalMonthlyPaymentsLabel.TabIndex = 4;
            // 
            // averageMonthlyPaymentsLabel
            // 
            this.averageMonthlyPaymentsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.averageMonthlyPaymentsLabel.Location = new System.Drawing.Point(187, 109);
            this.averageMonthlyPaymentsLabel.Name = "averageMonthlyPaymentsLabel";
            this.averageMonthlyPaymentsLabel.Size = new System.Drawing.Size(100, 23);
            this.averageMonthlyPaymentsLabel.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(59, 405);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(177, 405);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(299, 405);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Mortage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 455);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthlyPaymentLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numberYearsTextBox);
            this.Controls.Add(this.annualInterestTextBox);
            this.Controls.Add(this.amountLoanTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mortage";
            this.Text = "Mortage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amountLoanTextBox;
        private System.Windows.Forms.TextBox annualInterestTextBox;
        private System.Windows.Forms.TextBox numberYearsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label monthlyPaymentLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label averageMonthlyPaymentsLabel;
        private System.Windows.Forms.Label totalMonthlyPaymentsLabel;
        private System.Windows.Forms.Label totalLoansLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}