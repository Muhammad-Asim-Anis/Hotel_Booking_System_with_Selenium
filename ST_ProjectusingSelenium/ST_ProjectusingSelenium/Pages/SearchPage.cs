using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_ProjectusingSelenium
{
     class SearchPage : BasePage
    {
        By LocationSelector = By.Name("location");
        By HotelsSelector = By.Name("hotels");
        By RoomTypeSelector = By.Name("room_type");
        By NumberofRoomsSelector = By.Name("room_nos");
        By AdultsPerRoomSelector = By.Name("adult_room");
        By ChildrenPerRoomSelector = By.Name("child_room");
        By CheckInDateTextBox = By.Id("datepick_in");
        By checkOutDateTextBox = By.Id("datepick_out");
        By Searchbtn = By.Name("Submit");
        By Resetbtn = By.Name("Reset");
        public void SearchHotel(String location,String hotel,String roomtype,String checkindate,String checkoutdate,String numofrooms,String adultsperroom,String childperroom)
        {
            driver.FindElement(LocationSelector).SendKeys(location);
            driver.FindElement(HotelsSelector).SendKeys(hotel);
            driver.FindElement(RoomTypeSelector).SendKeys(roomtype);
            driver.FindElement(NumberofRoomsSelector).SendKeys(numofrooms);
            driver.FindElement(CheckInDateTextBox).SendKeys(checkindate);
            driver.FindElement(checkOutDateTextBox).SendKeys(checkoutdate);
            driver.FindElement(AdultsPerRoomSelector).SendKeys(adultsperroom);
            driver.FindElement(ChildrenPerRoomSelector).SendKeys(childperroom);

            driver.FindElement(Searchbtn).Click();
        }

        public void SearchHotelAndReset(String location, String hotel, String roomtype, String numofrooms, String checkindate, String checkoutdate, String adultsperroom, String childperroom)
        {
            driver.FindElement(LocationSelector).SendKeys(location);
            driver.FindElement(HotelsSelector).SendKeys(hotel);
            driver.FindElement(RoomTypeSelector).SendKeys(roomtype);
            driver.FindElement(NumberofRoomsSelector).SendKeys(numofrooms);
            driver.FindElement(CheckInDateTextBox).SendKeys(checkindate);
            driver.FindElement(checkOutDateTextBox).SendKeys(checkoutdate);
            driver.FindElement(AdultsPerRoomSelector).SendKeys(adultsperroom);
            driver.FindElement(ChildrenPerRoomSelector).SendKeys(childperroom);

            driver.FindElement(Resetbtn).Click();
        }
    }
}
