using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBMT.Pages.cs;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using DBMT.Utilities;

namespace DBMT.Tests.cs
{
    [TestFixture]
    public class EvTests : CommonDriver
    {
        [Test]
        public void CreateEvTest()
        {

            EvForm evformObj = new EvForm();
            evformObj.CreateEvForm(driver);
        }
        [Test]
        public void ViewEvTest()
        {
            EvForm evformObj = new EvForm();
            evformObj.ViewEvForm(driver);
        }

        [Test]
        public void EdiEvTest()
        {
            EvForm evformObj = new EvForm();
            evformObj.EditEvForm(driver);
        }

        [Test]
        public void DeleteEvTest()
        {
            EvForm evformObj = new EvForm();
            evformObj.DeleteEvForm(driver);
        }

       


    }

}
