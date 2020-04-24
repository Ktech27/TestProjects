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
        int IDGenerator = 140;
        string SKUNumber = "SKU: ";

        public void Start()
        {
            // Start the browser
            driver = new ChromeDriver(@"C:\Users\Katherin\Documents\Testing");
            // choose the URL we want to test
            driver.Url = "https://pricerwebapp.azurewebsites.net/product.html";

        }

        // Test option create product
        public void Createproduct()
        {

            // For statement for sending more than 1 record

            string textToSend = "";
            for (int i = 0; i <= 5; i++)
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
                textToSend = IDGenerator.ToString();
                // ID Product We are calling our method IDGenerator
                Productid.SendKeys(textToSend);
                description.SendKeys("Cream to skin");
                productName.SendKeys("Cetaphil");
                productURL.SendKeys("www.walmart.ca");
                price.SendKeys("15");
                // Sending the information in each line
                textToSend = SKUNumber + IDGenerator.ToString();
                SKU.SendKeys(textToSend);
                Pricecents.SendKeys("56");
                model.SendKeys("bla");
                save.Click();
                System.Threading.Thread.Sleep(2000);

                IDGenerator++;
            }

            System.Threading.Thread.Sleep(2000);

            driver.Close();




        }

    }
}

