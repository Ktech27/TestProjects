using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace TestCreativeTim
{
    class webCreative
    {
        IWebDriver Driver;

        public void startBrower()
        {
            Driver = new ChromeDriver(@"C:\Users\Katherin\Documents\Testing");
        }

        public void maketest()
        { 
         
            
            Driver.Url = "https://demos.creative-tim.com/vue-white-dashboard-pro/#/";
           IWebElement Listview = Driver.FindElement(By.ClassName("caret"));
            Listview.Click();

            System.Threading.Thread.Sleep(500);

            // Second element

            Driver.FindElement(By.CssSelector("#app > div > div.wrapper > div.sidebar > div > ul > li:nth-child(2) > div > ul > li:nth-child(1) > a > span.sidebar-normal")).Click();

            System.Threading.Thread.Sleep(500);

            // Click Dashboard back return 

            //Driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/nav/div/div[2]/ul/li[1]/a")).Click();
            Driver.Navigate().Back();


            // Third Element click
            IWebElement Listview2 = Driver.FindElement(By.ClassName("caret"));
            Listview2.Click();
            System.Threading.Thread.Sleep(500);
            Driver.FindElement(By.CssSelector("div.content div.wrapper div.sidebar div.sidebar-wrapper.text-left ul.nav div:nth-child(2) ul.nav li:nth-child(2) a.nav-link > span.sidebar-normal")).Click();
            System.Threading.Thread.Sleep(500);

            // Scroll Down
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            //IWebElement element3 = Driver.FindElement(By.LinkText(""))
            // // Select element in this page
            IWebElement swich2 = Driver.FindElement(By.CssSelector("#app > div > div.wrapper > div.main-panel > div > div > div.col-lg-6.col-sm-6.text-center > div.card.card-contributions > div.card-footer.text-left > div > div:nth-child(2) > div > div > div > span.bootstrap-switch-handle-on"));
            js.ExecuteScript("arguments[0].scrollIntoView();", swich2);
            
            System.Threading.Thread.Sleep(500);

            IWebElement foo = Driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[4]/div/div/div[1]/div[2]/div[2]/div/div[2]/div/div/div/span[2]"));
            foo.Click();
            //swich2.Click();
            
            //IebElement swicth = Driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[4]/div/div/div[1]/div[2]/div[2]/div/div[2]/div/div/div/span[3]"));
            //swicth.Click();

            


            // Driver Return++
            //Driver.Navigate().Back();

          


        }

    }
}
