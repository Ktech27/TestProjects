using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WikiTest
{
    class Program
    {
        static void Main(string[] args)
        {                       
            WebTest wTest = new WebTest();
            wTest.startBrowser();
            wTest.makeTest();
            System.Threading.Thread.Sleep(10000);
            wTest.closeBrowser();
        }
    }
}
