using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace NUnitTestProject1
{
    public class Tests : DriverHelper
    {
        private static String TUT_BY_URL = "https://www.tut.by/";
        private static String USERNAME = "SeleniumTr@tut.by";
        private static String PASSWORD = "Selenium_001";

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            driver = new ChromeDriver();
        }

        [Test]
        public void LoginToTutByTest()
        {
            //launch tut.by
            driver.Navigate().GoToUrl(TUT_BY_URL);

            //click 'Войти' button
            CustomControl.ClickElement(driver.FindElement(By.XPath("//a[@class ='enter']")));
            // enter username and password
            CustomControl.EnterText(driver.FindElement(By.XPath("//input[@name= 'login']")), USERNAME);
            CustomControl.EnterText(driver.FindElement(By.XPath("//input[@name= 'password']")), PASSWORD);

            //click 'Войти' button within popup
            CustomControl.ClickElement(driver.FindElement(By.XPath("//input[@class='button m-green auth__enter']")));

            new WebDriverWait(driver, TimeSpan.FromSeconds(6)).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class ='enter logedin' ]")));
            CustomControl.ClickElement(driver.FindElement(By.XPath("//*[@class ='enter logedin' ]")));

            //verifies that user is logged
            IWebElement name = driver.FindElement(By.XPath("//span[@class='uname']"));
            string value = name.Text;
            Assert.AreEqual("Test Test", value);
            //log out
            CustomControl.ClickElement(driver.FindElement(By.XPath("//*[@class ='button wide auth__reg']")));

            //verifies that user is logeed out
            new WebDriverWait(driver, TimeSpan.FromSeconds(6)).Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@class ='enter']")));
            IWebElement name1 = driver.FindElement(By.XPath("//a[@class ='enter']"));
            value = name1.Text;
            Assert.AreEqual("Войти", value);
            driver.Close();
        }   
    }
}