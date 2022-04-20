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
            this.faturaBilgileriGroupBox.Click += new EventHandler(this.faturaBilgileriGroupBox_Click);
            this.aliciBilgileriGroupBox.Click += new EventHandler(this.aliciBilgileriGroupBox_Click);
            this.toplamlarGroupBox.Click += new EventHandler(this.toplamlarGroupBox_Click);

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
            duzenlenmeTarihiDateTimePicker.MaxDate = DateTime.Now;
            duzenlenmeTarihiDateTimePicker.MinDate = new DateTime(DateTime.Now.Year - 10, 1, 1);
        }

        private void olusturulanFaturalarButton_Click(object sender, EventArgs e)
        {
            islemlerTabControl.TabPages.Clear();
            islemlerTabControl.TabPages.Add(olusturulanFaturalarTabPage);
        }

        private void satirEkleButton_Click(object sender, EventArgs e)
        {
            malHizmetBilgisiDataGridView.Rows.Add();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement satirEkleButton = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[3]/div/div/fieldset/div/div[3]/div/div/div/div[1]/div/div/input"));
            js.ExecuteScript("arguments[0].click()", satirEkleButton);
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
                ToplamlariHesaplaYazdir();
            }
        }

        private void ToplamlariHesaplaYazdir()
        {
            double malHizmetToplamTutari = 0;
            double hesaplananKdv = 0;
            for (int i = malHizmetBilgisiDataGridView.RowCount - 1; i >= 0; i--)
            {
                malHizmetToplamTutari += Convert.ToDouble(malHizmetBilgisiDataGridView.Rows[i].Cells[5].Value);
                hesaplananKdv += Convert.ToDouble(malHizmetBilgisiDataGridView.Rows[i].Cells[7].Value);
            }
            malHizmetToplamTutarıSonucLabel.Text = malHizmetToplamTutari.ToString();
            hesaplananKdvSonucLabel.Text = hesaplananKdv.ToString();
            vergilerDahilToplamTutarSonucLabel.Text = (malHizmetToplamTutari + hesaplananKdv).ToString();
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
            ToplamlariHesaplaYazdir();
        }

        private void vknTextBox_Leave(object sender, EventArgs e)
        {
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[1]/div/div/div/div[2]/div/div/fieldset/table/tr[1]/td[2]/input")).SendKeys(vknTextBox.Text);
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[1]/div/div/div/div[2]/div/div/fieldset/table/tr[2]/td[2]/input")).Click();
            System.Threading.Thread.Sleep(1000);
            string unvan = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[1]/div/div/div/div[2]/div/div/fieldset/table/tr[2]/td[2]/input")).GetAttribute("value");
            string ad = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[1]/div/div/div/div[2]/div/div/fieldset/table/tr[3]/td[2]/input")).GetAttribute("value");
            string soyad = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[1]/div/div/div/div[2]/div/div/fieldset/table/tr[4]/td[2]/input")).GetAttribute("value");
            string vergiDairesi = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[1]/div/div/div/div[2]/div/div/fieldset/table/tr[5]/td[2]/input")).GetAttribute("value");
            unvanTextBox.Text = unvan;
            adıTextBox.Text = ad;
            soyadıTextBox.Text = soyad;
            vergiDairesiTextBox.Text = vergiDairesi;
        }

        private void mainScreenMenuPanel_Click(object sender, EventArgs e)
        {
            mainScreenMenuPictureBox.Focus();
        }

        private void mainScreenForm_Click(object sender, EventArgs e)
        {
            mainScreenMenuPictureBox.Focus();
        }

        private void faturaBilgileriGroupBox_Click(object sender, EventArgs e)
        {
            mainScreenMenuPictureBox.Focus();
        }

        private void aliciBilgileriGroupBox_Click(object sender, EventArgs e)
        {
            mainScreenMenuPictureBox.Focus();
        }

        private void toplamlarGroupBox_Click(object sender, EventArgs e)
        {
            mainScreenMenuPictureBox.Focus();
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement duzenlenmeTarihi = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[1]/div/div/div/div[1]/div/div/fieldset/table/tr[3]/td[2]/div/input"));
            js.ExecuteScript("arguments[0].removeAttribute('disabled', 'disabled')", duzenlenmeTarihi);
            duzenlenmeTarihi.Click();
            IWebElement duzenlemeSaati = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[1]/div/div/div/div[1]/div/div/fieldset/table/tr[4]/td[2]/div/input"));
            IWebElement vknEntry = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[1]/div/div/div/div[2]/div/div/fieldset/table/tr[1]/td[2]/input"));
            IWebElement unvanEntry = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[1]/div/div/div/div[2]/div/div/fieldset/table/tr[2]/td[2]/input"));
            IWebElement adEntry = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[1]/div/div/div/div[2]/div/div/fieldset/table/tr[3]/td[2]/input"));
            IWebElement soyadEntry = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[1]/div/div/div/div[2]/div/div/fieldset/table/tr[4]/td[2]/input"));
            IWebElement vergiDairesiEntry = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[1]/div/div/div/div[2]/div/div/fieldset/table/tr[5]/td[2]/input"));
            IWebElement adresEntry = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[1]/div/div/div/div[2]/div/div/fieldset/table/tr[7]/td[2]/textarea"));
            int secilenUlke = ulkeComboBox.SelectedIndex;
            IWebElement notEntry = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[5]/div/div/fieldset/div/div/div/textarea"));
            duzenlemeSaati.Clear();
            vknEntry.Clear();
            unvanEntry.Clear();
            adEntry.Clear();
            soyadEntry.Clear();
            vergiDairesiEntry.Clear();
            adresEntry.Clear();
            notEntry.Clear();
            duzenlenmeTarihi.SendKeys(duzenlenmeTarihiDateTimePicker.Text);
            duzenlemeSaati.SendKeys(duzenlenmeSaatiDateTimePicker.Text);
            vknEntry.SendKeys(vknTextBox.Text);
            unvanEntry.SendKeys(unvanTextBox.Text);
            adEntry.SendKeys(adıTextBox.Text);
            soyadEntry.SendKeys(soyadıTextBox.Text);
            vergiDairesiEntry.SendKeys(vergiDairesiTextBox.Text);
            if (secilenUlke == -1)
            {
                MessageBox.Show("Ülke alanı boş olamaz !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[1]/div/div/div/div[2]/div/div/fieldset/table/tr[6]/td[2]/select/option[" + (secilenUlke + 1) + "]")).Click();
            }
            adresEntry.SendKeys(adresTextBox.Text);
            for (int i = 0; i < malHizmetBilgisiDataGridView.RowCount; i++)
            {
                
                IWebElement malHizmetEntry = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[3]/div/div/fieldset/div/div[2]/div/div/table/tbody/tr[" + (i + 1) + "]/td[4]/input"));
                IWebElement miktarEntry = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[3]/div/div/fieldset/div/div[2]/div/div/table/tbody/tr[" + (i + 1) + "]/td[5]/input"));
                DataGridViewComboBoxCell birimComboBox = (DataGridViewComboBoxCell)malHizmetBilgisiDataGridView.Rows[i].Cells[3];
                IWebElement birimFiyatiEntry = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[3]/div/div/fieldset/div/div[2]/div/div/table/tbody/tr[" + (i + 1) + "]/td[7]/input"));
                DataGridViewComboBoxCell kdvYuzdeComboBox = (DataGridViewComboBoxCell)malHizmetBilgisiDataGridView.Rows[i].Cells[6];
                malHizmetEntry.Clear();
                miktarEntry.Clear();
                birimFiyatiEntry.Clear();
                string kdvYuzdesi = Convert.ToString(kdvYuzdeComboBox.Items.IndexOf(kdvYuzdeComboBox.Value));
                string birim = Convert.ToString(birimComboBox.Items.IndexOf(birimComboBox.Value));
                string malHizmet = Convert.ToString(malHizmetBilgisiDataGridView.Rows[i].Cells[1].Value);
                string miktar = Convert.ToString(malHizmetBilgisiDataGridView.Rows[i].Cells[2].Value);
                string birimFiyati = Convert.ToString(malHizmetBilgisiDataGridView.Rows[i].Cells[4].Value);
                
                
                if (kdvYuzdesi != null && kdvYuzdesi != "")
                {
                    driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[3]/div/div/fieldset/div/div[2]/div/div/table/tbody/tr[" + (i + 1) + "]/td[11]/select/option[" + (Convert.ToInt32(kdvYuzdesi) + 1) + "]")).Click();
                }
                if (birim != null && birim != "")
                {
                    driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div/div[3]/div/div/fieldset/div/div[2]/div/div/table/tbody/tr[" + (i + 1) + "]/td[6]/select/option[" + (Convert.ToInt32(birim) + 1) + "]")).Click();
                }
                if (malHizmet != null && malHizmet != "")
                {
                    malHizmetEntry.SendKeys(malHizmet);
                }
                if (miktar != null && miktar != "")
                {
                    miktarEntry.SendKeys(miktar);
                }
                if (birimFiyati != null && birimFiyati != "")
                {
                    birimFiyatiEntry.SendKeys(birimFiyati);
                }
            }
            notEntry.SendKeys(notTextBox.Text);
        }
    }
}
