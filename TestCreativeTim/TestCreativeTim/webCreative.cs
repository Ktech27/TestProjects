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
            
        }

    }
}
