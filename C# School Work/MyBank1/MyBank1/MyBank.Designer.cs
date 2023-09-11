namespace MyBank1
{
    partial class MyBank
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
            this.Admin_button = new System.Windows.Forms.Button();
            this.atmbutton = new System.Windows.Forms.Button();
            this.loanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Admin_button
            // 
            this.Admin_button.Location = new System.Drawing.Point(80, 65);
            this.Admin_button.Name = "Admin_button";
            this.Admin_button.Size = new System.Drawing.Size(75, 23);
            this.Admin_button.TabIndex = 0;
            this.Admin_button.Text = "Admin";
            this.Admin_button.UseVisualStyleBackColor = true;
            this.Admin_button.Click += new System.EventHandler(this.Admin_button_Click);
            // 
            // atmbutton
            // 
            this.atmbutton.Location = new System.Drawing.Point(80, 112);
            this.atmbutton.Name = "atmbutton";
            this.atmbutton.Size = new System.Drawing.Size(75, 23);
            this.atmbutton.TabIndex = 1;
            this.atmbutton.Text = "ATM";
            this.atmbutton.UseVisualStyleBackColor = true;
            this.atmbutton.Click += new System.EventHandler(this.atmbutton_Click);
            // 
            // loanButton
            // 
            this.loanButton.Location = new System.Drawing.Point(80, 166);
            this.loanButton.Name = "loanButton";
            this.loanButton.Size = new System.Drawing.Size(75, 23);
            this.loanButton.TabIndex = 2;
            this.loanButton.Text = "Loans";
            this.loanButton.UseVisualStyleBackColor = true;
            this.loanButton.Click += new System.EventHandler(this.loanButton_Click);
            // 
            // MyBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.loanButton);
            this.Controls.Add(this.atmbutton);
            this.Controls.Add(this.Admin_button);
            this.Name = "MyBank";
            this.Text = "My Bank";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Admin_button;
        private System.Windows.Forms.Button atmbutton;
        private System.Windows.Forms.Button loanButton;
    }
}

