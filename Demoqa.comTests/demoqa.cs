using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqa.comTests
{
    public class demoqa
    {
        //First test
        [Test]
        public void InputFieldsCorrect()
        {
            string fullName = "Ernestas";
            string email = "ernestas.svedas@gmail.com";
            string currentAddress = "Vilnius";
            string permanentAddress = "Vilnius, Lithuania";

            IWebDriver driver = new ChromeDriver();
            driver.Url = ("https://demoqa.com/text-box");

            var inputMessageFullName = driver.FindElement(By.XPath("//*[@id=\"userName\"]"));
            inputMessageFullName.SendKeys(fullName);

            var inputMessageEmail = driver.FindElement(By.XPath("//*[@id=\"userEmail\"]"));
            inputMessageEmail.SendKeys(email);

            var inputMessageCurrentAddress = driver.FindElement(By.XPath("//*[@id=\"currentAddress\"]"));
            inputMessageCurrentAddress.SendKeys(currentAddress);

            var inputMessagePermanentAddress = driver.FindElement(By.XPath("//*[@id=\"permanentAddress\"]"));
            inputMessagePermanentAddress.SendKeys(permanentAddress);

            var clickSubmit = driver.FindElement(By.XPath("//*[@id=\"submit\"]"));
            clickSubmit.Click();

            var spanMessageName = driver.FindElement(By.XPath("//*[@id=\"name\"]"));
            string actualMessageName = spanMessageName.Text;

            var spanMessageEmail = driver.FindElement(By.XPath("//*[@id=\"email\"]"));
            string actualMessageEmail = spanMessageEmail.Text;

            var spanMessageCurrentAddress = driver.FindElement(By.XPath("//*[@id=\"output\"]//*[@id=\"currentAddress\"]"));
            string actualMessageCurrentAddress = spanMessageCurrentAddress.Text;

            var spanMessagePermanentAddress = driver.FindElement(By.XPath("//*[@id=\"output\"]//*[@id=\"permanentAddress\"]"));
            string actualMessagePermanentAddress = spanMessagePermanentAddress.Text;

            Assert.AreEqual("Name:" + fullName, actualMessageName);
            Assert.AreEqual("Email:" + email, actualMessageEmail);
            Assert.AreEqual("Current Address :" + currentAddress, actualMessageCurrentAddress);
            Assert.AreEqual("Permananet Address :" + permanentAddress, actualMessagePermanentAddress);

            driver.Quit();
        }
        //Second test
        [Test]
        public void InputFieldsWrongEmail()
        {
            string fullName = "Ernestas";
            string email = "ernestas@svedas@gmail.com";

            IWebDriver driver = new ChromeDriver();
            driver.Url = ("https://demoqa.com/text-box");

            var inputMessageFullName = driver.FindElement(By.XPath("//*[@id=\"userName\"]"));
            inputMessageFullName.SendKeys(fullName);

            var inputMessageEmail = driver.FindElement(By.XPath("//*[@id=\"userEmail\"]"));
            inputMessageEmail.SendKeys(email);

            var clickSubmit = driver.FindElement(By.XPath("//*[@id=\"submit\"]"));
            clickSubmit.Click();

            var emailField = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            string classAttributeValue = emailField.GetAttribute("class");

            Assert.That(classAttributeValue.Contains("field-error"));

            driver.Quit();
        }
    }
}
