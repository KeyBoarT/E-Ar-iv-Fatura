using System;
using System.Windows.Forms;
using OpenQA.Selenium;

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

        private void mainScreenForm_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string kullaniciAdi = driver.FindElement(By.CssSelector("#gen__1004")).Text;
            string vergiNo = driver.FindElement(By.CssSelector("#gen__1005")).Text;
            mainScreenKullaniciAdiLabel.Text = kullaniciAdi;
            mainScreenVergiNoLabel.Text = vergiNo;
            islemlerTabControl.TabPages.Clear();
            islemlerTabControl.TabPages.Add(hosgeldinizTabPage);
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void mainScreenMenuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void mainScreenMenuPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
        }

        private void mainScreenMenuPanel_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void faturaOlusturButton_Click(object sender, EventArgs e)
        {
            Wait wait = new Wait();
            Cursor.Current = Cursors.WaitCursor;
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[1]/div/div/div/div/div/div/ul/li[2]/ul/li[1]/a")).Click();
            islemlerTabControl.TabPages.Clear();
            islemlerTabControl.TabPages.Add(faturaOlusturTabPage);
            if (wait.TryFindByXPath(2, "/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[1]/div/div/div/div[1]/div/div/fieldset/table/tr[1]/td[2]/span"))
                ettnSonucLabel.Text = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[1]/div/div/div/div[1]/div/div/fieldset/table/tr[1]/td[2]/span")).Text;
            duzenlenmeTarihiDateTimePicker.Value = DateTime.Now;
            duzenlenmeSaatiDateTimePicker.Value = DateTime.Now;
            irsaliyeTarihiDateTimePicker.Value.
        }

        private void olusturulanFaturalarButton_Click(object sender, EventArgs e)
        {
            islemlerTabControl.TabPages.Clear();
            islemlerTabControl.TabPages.Add(olusturulanFaturalarTabPage);
        }
    }
}
