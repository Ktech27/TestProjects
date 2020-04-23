using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace TestProjectAndy
{
    class Automatic
    {
        IWebDriver driver;


        public void Start()
        {

            driver = new ChromeDriver(@"C:\Users\Katherin\Documents\Testing");
            driver.Url = "https://pricerwebapp.azurewebsites.net/product.html";

        }

        public void Createproduct()
        {
            IWebElement Create = driver.FindElement(By.Id("btnCreate"));
            IWebElement Productid = driver.FindElement(By.Id("txtProductID"));
            IWebElement description = driver.FindElement(By.Id("txtDescription"));
            IWebElement productName = driver.FindElement(By.Id("txtProductName"));
            IWebElement productURL = driver.FindElement(By.Id("txtURL"));
            IWebElement price = driver.FindElement(By.Id("txtPriceDollar"));
            IWebElement SKU = driver.FindElement(By.Id("txtSKU"));
            IWebElement Pricecents = driver.FindElement(By.Id("txtPriceCents"));
            IWebElement model = driver.FindElement(By.Id("txtModel"));
            IWebElement save = driver.FindElement(By.Id("btnCreatProduct"));


            Create.Click();
            Productid.SendKeys("123");
            description.SendKeys("Cream to skin");
            productName.SendKeys("Cetaphil");
            productURL.SendKeys("www.walmart.ca");
            price.SendKeys("15");
            SKU.SendKeys("TEST");
            Pricecents.SendKeys("56");
            model.SendKeys("bla");
            save.Click();


            driver.Close();

            


        }

    }
}

