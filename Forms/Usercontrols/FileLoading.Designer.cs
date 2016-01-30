namespace BibleProject.Forms.Usercontrols
{
    partial class FileLoading
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
            this.lbl_LoadingText = new System.Windows.Forms.Label();
            this.pb_FileLoadingProgress = new System.Windows.Forms.ProgressBar();
            this.lbl_CurrentFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_LoadingText
            // 
            this.lbl_LoadingText.AutoSize = true;
            this.lbl_LoadingText.Location = new System.Drawing.Point(84, 26);
            this.lbl_LoadingText.Name = "lbl_LoadingText";
            this.lbl_LoadingText.Size = new System.Drawing.Size(182, 17);
            this.lbl_LoadingText.TabIndex = 0;
            this.lbl_LoadingText.Text = "Please wait. Loading data...";
            // 
            // pb_FileLoadingProgress
            // 
            this.pb_FileLoadingProgress.Location = new System.Drawing.Point(40, 70);
            this.pb_FileLoadingProgress.Maximum = 3;
            this.pb_FileLoadingProgress.Name = "pb_FileLoadingProgress";
            this.pb_FileLoadingProgress.Size = new System.Drawing.Size(281, 81);
            this.pb_FileLoadingProgress.Step = 1;
            this.pb_FileLoadingProgress.TabIndex = 1;
            // 
            // lbl_CurrentFile
            // 
            this.lbl_CurrentFile.AutoSize = true;
            this.lbl_CurrentFile.Location = new System.Drawing.Point(119, 170);
            this.lbl_CurrentFile.Name = "lbl_CurrentFile";
            this.lbl_CurrentFile.Size = new System.Drawing.Size(121, 17);
            this.lbl_CurrentFile.TabIndex = 2;
            this.lbl_CurrentFile.Text = "Current file: 1 of 3";
            // 
            // FileLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_CurrentFile);
            this.Controls.Add(this.pb_FileLoadingProgress);
            this.Controls.Add(this.lbl_LoadingText);
            this.Name = "FileLoading";
            this.Size = new System.Drawing.Size(358, 204);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_LoadingText;
        private System.Windows.Forms.ProgressBar pb_FileLoadingProgress;
        private System.Windows.Forms.Label lbl_CurrentFile;
    }
}
