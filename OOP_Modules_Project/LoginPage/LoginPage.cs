using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_Modules_Project
{
    public class LoginPage : BaseClass
    {
        SearchHotelPage searchhotelpage = new SearchHotelPage();
        SelectHotelPage select_hotel = new SelectHotelPage();
        HotelBookingPage hotelbooking = new HotelBookingPage();
        BookingConfirmation BookingConfirmation = new BookingConfirmation();

        By usernametxt = By.Id("username");
        By passtxt = By.Id("password");
        By Login_button = By.Id("login");
        By Assert_txt = By.ClassName("welcome_menu");
        
        BaseClass baseclass = new BaseClass();
        ExtentReport extentreport = new ExtentReport();
        //valid and invalid
        public void valid_Login(string url, string user, string pass) 
        {
            baseclass.Logs("Valid Login");
            baseclass.seleniumInt("chrome");
            baseclass.Maximize_Window();
            driver.Url = url;
            baseclass.write(usernametxt, user,"Enter username");
            baseclass.write(passtxt, pass, "Enter password");
            baseclass.Click(Login_button,"Login");
            Thread.Sleep(3000);
            baseclass.Assertion(Assert_txt, "Welcome to Adactin Group of Hotels");
            if (asert == true) 
            {
                string[] SearchInput = new string[] { "Paris", "Hotel Creek", "Deluxe", "2 - Two", "2 - Two", "14/01/2024", "16/01/2024"};
                searchhotelpage.SearchHotel(SearchInput);
                select_hotel.SelectHotel();

                string[] bookingInputs = new string[] { "Hamza", "Ali", "Karachi Pakistan", "1234567891234567", "VISA", "June", "2027", "2345" };
                hotelbooking.Hotel_Booking(bookingInputs);
                BookingConfirmation.Hotel_Booking_Confirmation  ();
            }
            baseclass.flush();
            baseclass.seleniumClose();
        }
        
        public void Invalid_Login(string url, string user, string pass)
        {
            baseclass.Logs("Invalid Login");
            baseclass.seleniumInt("chrome");
            baseclass.Maximize_Window();
            driver.Url = url;
            baseclass.write(usernametxt, user,"Enter username");
            baseclass.write(passtxt, pass, "Enter password");
            baseclass.Click(Login_button, "Login");
            extentreport.TakeScreenshot(driver, Status.Fail, "Login");
            Thread.Sleep(2000);
            baseclass.Assertion(Assert_txt, "to Adactin Group of Hotels");
            if(asert == false) 
            {
                baseclass.flush();
            }
            baseclass.seleniumClose();
        }
    }
}
