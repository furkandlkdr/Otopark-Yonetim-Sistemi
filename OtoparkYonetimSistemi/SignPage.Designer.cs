namespace OtoparkYonetimSistemi {
    partial class SignPage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.leftPanel = new System.Windows.Forms.Panel();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.signInBtn = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.headerPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.headerPic)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(101)))), ((int)(((byte)(19)))));
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(168, 404);
            this.leftPanel.TabIndex = 0;
            // 
            // usernameTxt
            // 
            this.usernameTxt.BackColor = System.Drawing.SystemColors.Window;
            this.usernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(248, 189);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(241, 29);
            this.usernameTxt.TabIndex = 2;
            this.usernameTxt.Text = "Kullanıcı Adı";
            this.usernameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(248, 239);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(241, 29);
            this.passwordTxt.TabIndex = 2;
            this.passwordTxt.Text = "Parola";
            this.passwordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(113)))));
            this.signInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.signInBtn.Location = new System.Drawing.Point(305, 295);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(126, 35);
            this.signInBtn.TabIndex = 3;
            this.signInBtn.Text = "Giris Yap";
            this.signInBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.signInBtn.UseVisualStyleBackColor = false;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.Black;
            this.header.Location = new System.Drawing.Point(301, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(141, 25);
            this.header.TabIndex = 5;
            this.header.Text = "Faruk Otopark";
            // 
            // headerPic
            // 
            this.headerPic.Image = global::OtoparkYonetimSistemi.Properties.Resources.logo_faruk_otopark;
            this.headerPic.Location = new System.Drawing.Point(306, 39);
            this.headerPic.Name = "headerPic";
            this.headerPic.Size = new System.Drawing.Size(125, 125);
            this.headerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headerPic.TabIndex = 4;
            this.headerPic.TabStop = false;
            // 
            // SignPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(585, 404);
            this.Controls.Add(this.header);
            this.Controls.Add(this.headerPic);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SignPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Page";
            ((System.ComponentModel.ISupportInitialize)(this.headerPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.PictureBox headerPic;
        private System.Windows.Forms.Label header;
    }
}

