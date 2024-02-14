using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Modules_Project
{
    public class HotelBookingPage : BaseClass
    {
        
        BaseClass baseclass = new BaseClass();
        By firstname = By.Id("first_name");
        By lastname = By.Id("last_name");
        By address = By.Id("address");
        By cc_no = By.Id("cc_num");
        By cc_type = By.Id("cc_type");
        By cc_exp_mnth = By.Id("cc_exp_month");
        By cc_exp_year = By.Id("cc_exp_year");
        By cvv_No = By.Id("cc_cvv");
        By bookbtn = By.Id("book_now");
        public void Hotel_Booking(String[] bookingInputs)
        {
            baseclass.Logs("Hotel Booking");
            baseclass.write(firstname, bookingInputs[0],"Enter First Name");
            baseclass.write(lastname, bookingInputs[1], "Enter last Name");
            baseclass.write(address, bookingInputs[2], "Enter address");
            baseclass.write(cc_no, bookingInputs[3], "Enter Credit Card Number");
            baseclass.SelectDropDown(cc_type, bookingInputs[4], "select card type");
            baseclass.SelectDropDown(cc_exp_mnth, bookingInputs[5], "select exp month");
            baseclass.SelectDropDown(cc_exp_year, bookingInputs[6], "select exp year");
            baseclass.write(cvv_No, bookingInputs[7], "Enter CVV Number");
            baseclass.Click(bookbtn, "book");
        }
    }
}
