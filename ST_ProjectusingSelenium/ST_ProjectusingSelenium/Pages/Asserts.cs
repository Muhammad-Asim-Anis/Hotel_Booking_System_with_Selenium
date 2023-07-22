using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_ProjectusingSelenium
{
    class Asserts : BasePage
    {
        public void AssertCheck(String assertcheck,String AssertText,String AssertState)
        {
            By parameter = By.ClassName(assertcheck);
            String actualtext = driver.FindElement(parameter).Text;
            Assert.AreEqual(AssertText,
                actualtext, AssertState);
        }
    }
}
