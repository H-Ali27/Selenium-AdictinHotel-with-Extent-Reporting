using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Modules_Project
{
    public class BaseClass : ExtentReport
    {
        public static IWebDriver driver;
        public static bool asert;

        ExtentReport extentreport = new ExtentReport();
        public void seleniumInt(string browser) 
        {
            SelectBrowser(browser);
        }
        public void Maximize_Window() 
        {
            driver.Manage().Window.Maximize();
        }
        public void Logs(string node) 
        {
            childreport = parent.CreateNode(node);
        }
        public void write(By by, string value, string detail) 
        {
            try
            {
                driver.FindElement(by).SendKeys(value);
                extentreport.TakeScreenshot(driver, Status.Pass, detail);
            }
            catch (Exception ex)
            {
                extentreport.TakeScreenshot(driver, Status.Fail, "Entry Fail" + ex);
            }
        }
        public void Click(By by, string detail) 
        {
            driver.FindElement(by).Click();
            extentreport.TakeScreenshot(driver, Status.Pass, detail);
        }

        //public void Text(By by,string Exp_Text) 
        //{
        //    string actualtext = driver.FindElement(by).Text;
        //    Assert.AreEqual(Exp_Text, actualtext);
        //}


        public void Assertion( By by, string Exp_Text)
        {
            string actualtext = driver.FindElement(by).Text;

            if (actualtext == Exp_Text)
            {
                Assert.AreEqual(Exp_Text, actualtext);
                asert = true;
            }
            else if(actualtext != Exp_Text)
            {
                Assert.AreNotEqual(Exp_Text, actualtext);
                asert = false;
            } 
        }
        
        public void SelectBrowser(string browser) 
        {
            browser.ToLower();
            if (browser == "chrome") 
            {
                driver = new ChromeDriver();
            }
            else if(browser == "edge") 
            {
                driver = new EdgeDriver();
            }
            else if(browser == "firefox") 
            {
                driver = new FirefoxDriver();
            }
        }

        public void SelectDropDown(By by, string value,string detail) 
        {
            var dropdown = driver.FindElement(by);
            var selectdropdown = new SelectElement(dropdown);
            selectdropdown.SelectByText(value);
            extentreport.TakeScreenshot(driver, Status.Pass, detail);
        }
        public void seleniumClose() 
        {
            driver.Close();
            driver.Quit();
        }
    }
}
