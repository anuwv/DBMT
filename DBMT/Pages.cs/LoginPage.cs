using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using DBMT.Utilities;

namespace DBMT.Pages.cs
{
   public class LoginPage : CommonDriver
    {
        public void LoginSteps(IWebDriver driver)
        {
            //IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://localhost:3001/");

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"root\"]/div[1]/div/div/div/div/div/div/div/div[3]/form/div[3]/div/button", 3);
            //IWebElement UserNameTextBox = driver.FindElement(By.XPath("//*[@id=\"outlined-adornment-username-login\"]"));
            //UserNameTextBox.SendKeys("wevolt");
            //IWebElement PasswordTextBox = driver.FindElement(By.XPath("//*[@id=\"outlined-adornment-password-login\"]"));
            //PasswordTextBox.SendKeys("wevolt@123");
            IWebElement SignIn = driver.FindElement(By.XPath("//*[@id=\"root\"]/div[1]/div/div/div/div/div/div/div/div[3]/form/div[3]/div/button"));
            SignIn.Click();
        }
    }
}
