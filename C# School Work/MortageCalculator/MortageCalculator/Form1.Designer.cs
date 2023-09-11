namespace MortageCalculator
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
            this.amountLoanTextBox = new System.Windows.Forms.TextBox();
            this.annualInterestTextBox = new System.Windows.Forms.TextBox();
            this.numberYearsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthlyPaymentLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.averageMonthlyPaymentsLabel = new System.Windows.Forms.Label();
            this.totalMonthlyPaymentsLabel = new System.Windows.Forms.Label();
            this.totalLoansLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.qualifyButton = new System.Windows.Forms.Button();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.yearsWorkedTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.decisionLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.summaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // amountLoanTextBox
            // 
            this.amountLoanTextBox.AcceptsTab = true;
            this.amountLoanTextBox.Location = new System.Drawing.Point(156, 175);
            this.amountLoanTextBox.Name = "amountLoanTextBox";
            this.amountLoanTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountLoanTextBox.TabIndex = 2;
            // 
            // annualInterestTextBox
            // 
            this.annualInterestTextBox.AcceptsTab = true;
            this.annualInterestTextBox.Location = new System.Drawing.Point(156, 201);
            this.annualInterestTextBox.Name = "annualInterestTextBox";
            this.annualInterestTextBox.Size = new System.Drawing.Size(100, 20);
            this.annualInterestTextBox.TabIndex = 3;
            // 
            // numberYearsTextBox
            // 
            this.numberYearsTextBox.AcceptsTab = true;
            this.numberYearsTextBox.Location = new System.Drawing.Point(156, 232);
            this.numberYearsTextBox.Name = "numberYearsTextBox";
            this.numberYearsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberYearsTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount Of Loan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount Of Annual Interest:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of Years:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // monthlyPaymentLabel
            // 
            this.monthlyPaymentLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.monthlyPaymentLabel.Location = new System.Drawing.Point(156, 266);
            this.monthlyPaymentLabel.Name = "monthlyPaymentLabel";
            this.monthlyPaymentLabel.Size = new System.Drawing.Size(100, 23);
            this.monthlyPaymentLabel.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Monthly Payment:";
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.averageMonthlyPaymentsLabel);
            this.summaryGroupBox.Controls.Add(this.totalMonthlyPaymentsLabel);
            this.summaryGroupBox.Controls.Add(this.totalLoansLabel);
            this.summaryGroupBox.Controls.Add(this.label8);
            this.summaryGroupBox.Controls.Add(this.label7);
            this.summaryGroupBox.Controls.Add(this.label6);
            this.summaryGroupBox.Location = new System.Drawing.Point(44, 310);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(321, 155);
            this.summaryGroupBox.TabIndex = 8;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Summary:";
            // 
            // averageMonthlyPaymentsLabel
            // 
            this.averageMonthlyPaymentsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.averageMonthlyPaymentsLabel.Location = new System.Drawing.Point(179, 85);
            this.averageMonthlyPaymentsLabel.Name = "averageMonthlyPaymentsLabel";
            this.averageMonthlyPaymentsLabel.Size = new System.Drawing.Size(100, 23);
            this.averageMonthlyPaymentsLabel.TabIndex = 5;
            // 
            // totalMonthlyPaymentsLabel
            // 
            this.totalMonthlyPaymentsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalMonthlyPaymentsLabel.Location = new System.Drawing.Point(179, 50);
            this.totalMonthlyPaymentsLabel.Name = "totalMonthlyPaymentsLabel";
            this.totalMonthlyPaymentsLabel.Size = new System.Drawing.Size(100, 23);
            this.totalMonthlyPaymentsLabel.TabIndex = 4;
            // 
            // totalLoansLabel
            // 
            this.totalLoansLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalLoansLabel.Location = new System.Drawing.Point(179, 20);
            this.totalLoansLabel.Name = "totalLoansLabel";
            this.totalLoansLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLoansLabel.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Average Monthly Payment:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total of Monthly Payments:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total of All Loans:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(44, 481);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(191, 481);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Cl&ear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(325, 481);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // qualifyButton
            // 
            this.qualifyButton.Location = new System.Drawing.Point(325, 41);
            this.qualifyButton.Name = "qualifyButton";
            this.qualifyButton.Size = new System.Drawing.Size(75, 37);
            this.qualifyButton.TabIndex = 11;
            this.qualifyButton.Text = "Do you &Qualify?";
            this.qualifyButton.UseVisualStyleBackColor = true;
            this.qualifyButton.Click += new System.EventHandler(this.qualifyButton_Click);
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.AcceptsTab = true;
            this.salaryTextBox.Location = new System.Drawing.Point(191, 38);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTextBox.TabIndex = 0;
            // 
            // yearsWorkedTextBox
            // 
            this.yearsWorkedTextBox.AcceptsTab = true;
            this.yearsWorkedTextBox.Location = new System.Drawing.Point(191, 65);
            this.yearsWorkedTextBox.Name = "yearsWorkedTextBox";
            this.yearsWorkedTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearsWorkedTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Salary:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Years Worked:";
            // 
            // decisionLabel
            // 
            this.decisionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.decisionLabel.Location = new System.Drawing.Point(285, 104);
            this.decisionLabel.Name = "decisionLabel";
            this.decisionLabel.Size = new System.Drawing.Size(140, 84);
            this.decisionLabel.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(355, 525);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Created By: Paul Blessing";
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(495, 547);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.decisionLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yearsWorkedTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.qualifyButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.monthlyPaymentLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberYearsTextBox);
            this.Controls.Add(this.annualInterestTextBox);
            this.Controls.Add(this.amountLoanTextBox);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Form1";
            this.Text = "Mortage Calculator";
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amountLoanTextBox;
        private System.Windows.Forms.TextBox annualInterestTextBox;
        private System.Windows.Forms.TextBox numberYearsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label monthlyPaymentLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.Label averageMonthlyPaymentsLabel;
        private System.Windows.Forms.Label totalMonthlyPaymentsLabel;
        private System.Windows.Forms.Label totalLoansLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button qualifyButton;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox yearsWorkedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label decisionLabel;
        private System.Windows.Forms.Label label10;
    }
}

