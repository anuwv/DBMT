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
            Thread.Sleep(6000);
                
            IWebElement GoTohomeButton = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/header/div/div[1]/button/div"));
            GoTohomeButton.Click();

            // WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"root\"]/div/nav/div/div/div[2]/div/ul[2]/div/div[2]/p", 23);
            Thread.Sleep(7000);
            IWebElement GoToEvSection = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/nav/div/div/div[2]/div/ul[2]/div[1]/div[2]/h5"));
            GoToEvSection.Click();//*[@id="root"]/div/nav/div/div/div[2]/div/ul[2]/div/div[2]

            //WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"root\"]/div/nav/div/div/div[2]/div/ul[2]/div[2]/div/div/div/a[2]/div[2]/p", 23);

            //IWebElement GoToEvForm = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/nav/div/div/div[2]/div/ul[2]/div[2]/div/div/div/a[2]/div[2]/p"));
            //GoToEvForm.Click();//*[@id="root"]/div/nav/div/div/div[2]/div/ul[2]/div[2]/div/div/div/a[1]/div[2]

            Thread.Sleep(6000);
            IWebElement EvList = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/nav/div/div/div[2]/div/ul[2]/div[2]/div/div/div/a[1]/div[2]/h5"));
            EvList.Click();
        }

       
    }
}
