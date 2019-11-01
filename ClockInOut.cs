using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

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
            WebDriverWait webdriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            IWebElement userField = webdriverWait.Until(ExpectedConditions.ElementIsVisible(By.Id("ext-gen51")));

            userField.SendKeys("[email here]");
            driver.FindElementById("ext-gen53").SendKeys("your password here");
            driver.FindElementById("ext-gen55").Click();

            Thread.Sleep(15000); // just for visual validation

            driver.Quit();

        }
    }
}
    