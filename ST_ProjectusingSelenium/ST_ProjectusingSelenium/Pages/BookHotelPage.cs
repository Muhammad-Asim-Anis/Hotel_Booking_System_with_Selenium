using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ST_ProjectusingSelenium
{
    class BookHotelPage : BasePage
    {
        
        By FirstNameField = By.Name("first_name");
        By LastNameField = By.Name("last_name");
        By BillingAddressField = By.Id("address");
        By CreditCardNumField = By.Id("cc_num");
        By CreditCardTypeSelector = By.Id("cc_type");
        By ExpiryDateMonthSelector = By.Id("cc_exp_month");
        By ExpiryDateYearSelector = By.Id("cc_exp_year");
        By CVVNumField = By.Id("cc_cvv");
        By Booknowbtn = By.Name("book_now");
        By Cancelbtn = By.Id("cancel");
        By OrderNoField = By.Name("order_no");
        By myItinerarybtn = By.Id("my_itinerary");
        String bookid = "";

        public void BookHotel(String FirstName,String LastName,String Address,String CC_Num,String 
            CC_type,String CC_exp_month,String CC_exp_year,String CC_CVV)
        {
            driver.FindElement(FirstNameField).SendKeys(FirstName);
            driver.FindElement(LastNameField).SendKeys(LastName);
            driver.FindElement(BillingAddressField).SendKeys(Address);
            driver.FindElement(CreditCardNumField).SendKeys(CC_Num);
            driver.FindElement(CreditCardTypeSelector).SendKeys(CC_type);
            driver.FindElement(ExpiryDateMonthSelector).SendKeys(CC_exp_month);
            driver.FindElement(ExpiryDateYearSelector).SendKeys(CC_exp_year);
            driver.FindElement(CVVNumField).SendKeys(CC_CVV);
            driver.FindElement(Booknowbtn).Click();
            Thread.Sleep(15000);
        }

        public void BookHotelCancel(String FirstName, String LastName, String Address, String CC_Num, String
            CC_type, String CC_exp_month, String CC_exp_year, String CC_CVV)
        {
            driver.FindElement(FirstNameField).SendKeys(FirstName);
            driver.FindElement(LastNameField).SendKeys(LastName);
            driver.FindElement(BillingAddressField).SendKeys(Address);
            driver.FindElement(CreditCardNumField).SendKeys(CC_Num);
            driver.FindElement(CreditCardTypeSelector).SendKeys(CC_type);
            driver.FindElement(ExpiryDateMonthSelector).SendKeys(CC_exp_month);
            driver.FindElement(ExpiryDateYearSelector).SendKeys(CC_exp_year);
            driver.FindElement(CVVNumField).SendKeys(CC_CVV);
            driver.FindElement(Cancelbtn).Click();
        }

        public String BookHotelConfirmation()
        {
            bookid = driver.FindElement(OrderNoField).GetAttribute("Value");
            driver.FindElement(myItinerarybtn).Click();
            return bookid;
        }
    }
}
