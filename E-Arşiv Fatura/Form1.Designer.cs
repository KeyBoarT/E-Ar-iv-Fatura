
namespace E_Arşiv_Fatura
{
    partial class loginScreenForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.gitHubButton = new System.Windows.Forms.Button();
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.parolaTextBox = new System.Windows.Forms.TextBox();
            this.girisYapButton = new System.Windows.Forms.Button();
            this.sifreyiGizleGosterCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = global::E_Arşiv_Fatura.Properties.Resources.log_out;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(390, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(32, 32);
            this.exitButton.TabIndex = 0;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.BackgroundImage = global::E_Arşiv_Fatura.Properties.Resources.minimize;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(352, 12);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(32, 32);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // gitHubButton
            // 
            this.gitHubButton.BackColor = System.Drawing.Color.Transparent;
            this.gitHubButton.BackgroundImage = global::E_Arşiv_Fatura.Properties.Resources.github;
            this.gitHubButton.FlatAppearance.BorderSize = 0;
            this.gitHubButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.gitHubButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.gitHubButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gitHubButton.Location = new System.Drawing.Point(300, 536);
            this.gitHubButton.Name = "gitHubButton";
            this.gitHubButton.Size = new System.Drawing.Size(24, 24);
            this.gitHubButton.TabIndex = 2;
            this.gitHubButton.UseVisualStyleBackColor = false;
            this.gitHubButton.Click += new System.EventHandler(this.gitHubButton_Click);
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.kullaniciAdiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kullaniciAdiTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullaniciAdiTextBox.ForeColor = System.Drawing.Color.White;
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(64, 293);
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(306, 22);
            this.kullaniciAdiTextBox.TabIndex = 3;
            this.kullaniciAdiTextBox.Text = "Kullanıcı Adı";
            this.kullaniciAdiTextBox.Enter += new System.EventHandler(this.kullaniciAdiTextBox_Enter);
            this.kullaniciAdiTextBox.Leave += new System.EventHandler(this.kullaniciAdiTextBox_Leave);
            // 
            // parolaTextBox
            // 
            this.parolaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parolaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.parolaTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parolaTextBox.ForeColor = System.Drawing.Color.White;
            this.parolaTextBox.Location = new System.Drawing.Point(64, 357);
            this.parolaTextBox.Name = "parolaTextBox";
            this.parolaTextBox.Size = new System.Drawing.Size(306, 22);
            this.parolaTextBox.TabIndex = 4;
            this.parolaTextBox.Text = "Parola";
            this.parolaTextBox.Enter += new System.EventHandler(this.parolaTextBox_Enter);
            this.parolaTextBox.Leave += new System.EventHandler(this.parolaTextBox_Leave);
            // 
            // girisYapButton
            // 
            this.girisYapButton.BackColor = System.Drawing.Color.Transparent;
            this.girisYapButton.Font = new System.Drawing.Font("Prosto One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYapButton.ForeColor = System.Drawing.Color.Black;
            this.girisYapButton.Location = new System.Drawing.Point(64, 393);
            this.girisYapButton.Name = "girisYapButton";
            this.girisYapButton.Size = new System.Drawing.Size(120, 30);
            this.girisYapButton.TabIndex = 5;
            this.girisYapButton.Text = "Giriş Yap";
            this.girisYapButton.UseVisualStyleBackColor = false;
            this.girisYapButton.Click += new System.EventHandler(this.girisYapButton_Click);
            // 
            // sifreyiGizleGosterCheckBox
            // 
            this.sifreyiGizleGosterCheckBox.AutoSize = true;
            this.sifreyiGizleGosterCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.sifreyiGizleGosterCheckBox.FlatAppearance.BorderSize = 0;
            this.sifreyiGizleGosterCheckBox.Font = new System.Drawing.Font("Prosto One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreyiGizleGosterCheckBox.ForeColor = System.Drawing.Color.White;
            this.sifreyiGizleGosterCheckBox.Location = new System.Drawing.Point(190, 397);
            this.sifreyiGizleGosterCheckBox.Name = "sifreyiGizleGosterCheckBox";
            this.sifreyiGizleGosterCheckBox.Size = new System.Drawing.Size(136, 25);
            this.sifreyiGizleGosterCheckBox.TabIndex = 6;
            this.sifreyiGizleGosterCheckBox.Text = "Şifreyi Gizle";
            this.sifreyiGizleGosterCheckBox.UseVisualStyleBackColor = false;
            this.sifreyiGizleGosterCheckBox.CheckedChanged += new System.EventHandler(this.sifreyiGizleGosterCheckBox_CheckedChanged);
            // 
            // loginScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E_Arşiv_Fatura.Properties.Resources.LoginScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.sifreyiGizleGosterCheckBox);
            this.Controls.Add(this.girisYapButton);
            this.Controls.Add(this.parolaTextBox);
            this.Controls.Add(this.kullaniciAdiTextBox);
            this.Controls.Add(this.gitHubButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "loginScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Arşiv Fatura";
            this.Load += new System.EventHandler(this.loginScreenForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginScreenForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginScreenForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginScreenForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button gitHubButton;
        private System.Windows.Forms.TextBox kullaniciAdiTextBox;
        private System.Windows.Forms.TextBox parolaTextBox;
        private System.Windows.Forms.Button girisYapButton;
        private System.Windows.Forms.CheckBox sifreyiGizleGosterCheckBox;
    }
}

