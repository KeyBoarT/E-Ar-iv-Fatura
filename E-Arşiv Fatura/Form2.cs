using System;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace E_Arşiv_Fatura
{
    public partial class mainScreenForm : Form
    {
        public mainScreenForm()
        {
            InitializeComponent();
        }

        IWebDriver driver = loginScreenForm.driver;

        private void mainScreenExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            driver.Quit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void mainScreenForm_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void mainScreenForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
        }

        private void mainScreenForm_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void mainScreenForm_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string kullaniciAdi = driver.FindElement(By.CssSelector("#gen__1004")).Text;
            string vergiNo = driver.FindElement(By.CssSelector("#gen__1005")).Text;
            mainScreenKullaniciAdiLabel.Text = kullaniciAdi;
            mainScreenVergiNoLabel.Text = vergiNo;
        }
    }
}
