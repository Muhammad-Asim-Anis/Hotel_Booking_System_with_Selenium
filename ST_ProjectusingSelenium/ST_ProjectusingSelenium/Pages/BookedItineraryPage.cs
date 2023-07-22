using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_ProjectusingSelenium
{
    class BookedItineraryPage : BasePage
    {
        By BookHotelCheckBox = By.XPath("//*[@id=\"booked_form\"]/table/tbody/tr[2]/td/table/tbody/tr[2]/td[1]/input");
        By CancelSelectedBookHotelbtn = By.Name("cancelall");
        By OrderidField = By.XPath("/html/body/table[2]/tbody/tr[2]/td/form/table/tbody/tr[2]/td/table/tbody/tr[2]/td[2]/input");
        String orderidcheck = "";
        bool result = false;
        public void validateBooking(String orderid)
        {
            driver.FindElement(BookHotelCheckBox).Click();
            orderidcheck = driver.FindElement(OrderidField).GetAttribute("value");
           result = Asserts.Equals(orderidcheck, orderid);
           if(result)
            {
                driver.FindElement(CancelSelectedBookHotelbtn).Click();
                driver.SwitchTo().Alert().Accept();
            }
        }

    }
}
