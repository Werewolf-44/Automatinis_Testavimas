﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestsWithoutPOM
{
    public class GoogleTests
    {
        [Test]
        public void SearchGoogle()
        {
            //Arrange
            string expectedResults = "Hello World! - „Google“ paieška";

            //Acts
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com";

            IWebElement buttonDeclineCookies = driver.FindElement(By.XPath("//*[@id=\"W0wltc\"]"));
            buttonDeclineCookies.Click();

            IWebElement inputSearch = driver.FindElement(By.XPath("//*[@id=\"APjFqb\"]"));
            inputSearch.SendKeys("Hello World!");

            IWebElement buttonSearch = driver.FindElement(By.XPath("(//*[@name='btnK'])[2]"));
            buttonSearch.Click();

            string actualResult = driver.Title;

            driver.Quit();

            //Assert
            Assert.AreEqual(expectedResults, actualResult);
        }

    }
}
