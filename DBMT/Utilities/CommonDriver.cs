using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBMT.Pages.cs;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace DBMT.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;

        [SetUp]
        public void LoginActions()
        {
            driver = new ChromeDriver();

            LoginPage loginpageObj = new LoginPage();
            loginpageObj.LoginSteps(driver);

            HomePage homepageObj = new HomePage();
            homepageObj.GoToEvSection(driver);

        }
        public void CloseTestRun()
        {
            driver.Quit();
        }
        
       
    }
}