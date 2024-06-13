namespace OtoparkYonetimSistemi {
    partial class Places {
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.placeGrid = new System.Windows.Forms.DataGridView();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closePic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.garagePic = new System.Windows.Forms.PictureBox();
            this.headerPic = new System.Windows.Forms.PictureBox();
            this.placeText = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.placeGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).BeginInit();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garagePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(385, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Otopark Yönetim Sistemi v0.7";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(147)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(185, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 30);
            this.panel2.TabIndex = 20;
            // 
            // placeGrid
            // 
            this.placeGrid.AllowUserToAddRows = false;
            this.placeGrid.AllowUserToDeleteRows = false;
            this.placeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.placeGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.placeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.placeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.placeGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.placeGrid.Location = new System.Drawing.Point(128, 177);
            this.placeGrid.Name = "placeGrid";
            this.placeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.placeGrid.Size = new System.Drawing.Size(1127, 661);
            this.placeGrid.TabIndex = 19;
            this.placeGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.placeGrid_CellContentClick);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(47)))));
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.Black;
            this.editButton.Location = new System.Drawing.Point(935, 129);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(196, 35);
            this.editButton.TabIndex = 16;
            this.editButton.Text = "Alan Düzenle";
            this.editButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(147)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(590, 129);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(196, 35);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "Alan Ekle";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Brown;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(263, 129);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(196, 35);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Alanı Sil";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // statusBox
            // 
            this.statusBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Dolu",
            "Bos",
            "Bakimda"});
            this.statusBox.Location = new System.Drawing.Point(774, 82);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(196, 29);
            this.statusBox.TabIndex = 15;
            this.statusBox.Text = "Durumu";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(147)))));
            this.header.Location = new System.Drawing.Point(124, 8);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(141, 25);
            this.header.TabIndex = 10;
            this.header.Text = "Faruk Otopark";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.closePic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1262, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 850);
            this.panel1.TabIndex = 9;
            // 
            // closePic
            // 
            this.closePic.BackColor = System.Drawing.Color.Transparent;
            this.closePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closePic.Image = global::OtoparkYonetimSistemi.Properties.Resources.cross;
            this.closePic.Location = new System.Drawing.Point(115, 12);
            this.closePic.Name = "closePic";
            this.closePic.Size = new System.Drawing.Size(61, 57);
            this.closePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePic.TabIndex = 7;
            this.closePic.TabStop = false;
            this.closePic.Click += new System.EventHandler(this.closePic_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kayıtlı Araçlar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(25, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "Anlık Durum";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(25, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "Park Yerleri";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(47)))));
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.logoutButton);
            this.leftPanel.Controls.Add(this.pictureBox2);
            this.leftPanel.Controls.Add(this.pictureBox1);
            this.leftPanel.Controls.Add(this.garagePic);
            this.leftPanel.Controls.Add(this.headerPic);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(118, 850);
            this.leftPanel.TabIndex = 8;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(47)))));
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoutButton.Image = global::OtoparkYonetimSistemi.Properties.Resources.logout;
            this.logoutButton.Location = new System.Drawing.Point(29, 781);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(61, 57);
            this.logoutButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoutButton.TabIndex = 5;
            this.logoutButton.TabStop = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(47)))));
            this.pictureBox2.Image = global::OtoparkYonetimSistemi.Properties.Resources.parking;
            this.pictureBox2.Location = new System.Drawing.Point(12, 462);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(47)))));
            this.pictureBox1.Image = global::OtoparkYonetimSistemi.Properties.Resources.parking_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // garagePic
            // 
            this.garagePic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(47)))));
            this.garagePic.Image = global::OtoparkYonetimSistemi.Properties.Resources.parking;
            this.garagePic.Location = new System.Drawing.Point(12, 165);
            this.garagePic.Name = "garagePic";
            this.garagePic.Size = new System.Drawing.Size(91, 90);
            this.garagePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.garagePic.TabIndex = 5;
            this.garagePic.TabStop = false;
            this.garagePic.Click += new System.EventHandler(this.garagePic_Click);
            // 
            // headerPic
            // 
            this.headerPic.Image = global::OtoparkYonetimSistemi.Properties.Resources.logo_faruk_otopark;
            this.headerPic.Location = new System.Drawing.Point(12, 12);
            this.headerPic.Name = "headerPic";
            this.headerPic.Size = new System.Drawing.Size(91, 85);
            this.headerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headerPic.TabIndex = 5;
            this.headerPic.TabStop = false;
            // 
            // placeText
            // 
            this.placeText.BackColor = System.Drawing.SystemColors.Window;
            this.placeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.placeText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeText.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.placeText.Location = new System.Drawing.Point(424, 83);
            this.placeText.Name = "placeText";
            this.placeText.Size = new System.Drawing.Size(196, 29);
            this.placeText.TabIndex = 21;
            this.placeText.Text = "Alan";
            this.placeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.placeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.disappearLabel);
            // 
            // Places
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1450, 850);
            this.Controls.Add(this.placeText);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.placeGrid);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.header);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Places";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParkingPlaces";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.placeGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).EndInit();
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garagePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoutButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox headerPic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView placeGrid;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox garagePic;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.PictureBox closePic;
        private System.Windows.Forms.TextBox placeText;
    }
}