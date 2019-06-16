using CompanyWebsitePageFactory.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
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

            IWebDriver driver = new ChromeDriver();
            //driver.Url = "https://www.linklaters.com/";
            driver.Url = ConfigurationManager.AppSettings["URL"];

            var homePage = new HomePage(driver);
            homePage.ClickOnNavInsights();

            var insights = new Insights(driver);
            insights.SearchAndReset();

        }
    }
}
