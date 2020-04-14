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
        
        
        }

    }
}
