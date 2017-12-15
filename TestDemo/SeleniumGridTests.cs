using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;

namespace TestDemo
{
    [TestFixture]
    [Parallelizable(ParallelScope.Children)]
    public class SeleniumGridTests
    {
        [Test]
        [TestCase("chrome")]
        [TestCase("firefox")]
        public void GridTest1(string browserName)
        {
            IWebDriver driver = null;

            try
            {
                ICapabilities capabilities = null;

                if (browserName == "chrome")
                {
                    ChromeOptions chromeOptions = new ChromeOptions();
                    capabilities = chromeOptions.ToCapabilities();
                }
                else if (browserName == "firefox")
                {
                    FirefoxOptions firefoxOptions = new FirefoxOptions();
                    capabilities = firefoxOptions.ToCapabilities();
                }

                driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities);
                //driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://127.0.0.1:5500/Test.html");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                var page = new TestPageObject(driver);

                Assert.That(page.InputElem.Enabled);
            }
            catch (Exception ex)
            {
                //var ss = ((ITakesScreenshot)driver).GetScreenshot();

                //ss.SaveAsFile("E:\\ss.png", ScreenshotImageFormat.Png);

                //System.Console.WriteLine(ex);
                //throw;
                //Console.WriteLine(ex);
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}