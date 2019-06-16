using CompanyWebsitePageFactory.TestDataAccess;
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

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Reset search')]")]
        [CacheLookup]
        public IWebElement Btn_Reset { get; set; }

        //public Insights(IWebDriver driver)
        //{
        //    this.driver = driver;
        //    PageFactory.InitElements(driver, this);
        //}

        public void SearchAndReset()
        {
            Input_Name.SendKeys("Linklaters");
            Btn_Reset.Click();
        }

        //public void SearchAndResetExcel(String testName)
        //{
        //    var userData = ExcelDataAccess.GetTestData(testName);
        //    Input_Name.SendKeys(userData.SearchTerm);
        //    Btn_Reset.Click();
        //}
        //This method I tried to implement integration with Excel but failed.  Comment
        //code can be returned to when I tackle this again.


    }
}

