using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace NUnitTestProject1
{
    public class Tests  : DriverHelper
    {    
        //private static String TUT_BY_URL = "https://www.tut.by/";
        //private static String USERNAME = "TestTrenning";
        //private static String PASSWORD = "trenning_001";
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");

            Driver.FindElement(By.XPath("//input[@name = 'ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery'] ")).Click();

            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almod");
           
            Driver.Close();

            Console.WriteLine("Test1");
            Assert.Pass();
        }



    }
}