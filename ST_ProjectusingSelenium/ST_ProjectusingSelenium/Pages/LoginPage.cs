using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ST_ProjectusingSelenium
{
     class LoginPage : BasePage
    {
        By UsernameTextBox = By.Id("username");
        By PasswordTextBox = By.Id("password");
        By EmailTextBox = By.Id("emailadd_recovery");
        By EmailSendbtn = By.Id("Submit");
        By ForgetPasswordlink = By.ClassName("login_forgot");
        By loginbtn = By.Id("login");
        By LogoutLink = By.LinkText("Logout");
        By AgainLoginLink = By.LinkText("Click here to login again");

        public void Login(String url,String username,String password)
        {
            driver.Url = url;
            driver.FindElement(UsernameTextBox).SendKeys(username);
            driver.FindElement(PasswordTextBox).SendKeys(password);
            driver.FindElement(loginbtn).Click();
        }
        public void logout()
        {
            driver.FindElement(LogoutLink).Click();
            driver.FindElement(AgainLoginLink).Click();

        }
        public void forgetpassword(String url,String recoveryemail)
        {
            driver.Url = url;
            driver.FindElement(ForgetPasswordlink).Click();
            driver.FindElement(EmailTextBox).SendKeys(recoveryemail);
            driver.FindElement(EmailSendbtn).Click();
            
        }
    }
}
