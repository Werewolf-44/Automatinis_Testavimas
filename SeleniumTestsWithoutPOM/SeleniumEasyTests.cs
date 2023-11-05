using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestsWithoutPOM
{
    internal class SeleniumEasyTests
    {
        [Test]
        public void SingleInputFieldTest()
        {
            string expectedMessage = "hello";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            var inputEnterMessage = driver.FindElement(By.XPath("//*[@id='get-input']//input[@id='user-message']"));
            inputEnterMessage.SendKeys(expectedMessage);

            var buttonShowMessage = driver.FindElement(By.XPath("//*[@id=\"get-input\"]//button"));
            buttonShowMessage.Click();

            var spanMesssage = driver.FindElement(By.XPath("//*[@id=\"display\"]"));
            string actualResult = spanMesssage.Text;

            driver.Quit();

            Assert.AreEqual(expectedMessage, actualResult);
        }
    }
}
