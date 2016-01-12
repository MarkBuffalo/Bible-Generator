namespace BibleProject.Forms
{
    partial class frm_Legacy
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
            this.tb_SearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_SelectBook = new System.Windows.Forms.Label();
            this.cb_BibleBookList = new System.Windows.Forms.ComboBox();
            this.wb_BibleBrowserWindow = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // tb_SearchBox
            // 
            this.tb_SearchBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SearchBox.Location = new System.Drawing.Point(584, 7);
            this.tb_SearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.tb_SearchBox.Name = "tb_SearchBox";
            this.tb_SearchBox.Size = new System.Drawing.Size(511, 39);
            this.tb_SearchBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search Bible";
            // 
            // lbl_SelectBook
            // 
            this.lbl_SelectBook.AutoSize = true;
            this.lbl_SelectBook.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectBook.Location = new System.Drawing.Point(17, 11);
            this.lbl_SelectBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SelectBook.Name = "lbl_SelectBook";
            this.lbl_SelectBook.Size = new System.Drawing.Size(140, 32);
            this.lbl_SelectBook.TabIndex = 11;
            this.lbl_SelectBook.Text = "Select Book";
            // 
            // cb_BibleBookList
            // 
            this.cb_BibleBookList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_BibleBookList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_BibleBookList.FormattingEnabled = true;
            this.cb_BibleBookList.Location = new System.Drawing.Point(170, 7);
            this.cb_BibleBookList.Margin = new System.Windows.Forms.Padding(4);
            this.cb_BibleBookList.Name = "cb_BibleBookList";
            this.cb_BibleBookList.Size = new System.Drawing.Size(241, 40);
            this.cb_BibleBookList.TabIndex = 10;
            // 
            // wb_BibleBrowserWindow
            // 
            this.wb_BibleBrowserWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wb_BibleBrowserWindow.Location = new System.Drawing.Point(6, 55);
            this.wb_BibleBrowserWindow.Margin = new System.Windows.Forms.Padding(4);
            this.wb_BibleBrowserWindow.MinimumSize = new System.Drawing.Size(27, 25);
            this.wb_BibleBrowserWindow.Name = "wb_BibleBrowserWindow";
            this.wb_BibleBrowserWindow.Size = new System.Drawing.Size(1089, 539);
            this.wb_BibleBrowserWindow.TabIndex = 9;
            // 
            // frm_Legacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 601);
            this.Controls.Add(this.tb_SearchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_SelectBook);
            this.Controls.Add(this.cb_BibleBookList);
            this.Controls.Add(this.wb_BibleBrowserWindow);
            this.Name = "frm_Legacy";
            this.Text = "frm_Legacy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_SearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_SelectBook;
        private System.Windows.Forms.ComboBox cb_BibleBookList;
        private System.Windows.Forms.WebBrowser wb_BibleBrowserWindow;
    }
}