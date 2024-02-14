using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
    
namespace OOP_Modules_Project
{
    [TestClass]
    public class ExecutionClass : ExtentReport
    {
        LoginPage loginpage = new LoginPage();
        ExtentReport extentReport = new ExtentReport();
        
        [TestMethod]
        public void Execution_Class()
        {
            //loginPage
            extentReport.LogReport("Testing");
            parent = report.CreateTest("Simple Extent Report");
            loginpage.valid_Login("https://adactinhotelapp.com/index.php", "Testerusear1234", "53T338");
            //loginpage.Invalid_Login("https://adactinhotelapp.com/index.php", "Testerusears1234", "5338");d
            ////smoke flow bnan hai us k ander web ka flow dalna hai using systemtic code lkhna ha
 
        }
    }
}
