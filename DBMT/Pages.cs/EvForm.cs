using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBMT.Utilities;
using OpenQA.Selenium;

namespace DBMT.Pages.cs
{
    public class EvForm
    {
        public void CreateEvForm(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement AddNewEv = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/main/div[2]/div[1]/div[2]/a"));
            AddNewEv.Click();

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"outlined-adornment-manufacturer-login\"]", 20);
            IWebElement GoToManufacturer = driver.FindElement(By.XPath("//*[@id=\"outlined-adornment-manufacturer-login\"]"));
            GoToManufacturer.SendKeys("Audi ");

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"outlined-adornment-model-login\"]", 23);
            IWebElement GoToModel = driver.FindElement(By.XPath("//*[@id=\"outlined-adornment-model-login\"]"));
            GoToModel.SendKeys("Audi ");

            IWebElement WlTPrange = driver.FindElement(By.XPath("//*[@id=\"outlined-adornment-range-login\"]"));
            WlTPrange.SendKeys("336");

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"outlined-adornment-sizeClass-login\"]", 23);
            IWebElement SizeClass = driver.FindElement(By.XPath("//*[@id=\"outlined-adornment-sizeClass-login\"]"));
            SizeClass.SendKeys("LSUV");

            IWebElement BatterySize = driver.FindElement(By.XPath("//*[@id=\"outlined-adornment-batterySize-login\"]"));
            BatterySize.SendKeys("71");
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"outlined-adornment-maxChargeAC-login\"]", 23);
            IWebElement MaxChargerateAC = driver.FindElement(By.XPath("//*[@id=\"outlined-adornment-maxChargeAC-login\"]"));
            MaxChargerateAC.SendKeys("11");

            IWebElement MaxchargerateDC = driver.FindElement(By.XPath("//*[@id=\"outlined-adornment-maxChargeDC-login\"]"));
            MaxchargerateDC.SendKeys("150");
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"outlined-adornment-chargePort-login\"]", 23);
            IWebElement ChargerType = driver.FindElement(By.XPath("//*[@id=\"outlined-adornment-chargePort-login\"]"));
            ChargerType.SendKeys("CCS2");

            IWebElement PlugType = driver.FindElement(By.XPath("//*[@id=\"outlined-adornment-plugType-login\"]"));
            PlugType.SendKeys("type 2 AC ");

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"outlined-adornment-towRateBraked-login\"]", 23);
            IWebElement Braked = driver.FindElement(By.XPath("//*[@id=\"outlined-adornment-towRateBraked-login\"]"));
            Braked.SendKeys("750");

            IWebElement UnBraked = driver.FindElement(By.XPath("//*[@id=\"outlined-adornment-towRateUnBraked-login\"]"));
            UnBraked.SendKeys("1800");

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"root\"]/div/main/div[2]/div[2]/form/div[3]/button", 23);
            IWebElement SaveButton = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/main/div[2]/div[2]/form/div[3]/button"));
            SaveButton.Click();
        }

        public void ViewEvForm(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement GoTohomeButton = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/header/div/div[1]/button"));
            GoTohomeButton.Click();

            // WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"root\"]/div/nav/div/div/div[2]/div/ul[2]/div/div[2]/p", 3);

            //IWebElement GoToEvSection = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/nav/div/div/div[2]/div/ul[2]/div/div[2]/p"));
            //GoToEvSection.Click();
            //WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"root\"]/div/nav/div/div/div[2]/div/ul[2]/div[2]/div/div/div/a[2]/div[2]/p", 3);

            //IWebElement GoToEvForm = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/nav/div/div/div[2]/div/ul[2]/div[2]/div/div/div/a[2]/div[2]/p"));
            //GoToEvForm.Click();
            Thread.Sleep(2000);
            //IWebElement EvList = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/nav/div/div/div[2]/div/ul[2]/div[2]/div/div/div/a[1]/div[2]"));
            //EvList.Click();
            IWebElement GoToActions = driver.FindElement(By.XPath("//*[@id=\"action-menu-icon-99\"]"));
            GoToActions.Click();

            //WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"MUIDataTableBodyRow-06434022865823465-0\"]/td[12]/div[2]/div/a[1]/svg/path", 12);
            Thread.Sleep(3000);
            IWebElement GoToViewButton = driver.FindElement(By.XPath("//*[@id=\"action-menu-99\"]/div[3]/ul/a[2]/div[1]"));
            GoToViewButton.Click();
        }
        public void EditEvForm(IWebDriver driver)
        {
            //Thread.Sleep(4000);
            //IWebElement GoTohomeButton = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/header/div/div[1]/button/div"));
            //GoTohomeButton.Click();

            //Thread.Sleep(7000);
            ////IWebElement GoToEvSection = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/nav/div/div/div[2]/div/ul[2]/div[1]/svg"));
            ////GoToEvSection.Click();

            //WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"root\"]/div/nav/div/div/div[2]/div/ul[2]/div[2]/div/div/div/a[1]/div[2]/h5", 29);

            //IWebElement EvList = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/nav/div/div/div[2]/div/ul[2]/div[2]/div/div/div/a[1]/div[2]/h5"));
            //EvList.Click();

            //Thread.Sleep(6000);
            //IWebElement GoToRow = driver.FindElement(By.XPath("//*[@id=\"MUIDataTableBodyRow-021980235962757066-0\"]/td[1]/div[2]"));
            //GoToRow.Click();

            Thread.Sleep(3000);
            IWebElement GoToActions = driver.FindElement(By.XPath("//*[@id=\"action-menu-icon-99\"]"));
            GoToActions.Click();

            Thread.Sleep(5000);
            
            IWebElement GoToEditIcon = driver.FindElement(By.XPath("//*[@id=\"action-menu-99\"]/div[3]/ul/a[1]"));
            GoToEditIcon.Click();

            Thread.Sleep(7000);
            //WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"outlined-adornment-range-login\"]", 17);
            IWebElement EditWLTP = driver.FindElement(By.XPath("//*[@id=\"outlined-adornment-range-login\"]"));
            EditWLTP.Clear();
            EditWLTP.SendKeys("337");

            Thread.Sleep(2000);
            //WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"root\"]/div/main/div/div[2]/form/div[3]/button", 20);
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/main/div/div[2]/form/div[3]/button"));
            saveButton.Click();
        }
        public void DeleteEvForm(IWebDriver driver)
        {
            //IWebElement GoTohomeButton = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/header/div/div[1]/button/div"));
            //GoTohomeButton.Click();

            //Thread.Sleep(7000);
            ////IWebElement GoToEvSection = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/nav/div/div/div[2]/div/ul[2]/div/div[2]/p"));
            ////GoToEvSection.Click();

            //WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"root\"]/div/nav/div/div/div[2]/div/ul[2]/div[2]/div/div/div/a[1]/div[2]", 9);
            //Thread.Sleep(2000);
            //IWebElement EvList = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/nav/div/div/div[2]/div/ul[2]/div[2]/div/div/div/a[1]/div[2]"));
            //EvList.Click();
            //Thread.Sleep(2000);
            ////IWebElement GoToRow = driver.FindElement(By.XPath("//*[@id=\"MUIDataTableBodyRow-03887055798791743-0\"]"));
            ////GoToRow.Click();
            Thread.Sleep(4000);
            IWebElement GoToActions = driver.FindElement(By.XPath("//*[@id=\"action-menu-icon-99\"]"));
            GoToActions.Click();

            Thread.Sleep(3000);
            //WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"MUIDataTableBodyRow-03887055798791743-0\"]/td[12]/div[2]/div/button", 20);
            IWebElement GoToDelete = driver.FindElement(By.XPath("//*[@id=\"action-menu-99\"]/div[3]/ul/li/div[2]"));
            GoToDelete.Click();
            driver.SwitchTo().Alert().Accept();



        }
    }
}
