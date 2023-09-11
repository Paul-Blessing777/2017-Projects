namespace ATMApplication
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkingRadioButton = new System.Windows.Forms.RadioButton();
            this.savingsRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkingLabel = new System.Windows.Forms.Label();
            this.savingsLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkingRadioButton);
            this.groupBox1.Controls.Add(this.savingsRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(36, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // checkingRadioButton
            // 
            this.checkingRadioButton.AutoSize = true;
            this.checkingRadioButton.Location = new System.Drawing.Point(55, 56);
            this.checkingRadioButton.Name = "checkingRadioButton";
            this.checkingRadioButton.Size = new System.Drawing.Size(70, 17);
            this.checkingRadioButton.TabIndex = 2;
            this.checkingRadioButton.TabStop = true;
            this.checkingRadioButton.Text = "Checking";
            this.checkingRadioButton.UseVisualStyleBackColor = true;
            // 
            // savingsRadioButton
            // 
            this.savingsRadioButton.AutoSize = true;
            this.savingsRadioButton.Location = new System.Drawing.Point(55, 20);
            this.savingsRadioButton.Name = "savingsRadioButton";
            this.savingsRadioButton.Size = new System.Drawing.Size(63, 17);
            this.savingsRadioButton.TabIndex = 1;
            this.savingsRadioButton.TabStop = true;
            this.savingsRadioButton.Text = "Savings";
            this.savingsRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Accounts";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkingLabel);
            this.groupBox2.Controls.Add(this.savingsLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(78, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 102);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // checkingLabel
            // 
            this.checkingLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.checkingLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.checkingLabel.Location = new System.Drawing.Point(99, 56);
            this.checkingLabel.Name = "checkingLabel";
            this.checkingLabel.Size = new System.Drawing.Size(100, 23);
            this.checkingLabel.TabIndex = 3;
            // 
            // savingsLabel
            // 
            this.savingsLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.savingsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.savingsLabel.Location = new System.Drawing.Point(100, 20);
            this.savingsLabel.Name = "savingsLabel";
            this.savingsLabel.Size = new System.Drawing.Size(100, 23);
            this.savingsLabel.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Checking";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Savings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Balances";
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(36, 395);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 3;
            this.depositButton.Text = "&Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(136, 395);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(75, 23);
            this.withdrawButton.TabIndex = 4;
            this.withdrawButton.Text = "&Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(240, 395);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(343, 395);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(366, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Created By; Paul Blessing";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(164, 28);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 0;
            // 
            // ATM
            // 
            this.AcceptButton = this.depositButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ATM";
            this.Text = "ATM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton checkingRadioButton;
        private System.Windows.Forms.RadioButton savingsRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label checkingLabel;
        private System.Windows.Forms.Label savingsLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox amountTextBox;
    }
}

