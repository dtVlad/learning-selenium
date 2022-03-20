using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;

namespace SectionTasks
{
    public class Section2Task1
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
                driver.Url = "https://www.wikipedia.org/";
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Name("search")).SendKeys("program");
                driver.FindElement(By.CssSelector("[type='submit']")).Click();
                wait.Until(ExpectedConditions.TitleContains("Program"));
                
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
