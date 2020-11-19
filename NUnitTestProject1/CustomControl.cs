
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    public class CustomControl : DriverHelper
    {
        public static void ClickElement(IWebElement webElement) => webElement.Click();

        public static void EnterText(IWebElement webElement, string value) => webElement.SendKeys(value);       
    }
}

