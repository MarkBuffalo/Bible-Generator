namespace BibleProject.Forms.Usercontrols
{
    partial class MySQL
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
            this.gb_ConnectionInformation = new System.Windows.Forms.GroupBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Database = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Server = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.tb_Server = new System.Windows.Forms.TextBox();
            this.tb_Database = new System.Windows.Forms.TextBox();
            this.gb_ConnectionInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_ConnectionInformation
            // 
            this.gb_ConnectionInformation.Controls.Add(this.tb_Password);
            this.gb_ConnectionInformation.Controls.Add(this.lbl_Password);
            this.gb_ConnectionInformation.Controls.Add(this.lbl_Database);
            this.gb_ConnectionInformation.Controls.Add(this.tb_Username);
            this.gb_ConnectionInformation.Controls.Add(this.lbl_Server);
            this.gb_ConnectionInformation.Controls.Add(this.lbl_Username);
            this.gb_ConnectionInformation.Controls.Add(this.tb_Server);
            this.gb_ConnectionInformation.Controls.Add(this.tb_Database);
            this.gb_ConnectionInformation.Location = new System.Drawing.Point(3, 3);
            this.gb_ConnectionInformation.Name = "gb_ConnectionInformation";
            this.gb_ConnectionInformation.Size = new System.Drawing.Size(358, 204);
            this.gb_ConnectionInformation.TabIndex = 10;
            this.gb_ConnectionInformation.TabStop = false;
            this.gb_ConnectionInformation.Text = "Connection Information";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(98, 144);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(181, 22);
            this.tb_Password.TabIndex = 10;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(14, 147);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(69, 17);
            this.lbl_Password.TabIndex = 9;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Database
            // 
            this.lbl_Database.AutoSize = true;
            this.lbl_Database.Location = new System.Drawing.Point(14, 69);
            this.lbl_Database.Name = "lbl_Database";
            this.lbl_Database.Size = new System.Drawing.Size(69, 17);
            this.lbl_Database.TabIndex = 4;
            this.lbl_Database.Text = "Database";
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(98, 105);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(181, 22);
            this.tb_Username.TabIndex = 8;
            // 
            // lbl_Server
            // 
            this.lbl_Server.AutoSize = true;
            this.lbl_Server.Location = new System.Drawing.Point(14, 28);
            this.lbl_Server.Name = "lbl_Server";
            this.lbl_Server.Size = new System.Drawing.Size(50, 17);
            this.lbl_Server.TabIndex = 3;
            this.lbl_Server.Text = "Server";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(14, 108);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(73, 17);
            this.lbl_Username.TabIndex = 7;
            this.lbl_Username.Text = "Username";
            // 
            // tb_Server
            // 
            this.tb_Server.Location = new System.Drawing.Point(98, 28);
            this.tb_Server.Name = "tb_Server";
            this.tb_Server.Size = new System.Drawing.Size(181, 22);
            this.tb_Server.TabIndex = 5;
            // 
            // tb_Database
            // 
            this.tb_Database.Location = new System.Drawing.Point(98, 66);
            this.tb_Database.Name = "tb_Database";
            this.tb_Database.Size = new System.Drawing.Size(181, 22);
            this.tb_Database.TabIndex = 6;
            // 
            // MySQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_ConnectionInformation);
            this.Name = "MySQL";
            this.Size = new System.Drawing.Size(366, 208);
            this.Tag = "MySQL";
            this.gb_ConnectionInformation.ResumeLayout(false);
            this.gb_ConnectionInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Database;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lbl_Server;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox tb_Server;
        private System.Windows.Forms.TextBox tb_Database;
        public System.Windows.Forms.GroupBox gb_ConnectionInformation;
    }
}
