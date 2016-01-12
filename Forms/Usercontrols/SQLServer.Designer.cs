namespace BibleProject.Forms.Usercontrols
{
    partial class SQLServer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtb_ConnectionString = new System.Windows.Forms.RichTextBox();
            this.lbl_ConnectionString = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtb_ConnectionString
            // 
            this.rtb_ConnectionString.Location = new System.Drawing.Point(3, 48);
            this.rtb_ConnectionString.Name = "rtb_ConnectionString";
            this.rtb_ConnectionString.Size = new System.Drawing.Size(355, 156);
            this.rtb_ConnectionString.TabIndex = 0;
            this.rtb_ConnectionString.Text = "";
            // 
            // lbl_ConnectionString
            // 
            this.lbl_ConnectionString.AutoSize = true;
            this.lbl_ConnectionString.Location = new System.Drawing.Point(86, 17);
            this.lbl_ConnectionString.Name = "lbl_ConnectionString";
            this.lbl_ConnectionString.Size = new System.Drawing.Size(198, 17);
            this.lbl_ConnectionString.TabIndex = 1;
            this.lbl_ConnectionString.Text = "SQL Server Connection String";
            // 
            // SQLServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_ConnectionString);
            this.Controls.Add(this.rtb_ConnectionString);
            this.Name = "SQLServer";
            this.Size = new System.Drawing.Size(366, 208);
            this.Tag = "SQLServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_ConnectionString;
        private System.Windows.Forms.Label lbl_ConnectionString;
    }
}
