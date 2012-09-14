namespace PasswordProtector
{
    partial class MainForm
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
            this.txtMain = new System.Windows.Forms.RichTextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMain
            // 
            this.txtMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMain.Location = new System.Drawing.Point(3, 31);
            this.txtMain.Name = "txtMain";
            this.txtMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMain.Size = new System.Drawing.Size(447, 441);
            this.txtMain.TabIndex = 1;
            this.txtMain.Text = "";
            // 
            // txtKey
            // 
            this.txtKey.CausesValidation = false;
            this.txtKey.Location = new System.Drawing.Point(3, 5);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(447, 20);
            this.txtKey.TabIndex = 0;
            this.txtKey.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 476);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtMain;
        private System.Windows.Forms.TextBox txtKey;
    }
}

