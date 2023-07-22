using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_ProjectusingSelenium
{
    class SelectHotelPage : BasePage
    {
        By HotelSelectCheckbox = By.Id("radiobutton_0");
        By Continuebtn = By.Id("continue");
        By Cancelbtn = By.Id("cancel");

        public void SelectHotel()
        {
            driver.FindElement(HotelSelectCheckbox).Click();
            driver.FindElement(Continuebtn).Click();  
        }

        public void SelectHotelCancel()
        {
            driver.FindElement(HotelSelectCheckbox).Click();
            driver.FindElement(Cancelbtn).Click();
        }



    }
}
