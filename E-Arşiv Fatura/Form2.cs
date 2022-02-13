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
        }

        private void olusturulanFaturalarButton_Click(object sender, EventArgs e)
        {
            islemlerTabControl.TabPages.Clear();
            islemlerTabControl.TabPages.Add(olusturulanFaturalarTabPage);
        }

        int sayac = 0;
        private void satirEkleButton_Click(object sender, EventArgs e)
        {
            malHizmetBilgisiDataGridView.Rows.Add();
        }

        private void malHizmetBilgisiDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int miktar = 0;
            int kdvOrani = 0;
            Double birimFiyati = 0;

            if (e.ColumnIndex == 2 || e.ColumnIndex == 4 || e.ColumnIndex == 6)
            {
                string strmiktar = Convert.ToString(malHizmetBilgisiDataGridView.CurrentRow.Cells[2].Value);
                string strbirimFiyati = Convert.ToString(malHizmetBilgisiDataGridView.CurrentRow.Cells[4].Value);
                string strkdvOrani = Convert.ToString(malHizmetBilgisiDataGridView.CurrentRow.Cells[6].Value);
                if (strmiktar != null && strmiktar != "")
                {
                    try
                    {
                        miktar = Convert.ToInt32(strmiktar);
                    }
                    
                    catch (FormatException)
                    {
                        MessageBox.Show("Lütfen sadece sayı giriniz !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (e.ColumnIndex == 2)
                        malHizmetBilgisiDataGridView.CurrentCell.Value = miktar;
                }
                else
                {
                    if (e.ColumnIndex == 2)
                    {
                        malHizmetBilgisiDataGridView.CurrentCell.Value = 0;
                        MessageBox.Show("Lütfen bu alanı doldurunuz !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

                if (strbirimFiyati != null && strbirimFiyati != "")
                {
                    
                    try
                    {
                        birimFiyati = Convert.ToDouble(strbirimFiyati);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Lütfen sadece sayı giriniz !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (e.ColumnIndex == 4)
                    {
                        malHizmetBilgisiDataGridView.CurrentCell.Value = birimFiyati;
                    }
                }
                else
                {
                    if (e.ColumnIndex == 4)
                    {
                        malHizmetBilgisiDataGridView.CurrentCell.Value = 0;
                        MessageBox.Show("Lütfen bu alanı doldunuz !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                if (strkdvOrani != null && strkdvOrani != "")
                {
                    kdvOrani = Convert.ToInt32(strkdvOrani.Substring(1));
                }
                malHizmetBilgisiDataGridView.Rows[e.RowIndex].Cells[5].Value = miktar * birimFiyati;
                malHizmetBilgisiDataGridView.Rows[e.RowIndex].Cells[7].Value = (miktar * birimFiyati) * kdvOrani / 100;
                double malHizmetToplamTutari = 0;
                double hesaplananKdv = 0;
                for (int i = malHizmetBilgisiDataGridView.RowCount -1; i >= 0; i--)
                {
                    malHizmetToplamTutari += Convert.ToDouble(malHizmetBilgisiDataGridView.Rows[i].Cells[5].Value);
                    hesaplananKdv += Convert.ToDouble(malHizmetBilgisiDataGridView.Rows[i].Cells[7].Value);
                }
                malHizmetToplamTutarıSonucLabel.Text = malHizmetToplamTutari.ToString();
                hesaplananKdvSonucLabel.Text = hesaplananKdv.ToString();
                vergilerDahilToplamTutarSonucLabel.Text = (malHizmetToplamTutari + hesaplananKdv).ToString();
            }
        }

        private void satirSilButton_Click(object sender, EventArgs e)
        {
            for (int i = malHizmetBilgisiDataGridView.RowCount - 1; i >= 0; i--)
            {
                if (malHizmetBilgisiDataGridView.Rows[i].Cells[0].Value != null)
                {
                    malHizmetBilgisiDataGridView.Rows.Remove(malHizmetBilgisiDataGridView.Rows[i]);
                }
            }
        }
    }
}
