
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
     public class CustomControl: DriverHelper
    {
        public static void ComboBox(string ControlName, string value)
        {
            IWebElement comboControl = Driver.FindElement(By.XPath($"//input[@id = '{ControlName}-awed']"));
            comboControl.Clear();
            comboControl.SendKeys(value);
            Driver.FindElement(By.XPath($"//div[@id='{ControlName}-dropmenu']//li[text()='{value}']")).Click();
        }
    }
}
