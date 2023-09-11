namespace MyBank1
{
    partial class ATM
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
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.savingsRadioButton = new System.Windows.Forms.RadioButton();
            this.checkingRadioButton = new System.Windows.Forms.RadioButton();
            this.Balances = new System.Windows.Forms.GroupBox();
            this.Savings = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkingLabel = new System.Windows.Forms.Label();
            this.savingsLabel = new System.Windows.Forms.Label();
            this.depositButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Balances.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount:";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(121, 27);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkingRadioButton);
            this.groupBox1.Controls.Add(this.savingsRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accounts";
            // 
            // savingsRadioButton
            // 
            this.savingsRadioButton.AutoSize = true;
            this.savingsRadioButton.Location = new System.Drawing.Point(91, 29);
            this.savingsRadioButton.Name = "savingsRadioButton";
            this.savingsRadioButton.Size = new System.Drawing.Size(63, 17);
            this.savingsRadioButton.TabIndex = 0;
            this.savingsRadioButton.TabStop = true;
            this.savingsRadioButton.Text = "Savings";
            this.savingsRadioButton.UseVisualStyleBackColor = true;
            // 
            // checkingRadioButton
            // 
            this.checkingRadioButton.AutoSize = true;
            this.checkingRadioButton.Location = new System.Drawing.Point(91, 62);
            this.checkingRadioButton.Name = "checkingRadioButton";
            this.checkingRadioButton.Size = new System.Drawing.Size(70, 17);
            this.checkingRadioButton.TabIndex = 1;
            this.checkingRadioButton.TabStop = true;
            this.checkingRadioButton.Text = "Checking";
            this.checkingRadioButton.UseVisualStyleBackColor = true;
            // 
            // Balances
            // 
            this.Balances.Controls.Add(this.savingsLabel);
            this.Balances.Controls.Add(this.checkingLabel);
            this.Balances.Controls.Add(this.label3);
            this.Balances.Controls.Add(this.Savings);
            this.Balances.Location = new System.Drawing.Point(27, 212);
            this.Balances.Name = "Balances";
            this.Balances.Size = new System.Drawing.Size(241, 127);
            this.Balances.TabIndex = 3;
            this.Balances.TabStop = false;
            this.Balances.Text = "Balances";
            // 
            // Savings
            // 
            this.Savings.AutoSize = true;
            this.Savings.Location = new System.Drawing.Point(19, 35);
            this.Savings.Name = "Savings";
            this.Savings.Size = new System.Drawing.Size(48, 13);
            this.Savings.TabIndex = 0;
            this.Savings.Text = "Savings:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Checking:";
            // 
            // checkingLabel
            // 
            this.checkingLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.checkingLabel.Location = new System.Drawing.Point(103, 73);
            this.checkingLabel.Name = "checkingLabel";
            this.checkingLabel.Size = new System.Drawing.Size(100, 23);
            this.checkingLabel.TabIndex = 2;
            // 
            // savingsLabel
            // 
            this.savingsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.savingsLabel.Location = new System.Drawing.Point(103, 34);
            this.savingsLabel.Name = "savingsLabel";
            this.savingsLabel.Size = new System.Drawing.Size(100, 23);
            this.savingsLabel.TabIndex = 3;
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(27, 363);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 4;
            this.depositButton.Text = "&Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Withdraw";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(257, 363);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(393, 363);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 422);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.Balances);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ATM";
            this.Text = "ATM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Balances.ResumeLayout(false);
            this.Balances.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton checkingRadioButton;
        private System.Windows.Forms.RadioButton savingsRadioButton;
        private System.Windows.Forms.GroupBox Balances;
        private System.Windows.Forms.Label savingsLabel;
        private System.Windows.Forms.Label checkingLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Savings;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}