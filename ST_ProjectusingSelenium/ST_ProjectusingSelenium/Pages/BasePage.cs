using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_ProjectusingSelenium
{
    class BasePage
    {
       public static IWebDriver driver;

        public static IWebDriver driverInit()
        {
            IWebDriver chromedriver = new ChromeDriver();
            driver = chromedriver;
            return driver;
        }
    }
}
