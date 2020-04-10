using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace WikiTest
{
    class WebTest
    {
        IWebDriver webDriver; // variable of type IWebDriver

        public void startBrowser()    // Initial line void is not return information
        {
            webDriver = new ChromeDriver(@"C:\Users\Katherin\Documents\Testing");   
        }

        public void makeTest()

         {
            webDriver.Url = "https://www.wikipedia.org/";
            //webDriver.FindElement(By.XPath("/html/body/div[3]/form/fieldset/div/input")).SendKeys("COVID19" + Keys.Enter);
            webDriver.FindElement(By.Id("searchInput")).SendKeys("COVID19"+Keys.Enter);  




        }

        public void closeBrowser()

        {
            webDriver.Close();
        
        }




    }
}
