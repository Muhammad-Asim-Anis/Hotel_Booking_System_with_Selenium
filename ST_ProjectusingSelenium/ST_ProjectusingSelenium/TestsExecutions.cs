using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;

namespace ST_ProjectusingSelenium
{
    [TestClass]
    public class TestsExecutionClass
    {
        SearchPage search = new SearchPage();
        LoginPage login = new LoginPage();
        Asserts assert = new Asserts();
        SelectHotelPage selecthotel = new SelectHotelPage();
        BookHotelPage bookhotel = new BookHotelPage();
        BookedItineraryPage bookedItinerary = new BookedItineraryPage();
        ChangePasswordPage changePassword = new ChangePasswordPage();
        String orderid = "";
        String username = "Asim0032";
        String password = "8A43K5";
        [TestMethod]
        [TestCategory("SeleniumwithPOM"),TestCategory("Positive")]
        public void Loginwithvaildcredentials_001()
        {
            BasePage.driverInit();
            BasePage.driver.Manage().Window.Maximize();
            login.Login("https://adactinhotelapp.com/", username, password);
            assert.AssertCheck("welcome_menu", "Welcome to Adactin Group of Hotels", "Assertion Pass");  
            login.logout();
            BasePage.driver.Close();
        }
        [TestMethod]
        [TestCategory("SeleniumwithPOM"), TestCategory("Negative")]
        public void Loginwithinvalidcredentials_002()
        {
            BasePage.driverInit();
            BasePage.driver.Manage().Window.Maximize();
            login.Login("https://adactinhotelapp.com/", "AsimAnis0032", "ACV084");
            assert.AssertCheck("auth_error", "Invalid Login details or Your Password might have expired. Click here to reset your password", "Assertion Pass");
            BasePage.driver.Close();
        }
        [TestMethod]
        [TestCategory("SeleniumwithPOM"), TestCategory("Positive")]
        public void HotelRoomSearch_003()
        {
            BasePage.driverInit();
            BasePage.driver.Manage().Window.Maximize();
            login.Login("https://adactinhotelapp.com/", username, password);
            search.SearchHotel("Brisbane", "Hotel Sunshine", "Double", "27/05/2023", "29/05/2023", "3", "2", "3");
            assert.AssertCheck("login_title", "Select Hotel", "Assertion Pass");
            login.logout();
            BasePage.driver.Close();
        }
        [TestMethod]
        [TestCategory("SeleniumwithPOM"), TestCategory("Positive")]
        public void HotelRoomBooked_004()
        {
            BasePage.driverInit();
            BasePage.driver.Manage().Window.Maximize();
            login.Login("https://adactinhotelapp.com/", username, password);
            search.SearchHotel("Brisbane", "Hotel Sunshine", "Double", "27/05/2023", "29/05/2023", "3", "2", "3");
            selecthotel.SelectHotel();
            bookhotel.BookHotel("asim", "anis", " lotia chamber aiwan-e-tijarat road", "5425233430109903", "mastercard", "april", "2026", "123");
            orderid = bookhotel.BookHotelConfirmation();
            bookedItinerary.validateBooking(orderid);
            assert.AssertCheck("login_title", "Booked Itinerary", "Assertion Pass");
            login.logout();
            BasePage.driver.Close();
        }
        //[TestMethod]
        //[TestCategory("SeleniumwithPOM"), TestCategory("Positive")]
        //public void ChangePassword_005()
        //{
        //    BasePage.driverInit();
        //    BasePage.driver.Manage().Window.Maximize();
        //    login.Login("https://adactinhotelapp.com/", "Asim0032", "ACV084");
        //    changePassword.ChangePassword("Asim1234", "W844JM");
        //    assert.AssertCheck("reg_error", "Your Password is successfully updated!!!", "Assertion Pass");
        //    login.logout();
        //    BasePage.driver.Close();
        //}
        //[TestMethod]
        //[TestCategory("SeleniumwithPOM"), TestCategory("Positive")]
        //public void ForgetPassword_006()
        //{
        //    BasePage.driverInit();
        //    BasePage.driver.Manage().Window.Maximize();
        //    login.forgetpassword("https://adactinhotelapp.com/", "fa19bsse0032@maju.edu.pk");
        //    assert.AssertCheck("reg_success", "An email has been sent to your email address containing Username and Password. Please check your email.\r\n\r\nClick here to login", "Assertion Pass");
        //    BasePage.driver.Close();
        //}



    }
}
