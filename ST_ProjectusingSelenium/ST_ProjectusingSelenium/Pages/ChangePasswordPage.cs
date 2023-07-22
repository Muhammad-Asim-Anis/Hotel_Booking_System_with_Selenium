using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_ProjectusingSelenium
{
     class ChangePasswordPage : BasePage
    {
        By CurrentPasswordField = By.Id("current_pass"); 
        By newpasswordfield = By.Id("new_password");  
        By ConfirmPasswordField = By.Id("re_password");
        By ChangePasswordbtn = By.Id("Submit");
        By ChangePasswordlink = By.LinkText("Change Password");

        public void ChangePassword(String currentpass,String newpass)
        {
            driver.FindElement(ChangePasswordlink).Click();
            driver.FindElement(CurrentPasswordField).SendKeys(currentpass);
            driver.FindElement(newpasswordfield).SendKeys(newpass);
            driver.FindElement(ConfirmPasswordField).SendKeys(newpass);
            driver.FindElement(ChangePasswordbtn).Click();
        }
    }
}
