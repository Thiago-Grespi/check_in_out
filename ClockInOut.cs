using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace clock_in_out
{
    public class ClockInOut
    {
        ChromeDriver driver;
        ChromeOptions chromeOptions = new ChromeOptions();

        [Fact]
        private void PunchCard()
        {
            var chromeDriverDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //chromeOptions.AddArguments("headless");
            driver = new ChromeDriver(chromeDriverDirectory, chromeOptions);
            driver.Navigate().GoToUrl("https://pontoeletronico.programmers.com.br/portalrh/");

            driver.FindElementById("ext-gen51").SendKeys("your email here");
            driver.FindElementById("ext-gen53").SendKeys("your password here");
            driver.FindElementById("ext-gen55").Click();

        }
    }
}
    