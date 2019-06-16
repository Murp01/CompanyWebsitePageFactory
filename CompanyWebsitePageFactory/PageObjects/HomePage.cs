﻿using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebsitePageFactory.PageObjects
{
    class HomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.ClassName, Using = "icon-search")]
        public IWebElement PNav_Insights { get; set; }
    }
}
