using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace StartSel
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver;
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://google.com.ua");
        }
    }
}
