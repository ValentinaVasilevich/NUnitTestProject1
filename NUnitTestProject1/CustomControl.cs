
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
     public class CustomControl: DriverHelper
    {
        public static void ComboBox(string ControlName, string value)
        {
            IWebElement comboControl = driver.FindElement(By.XPath($"//input[@id = '{ControlName}-awed']"));
            comboControl.Clear();
            comboControl.SendKeys(value);
            driver.FindElement(By.XPath($"//div[@id='{ControlName}-dropmenu']//li[text()='{value}']")).Click();
        }

        public static void ClickElement(IWebElement webElement) => webElement.Click();

        public static void EnterText(IWebElement webElement, string value) => webElement.SendKeys(value);

        public static void SelectByValue(IWebElement webElement, string value)
        {
           SelectElement selectElement = new  SelectElement(webElement);
            selectElement.SelectByValue(value);
        }

        public static void SelectByText(IWebElement webElement, string text)
        {
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByText(text);
        }

    }
}
