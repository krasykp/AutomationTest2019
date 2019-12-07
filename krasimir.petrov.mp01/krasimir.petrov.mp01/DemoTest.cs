using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace krasimir.petrov.mp01
{
    [TestClass]
    public class DemoTest
    {
        private IWebDriver driver;

        [TestInitialize]
        public void SetUp()
        {
            driver = new ChromeDriver();

        }
        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }
        [TestMethod]
        public void test1()
        {
            driver.Navigate().GoToUrl("https://edu.unibit.bg/login/index.php");
            driver.Manage().Window.Size = new System.Drawing.Size(1045, 1039);
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).SendKeys("asdsad");
            driver.FindElement(By.Id("loginbtn")).Click();
            Assert.AreEqual(driver.FindElement(By.CssSelector(".alert")).Text, "Невалидно име или парола, моля опитайте отново");
            Assert.AreEqual(driver.FindElement(By.CssSelector(".alert")).Text, "Невалидно име или парола, моля опитайте отново");


        }
    }
}