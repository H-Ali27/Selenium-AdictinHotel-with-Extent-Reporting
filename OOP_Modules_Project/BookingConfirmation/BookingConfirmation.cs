using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Modules_Project
{
    public class BookingConfirmation : BaseClass
    {
        BaseClass baseclass = new BaseClass();
        
        By logout = By.XPath("/html/body/table[2]/tbody/tr[1]/td[2]/a[4]");
        //By logout = By.Id("logout");


        public void Hotel_Booking_Confirmation() 
        {
            baseclass.Logs("Logout from session");
            baseclass.Click(logout, "Logout");
        }
        //public void My_Itineray() 
        //{
        //    driver.FindElement(By.Id("my_itinerary")).Click();
        //}
    }
}
