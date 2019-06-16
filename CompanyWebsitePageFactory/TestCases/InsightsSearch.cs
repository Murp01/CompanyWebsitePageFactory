using CompanyWebsitePageFactory.PageObjects;
using CompanyWebsitePageFactory.WrapperFactory;
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
            BrowserFactory.InitBrowser("Firefox");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);

            Page.Home.ClickOnNavInsights();

            Page.Insights.SearchAndReset();

            BrowserFactory.CloseAllDrivers();

        }
    }
}
