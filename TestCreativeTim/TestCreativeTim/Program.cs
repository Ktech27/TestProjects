using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCreativeTim
{
    class Program
    {
        static void Main(string[] args)
        {
            webCreative webtest2 = new webCreative();
            webtest2.startBrower();
            webtest2.maketest();
            System.Threading.Thread.Sleep(50000);
        }
    }
}
