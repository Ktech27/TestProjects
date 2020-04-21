using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace TaskCreativeTim
{
    class TaskCreative
    {

        IWebDriver Driver;

        public void Startbrowser()
        {
            Driver = new ChromeDriver(@"C:\Users\Katherin\Documents\Testing");
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20000000000);

            //Driver.Manage().Timeouts().ImplicitWait.

        }

        public void BodyTest()
        {

            Driver.Url = "https://demos.creative-tim.com/vue-white-dashboard-pro/#/";
            IWebElement Listview = Driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[2]/div/ul/li[4]/a/p"));
            Listview.Click();
            System.Threading.Thread.Sleep(500);

            // second element 

            System.Threading.Thread.Sleep(500);

            IWebElement test2 = Driver.FindElement(By.XPath("//span[contains(text(),'Regular Forms')]"));
            test2.Click();

            System.Threading.Thread.Sleep(500);


            // Add text in the fields

  

            //Get the Web Element corresponding to the field Business Email (Textfield)

         

            IWebElement Email = Driver.FindElement(By.XPath("//div[@class='form-group has-label']//input[@placeholder='Enter email']"));

            //Get the Web Element corresponding to the Password Field 

          

            IWebElement Password = Driver.FindElement(By.XPath("//div[@class='form-group has-label']//input[@placeholder='Password']"));

            //Find the Sign me in button

            IWebElement Login = Driver.FindElement(By.XPath("//button[contains(text(),'Submit')]"));
           System.Threading.Thread.Sleep(500);
            Email.SendKeys("@kalexa");
           System.Threading.Thread.Sleep(500);
            Password.SendKeys("@abc123");
           System.Threading.Thread.Sleep(500);
            Login.Click();

           System.Threading.Thread.Sleep(00);
           

            // click to checkbox

            IWebElement Checkbox1 = Driver.FindElement(By.XPath("//label[contains(text(),'First checkbox')]"));
            
            // click in the second checkbox

            IWebElement Checkbox2 = Driver.FindElement(By.XPath("//label[contains(text(),'Second checkbox')]"));

            System.Threading.Thread.Sleep(800);
            Checkbox1.Click();
            System.Threading.Thread.Sleep(800);
            Checkbox2.Click();

            // Radio Button 


           IWebElement Radio2 = Driver.FindElement(By.XPath("//label[contains(text(),'Second Radio')]"));

            Radio2.Click();
            System.Threading.Thread.Sleep(500);
            IWebElement Radio1 = Driver.FindElement(By.XPath("//label[contains(text(),'First Radio')]"));
            Radio1.Click();
            System.Threading.Thread.Sleep(500);





            

            Driver.Close();
        }

    }
}

