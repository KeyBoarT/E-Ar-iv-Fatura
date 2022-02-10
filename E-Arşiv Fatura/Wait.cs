using System;
using System.Threading;
using OpenQA.Selenium;

namespace E_Arşiv_Fatura
{
    class Wait
    {
        public bool TryFindByXPath(int sure, string xPath)
        {
            bool sonuc = false;

            for (int i = 0; i < sure * 100; i++)
            {
                try
                {
                    loginScreenForm.driver.FindElement(By.XPath(xPath));
                    sonuc = true;
                    break;
                }

                catch (Exception)
                {
                }
                Thread.Sleep(1);
            }

            return sonuc;
        }

        public bool TryFindByCSSSelector(int sure, string cSSSelector)
        {
            bool sonuc = false;

            for (int i = 0; i < sure * 100; i++)
            {
                try
                {
                    loginScreenForm.driver.FindElement(By.CssSelector(cSSSelector));
                    sonuc = true;
                    break;
                }

                catch (Exception)
                {
                }
                Thread.Sleep(1);
            }
            return sonuc;
        }

        public bool TryGoToUrl(int sure, string url)
        {
            bool sonuc = false;
            for (int i = 0; i < sure * 100; i++)
            {
                try
                {
                    loginScreenForm.driver.Navigate().GoToUrl(url);
                    sonuc = true;
                    break;
                }

                catch (Exception)
                {

                }
                Thread.Sleep(1);
            }
            return sonuc;
        }
    }
}
