namespace BibleProject.Forms
{
    partial class frm_MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainWindow));
            this.cb_DatabaseType = new System.Windows.Forms.ComboBox();
            this.gb_DatabaseType = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.cb_ForceSSL = new System.Windows.Forms.CheckBox();
            this.p_Contents = new System.Windows.Forms.Panel();
            this.pbar_CurrentInsertionProgress = new System.Windows.Forms.ProgressBar();
            this.lbl_ProgressText = new System.Windows.Forms.Label();
            this.gb_DatabaseType.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_DatabaseType
            // 
            this.cb_DatabaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_DatabaseType.FormattingEnabled = true;
            this.cb_DatabaseType.Items.AddRange(new object[] {
            "MySQL",
            "SQL Server"});
            this.cb_DatabaseType.Location = new System.Drawing.Point(168, 32);
            this.cb_DatabaseType.Name = "cb_DatabaseType";
            this.cb_DatabaseType.Size = new System.Drawing.Size(169, 24);
            this.cb_DatabaseType.TabIndex = 0;
            this.cb_DatabaseType.SelectedIndexChanged += new System.EventHandler(this.cb_DatabaseType_SelectedIndexChanged);
            // 
            // gb_DatabaseType
            // 
            this.gb_DatabaseType.Controls.Add(this.label1);
            this.gb_DatabaseType.Controls.Add(this.cb_DatabaseType);
            this.gb_DatabaseType.Location = new System.Drawing.Point(12, 12);
            this.gb_DatabaseType.Name = "gb_DatabaseType";
            this.gb_DatabaseType.Size = new System.Drawing.Size(361, 76);
            this.gb_DatabaseType.TabIndex = 1;
            this.gb_DatabaseType.TabStop = false;
            this.gb_DatabaseType.Text = "Database Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Database Type";
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(228, 307);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(145, 24);
            this.btn_Create.TabIndex = 1;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // cb_ForceSSL
            // 
            this.cb_ForceSSL.AutoSize = true;
            this.cb_ForceSSL.Location = new System.Drawing.Point(12, 308);
            this.cb_ForceSSL.Name = "cb_ForceSSL";
            this.cb_ForceSSL.Size = new System.Drawing.Size(205, 21);
            this.cb_ForceSSL.TabIndex = 2;
            this.cb_ForceSSL.Text = "Force SSL (Recommended)";
            this.cb_ForceSSL.UseVisualStyleBackColor = true;
            // 
            // p_Contents
            // 
            this.p_Contents.Location = new System.Drawing.Point(12, 94);
            this.p_Contents.Name = "p_Contents";
            this.p_Contents.Size = new System.Drawing.Size(361, 208);
            this.p_Contents.TabIndex = 3;
            // 
            // pbar_CurrentInsertionProgress
            // 
            this.pbar_CurrentInsertionProgress.Location = new System.Drawing.Point(12, 341);
            this.pbar_CurrentInsertionProgress.Name = "pbar_CurrentInsertionProgress";
            this.pbar_CurrentInsertionProgress.Size = new System.Drawing.Size(361, 29);
            this.pbar_CurrentInsertionProgress.Step = 1;
            this.pbar_CurrentInsertionProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbar_CurrentInsertionProgress.TabIndex = 4;
            // 
            // lbl_ProgressText
            // 
            this.lbl_ProgressText.AutoSize = true;
            this.lbl_ProgressText.Location = new System.Drawing.Point(12, 378);
            this.lbl_ProgressText.Name = "lbl_ProgressText";
            this.lbl_ProgressText.Size = new System.Drawing.Size(12, 17);
            this.lbl_ProgressText.TabIndex = 5;
            this.lbl_ProgressText.Text = " ";
            // 
            // frm_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 404);
            this.Controls.Add(this.p_Contents);
            this.Controls.Add(this.lbl_ProgressText);
            this.Controls.Add(this.pbar_CurrentInsertionProgress);
            this.Controls.Add(this.cb_ForceSSL);
            this.Controls.Add(this.gb_DatabaseType);
            this.Controls.Add(this.btn_Create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_MainWindow";
            this.Text = "Database Generator";
            this.Load += new System.EventHandler(this.frm_MainWindow_Load);
            this.gb_DatabaseType.ResumeLayout(false);
            this.gb_DatabaseType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_DatabaseType;
        private System.Windows.Forms.GroupBox gb_DatabaseType;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_ForceSSL;
        private System.Windows.Forms.Panel p_Contents;
        private System.Windows.Forms.ProgressBar pbar_CurrentInsertionProgress;
        private System.Windows.Forms.Label lbl_ProgressText;
    }
}

