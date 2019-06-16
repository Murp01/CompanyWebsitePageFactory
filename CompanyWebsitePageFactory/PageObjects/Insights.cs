using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebsitePageFactory.PageObjects
{
    class Insights
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Name']")][CacheLookup]
        public IWebElement Input_Name { get; set; }


    }
}

