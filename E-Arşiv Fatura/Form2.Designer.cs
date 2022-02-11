
namespace E_Arşiv_Fatura
{
    partial class mainScreenForm
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
            this.mainScreenMenuPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.mainScreenExitButton = new System.Windows.Forms.Button();
            this.mainScreenVergiNoLabel = new System.Windows.Forms.Label();
            this.mainScreenKullaniciAdiLabel = new System.Windows.Forms.Label();
            this.mainScreenMenuPictureBox = new System.Windows.Forms.PictureBox();
            this.islemlerGroupBox = new System.Windows.Forms.GroupBox();
            this.olusturulanFaturalarButton = new System.Windows.Forms.Button();
            this.faturaOlusturButton = new System.Windows.Forms.Button();
            this.islemlerTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mainScreenMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainScreenMenuPictureBox)).BeginInit();
            this.islemlerGroupBox.SuspendLayout();
            this.islemlerTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainScreenMenuPanel
            // 
            this.mainScreenMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mainScreenMenuPanel.Controls.Add(this.button1);
            this.mainScreenMenuPanel.Controls.Add(this.mainScreenExitButton);
            this.mainScreenMenuPanel.Controls.Add(this.mainScreenVergiNoLabel);
            this.mainScreenMenuPanel.Controls.Add(this.mainScreenKullaniciAdiLabel);
            this.mainScreenMenuPanel.Controls.Add(this.mainScreenMenuPictureBox);
            this.mainScreenMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainScreenMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.mainScreenMenuPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mainScreenMenuPanel.Name = "mainScreenMenuPanel";
            this.mainScreenMenuPanel.Size = new System.Drawing.Size(1008, 70);
            this.mainScreenMenuPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::E_Arşiv_Fatura.Properties.Resources.minimize;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(926, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainScreenExitButton
            // 
            this.mainScreenExitButton.BackgroundImage = global::E_Arşiv_Fatura.Properties.Resources.log_out;
            this.mainScreenExitButton.FlatAppearance.BorderSize = 0;
            this.mainScreenExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.mainScreenExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainScreenExitButton.Location = new System.Drawing.Point(964, 12);
            this.mainScreenExitButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mainScreenExitButton.Name = "mainScreenExitButton";
            this.mainScreenExitButton.Size = new System.Drawing.Size(32, 32);
            this.mainScreenExitButton.TabIndex = 3;
            this.mainScreenExitButton.UseVisualStyleBackColor = true;
            this.mainScreenExitButton.Click += new System.EventHandler(this.mainScreenExitButton_Click);
            // 
            // mainScreenVergiNoLabel
            // 
            this.mainScreenVergiNoLabel.Font = new System.Drawing.Font("Directive Four", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreenVergiNoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.mainScreenVergiNoLabel.Location = new System.Drawing.Point(70, 32);
            this.mainScreenVergiNoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainScreenVergiNoLabel.Name = "mainScreenVergiNoLabel";
            this.mainScreenVergiNoLabel.Size = new System.Drawing.Size(198, 19);
            this.mainScreenVergiNoLabel.TabIndex = 2;
            this.mainScreenVergiNoLabel.Text = "Vergi Numarası";
            // 
            // mainScreenKullaniciAdiLabel
            // 
            this.mainScreenKullaniciAdiLabel.Font = new System.Drawing.Font("Directive Four", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreenKullaniciAdiLabel.ForeColor = System.Drawing.Color.White;
            this.mainScreenKullaniciAdiLabel.Location = new System.Drawing.Point(70, 9);
            this.mainScreenKullaniciAdiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainScreenKullaniciAdiLabel.Name = "mainScreenKullaniciAdiLabel";
            this.mainScreenKullaniciAdiLabel.Size = new System.Drawing.Size(218, 23);
            this.mainScreenKullaniciAdiLabel.TabIndex = 1;
            this.mainScreenKullaniciAdiLabel.Text = "Kullanıcı Adı";
            // 
            // mainScreenMenuPictureBox
            // 
            this.mainScreenMenuPictureBox.Image = global::E_Arşiv_Fatura.Properties.Resources.e_arsiv_logo;
            this.mainScreenMenuPictureBox.Location = new System.Drawing.Point(2, 3);
            this.mainScreenMenuPictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mainScreenMenuPictureBox.Name = "mainScreenMenuPictureBox";
            this.mainScreenMenuPictureBox.Size = new System.Drawing.Size(64, 64);
            this.mainScreenMenuPictureBox.TabIndex = 0;
            this.mainScreenMenuPictureBox.TabStop = false;
            // 
            // islemlerGroupBox
            // 
            this.islemlerGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.islemlerGroupBox.Controls.Add(this.olusturulanFaturalarButton);
            this.islemlerGroupBox.Controls.Add(this.faturaOlusturButton);
            this.islemlerGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.islemlerGroupBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemlerGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.islemlerGroupBox.Location = new System.Drawing.Point(0, 70);
            this.islemlerGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.islemlerGroupBox.Name = "islemlerGroupBox";
            this.islemlerGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.islemlerGroupBox.Size = new System.Drawing.Size(200, 659);
            this.islemlerGroupBox.TabIndex = 1;
            this.islemlerGroupBox.TabStop = false;
            this.islemlerGroupBox.Text = "İşlemler";
            // 
            // olusturulanFaturalarButton
            // 
            this.olusturulanFaturalarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.olusturulanFaturalarButton.FlatAppearance.BorderSize = 0;
            this.olusturulanFaturalarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.olusturulanFaturalarButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.olusturulanFaturalarButton.ForeColor = System.Drawing.Color.Snow;
            this.olusturulanFaturalarButton.Location = new System.Drawing.Point(5, 71);
            this.olusturulanFaturalarButton.Name = "olusturulanFaturalarButton";
            this.olusturulanFaturalarButton.Size = new System.Drawing.Size(190, 40);
            this.olusturulanFaturalarButton.TabIndex = 1;
            this.olusturulanFaturalarButton.Text = "Oluşturulan Faturalar";
            this.olusturulanFaturalarButton.UseVisualStyleBackColor = false;
            // 
            // faturaOlusturButton
            // 
            this.faturaOlusturButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.faturaOlusturButton.FlatAppearance.BorderSize = 0;
            this.faturaOlusturButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.faturaOlusturButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.faturaOlusturButton.ForeColor = System.Drawing.Color.Snow;
            this.faturaOlusturButton.Location = new System.Drawing.Point(5, 25);
            this.faturaOlusturButton.Name = "faturaOlusturButton";
            this.faturaOlusturButton.Size = new System.Drawing.Size(190, 40);
            this.faturaOlusturButton.TabIndex = 0;
            this.faturaOlusturButton.Text = "Fatura Oluştur";
            this.faturaOlusturButton.UseVisualStyleBackColor = false;
            // 
            // islemlerTabControl
            // 
            this.islemlerTabControl.Controls.Add(this.tabPage1);
            this.islemlerTabControl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemlerTabControl.Location = new System.Drawing.Point(205, 76);
            this.islemlerTabControl.Name = "islemlerTabControl";
            this.islemlerTabControl.SelectedIndex = 0;
            this.islemlerTabControl.Size = new System.Drawing.Size(771, 618);
            this.islemlerTabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(763, 586);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.islemlerTabControl);
            this.Controls.Add(this.islemlerGroupBox);
            this.Controls.Add(this.mainScreenMenuPanel);
            this.Font = new System.Drawing.Font("Prosto One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "mainScreenForm";
            this.Text = "E-ARŞİV FATURA";
            this.Load += new System.EventHandler(this.mainScreenForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainScreenForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainScreenForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainScreenForm_MouseUp);
            this.mainScreenMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainScreenMenuPictureBox)).EndInit();
            this.islemlerGroupBox.ResumeLayout(false);
            this.islemlerTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainScreenMenuPanel;
        private System.Windows.Forms.PictureBox mainScreenMenuPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button mainScreenExitButton;
        private System.Windows.Forms.Label mainScreenVergiNoLabel;
        private System.Windows.Forms.Label mainScreenKullaniciAdiLabel;
        private System.Windows.Forms.GroupBox islemlerGroupBox;
        private System.Windows.Forms.Button olusturulanFaturalarButton;
        private System.Windows.Forms.Button faturaOlusturButton;
        private System.Windows.Forms.TabControl islemlerTabControl;
        private System.Windows.Forms.TabPage tabPage1;
    }
}