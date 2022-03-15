using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Section2Task
{
    [TestClass]
    public class Task3
    {
        [TestFixture]
        public class MyFirstTest
        {
            private IWebDriver driver;
            private WebDriverWait wait;

            [SetUp]
            public void start()
            {
                driver = new ChromeDriver();
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            }

            [Test]
            public void FirstTest()
            {
                driver.Url = "http://localhost/litecart/admin/";
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Name("username")).SendKeys("admin");
                driver.FindElement(By.Name("password")).SendKeys("admin");
                driver.FindElement(By.Name("login")).Click();

            }

            [TearDown]
            public void stop()
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}
