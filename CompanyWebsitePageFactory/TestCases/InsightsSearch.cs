using CompanyWebsitePageFactory.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebsitePageFactory
{
    class InsightsSearch
    {

        [Test]
        public void Test()
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.linklaters.com/";

            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.PNav_Insights.Click();

        }
    }
}
