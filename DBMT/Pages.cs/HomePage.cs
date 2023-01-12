using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBMT.Utilities;
using OpenQA.Selenium;

namespace DBMT.Pages.cs
{
    public class HomePage
    {
        public void GoToEvSection(IWebDriver driver)
        {
            Thread.Sleep(3000);
                
            //IWebElement GoTohomeButton = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/header/div/div[1]/button/div"));
            //GoTohomeButton.Click();

            // WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"root\"]/div/nav/div/div/div[2]/div/ul[2]/div/div[2]/p", 23);
            Thread.Sleep(4000);
            IWebElement GoToEvSection = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/nav/div/div/div[2]/div/ul[2]/div/div[2]"));
            GoToEvSection.Click();

            //WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"root\"]/div/nav/div/div/div[2]/div/ul[2]/div[2]/div/div/div/a[2]/div[2]/p", 23);

            //IWebElement GoToEvForm = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/nav/div/div/div[2]/div/ul[2]/div[2]/div/div/div/a[2]/div[2]/p"));
            //GoToEvForm.Click();//*[@id="root"]/div/nav/div/div/div[2]/div/ul[2]/div[2]/div/div/div/a[1]/div[2]

            Thread.Sleep(3000);
            IWebElement EvList = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/nav/div/div/div[2]/div/ul[2]/div[2]/div/div/div/a[1]/div[2]"));
            EvList.Click();
        }

       
    }
}
