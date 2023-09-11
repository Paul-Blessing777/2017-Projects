namespace Administrator
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
            this.admin_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // admin_Button
            // 
            this.admin_Button.Location = new System.Drawing.Point(90, 94);
            this.admin_Button.Name = "admin_Button";
            this.admin_Button.Size = new System.Drawing.Size(75, 23);
            this.admin_Button.TabIndex = 0;
            this.admin_Button.Text = "Administrator";
            this.admin_Button.UseVisualStyleBackColor = true;
            this.admin_Button.Click += new System.EventHandler(this.admin_Button_Click);
            // 
            // MyBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.admin_Button);
            this.Name = "MyBank";
            this.Text = "MyBank";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button admin_Button;
    }
}