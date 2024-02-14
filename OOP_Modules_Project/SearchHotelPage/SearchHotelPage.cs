using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Modules_Project
{
    public class SearchHotelPage : BaseClass
    {
        BaseClass baseclass = new BaseClass();
        By location = By.Id("location");
        By hotel = By.Id("hotels");
        By Roomtype = By.Id("room_type");
        By RoomNos = By.Id("room_nos");
        By DateIn = By.Id("datepick_in");
        By DateOut = By.Id("datepick_out"); 
        By AdultRoom = By.Id("adult_room");
        By Searchbutton = By.Id("Submit");

        public void SearchHotel(string[] SearchInput) 
        {
            baseclass.Logs("Search Hotel");
            baseclass.SelectDropDown(location, SearchInput[0],"select Location");
            baseclass.SelectDropDown(hotel, SearchInput[1], "select hotel");
            baseclass.SelectDropDown(Roomtype, SearchInput[2], "select roomtype");
            baseclass.SelectDropDown(RoomNos, SearchInput[3], "select room numbers");
            baseclass.SelectDropDown(AdultRoom, SearchInput[4], "select adult room");
            baseclass.Click(Searchbutton, "Search Hotel");
        }        
        
        
        //public void Itinerary() 
        //{
        //    driver.FindElement(By.CssSelector("tr:nth-child(1) td:nth-child(2).welcome_menu a:nth-child(3)")).Click();
        //}

    }
}
