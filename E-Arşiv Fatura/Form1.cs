using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace E_Arşiv_Fatura
{
    public partial class loginScreenForm : Form
    {
        public loginScreenForm()
        {
            InitializeComponent();
        }
        //Tüm program boyunca web işlemlerimizi yapacağımız driver nesnemizi oluşturalım
        public static IWebDriver driver = new ChromeDriver();
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            driver.Quit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Programı istediğimiz yere sürüklememiz için gereken kodlar START
        bool move;
        int mouse_x;
        int mouse_y;
        private void loginScreenForm_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void loginScreenForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
        }

        private void loginScreenForm_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        //Programı istediğimiz yere sürüklememiz için gereken kodlar END

        //Kullanıcı adını aldığımız metin kutusu START
        private void kullaniciAdiTextBox_Enter(object sender, EventArgs e)
        {
            if (kullaniciAdiTextBox.Text == "Kullanıcı Adı")
            {
                kullaniciAdiTextBox.Clear();
            }
        }

        private void kullaniciAdiTextBox_Leave(object sender, EventArgs e)
        {
            if (kullaniciAdiTextBox.Text == "")
            {
                kullaniciAdiTextBox.Text = "Kullanıcı Adı";
            }
        }
        //kullanıcı adıın aldığımız metin kutusu END

        //Parolayı aldığımız metin kutusu işlemleri START
        private void parolaTextBox_Enter(object sender, EventArgs e)
        {
            if (parolaTextBox.Text == "Parola")
            {
                parolaTextBox.Clear();
            }
        }

        private void parolaTextBox_Leave(object sender, EventArgs e)
        {
            if (parolaTextBox.Text == "")
            {
                parolaTextBox.Text = "Parola";
            }
        }
        //Parolayı aldığımız metin kutusu işlemleri END

        //Parola TextBox'undaki yazıyı gizleyip açığa çıkarmamıza yarayan kodlar START
        private void sifreyiGizleGosterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sifreyiGizleGosterCheckBox.Checked)
            {
                if (parolaTextBox.Text == "Parola")
                {
                    parolaTextBox.Clear();
                }
                sifreyiGizleGosterCheckBox.Text = "Şifreyi Göster";
                parolaTextBox.UseSystemPasswordChar = true;
            }

            else
            {
                if (parolaTextBox.Text == "")
                {
                    parolaTextBox.Text = "Parola";
                }
                sifreyiGizleGosterCheckBox.Text = "Şifreyi Gizle";
                parolaTextBox.UseSystemPasswordChar = false;
            }
        }
        //Parola TextBox'undaki yazıyı gizleyip açığa çıkarmamıza yarayan kodlar END

        //Github Butonuna basıldığı zaman gidilecek adres
        private void gitHubButton_Click(object sender, EventArgs e)
        {
            Wait wait = new Wait();
            Cursor.Current = Cursors.WaitCursor;
            if (!wait.TryGoToUrl(5, DeveloperInfos.GitHubAddress))
            {
                MessageBox.Show("İnternete bağlı değilsiniz !");
            }
        }
        
    }
}
