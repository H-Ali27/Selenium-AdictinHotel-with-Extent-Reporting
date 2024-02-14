using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Modules_Project
{
    public class SelectHotelPage : BaseClass
    {
        By selectbtn = By.Id("radiobutton_0");
        By continuebtn = By.Id("continue");

        BaseClass baseclass = new BaseClass();
        public void SelectHotel() 
        {
            baseclass.Logs("Select hotel");
            baseclass.Click(selectbtn, "Select hotel");
            baseclass.Click(continuebtn, "Continue...");
        }

    }
}
