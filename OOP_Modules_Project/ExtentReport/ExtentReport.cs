using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition.Primitives;

namespace OOP_Modules_Project
{
    public class ExtentReport 
    {
        
            public static ExtentReports report;
            public static ExtentTest parent;
            public static ExtentTest childreport;
            public static string dirpath;

            public void LogReport(string testcase)
            {
                report = new ExtentReports();

                dirpath = @"..\..\TestExecutionReports\" + '_' + testcase;

                ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(dirpath);

                htmlReporter.Config.Theme = Theme.Standard;

                report.AttachReporter(htmlReporter);
            }

            public void TakeScreenshot(IWebDriver driver, Status status, string stepDetail)
            {

                string path = @"D:\copy\OOP_Modules_Project\OOP_Modules_Project\bin\Screenshot\" + "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                Screenshot image_username = ((ITakesScreenshot)driver).GetScreenshot();
                image_username.SaveAsFile(path + ".png", ScreenshotImageFormat.Png);
                ExtentReport.childreport.Log(status, stepDetail, MediaEntityBuilder
                    .CreateScreenCaptureFromPath(path + ".png").Build());
            }
        
        public void flush()
        {
            report.Flush();
        }
    }
}
