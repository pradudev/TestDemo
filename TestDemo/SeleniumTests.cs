using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestDemo
{
    [TestFixture]
    public class SeleniumTests
    {
        [Test]
        public void LocalTest1()
        {
            IWebDriver driver = null;

            try
            {
                var options = new ChromeOptions();
                //options.AddArgument("--headless");

                driver = new ChromeDriver(options);
                //driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://127.0.0.1:5500/Test.html");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                var page = new TestPageObject(driver);

                //Assert.IsTrue(driver.Title.Contains("Test demo"));
                Console.WriteLine(page.InputElem.GetProperty("id"));

                var js = (IJavaScriptExecutor)driver;
                var value = js.ExecuteScript("return $('#name').val()");
                Console.WriteLine(value);

                Assert.That(page.InputElem.Enabled);
            }
            catch(Exception ex)
            {
                var ss = ((ITakesScreenshot)driver).GetScreenshot();

                ss.SaveAsFile("E:\\ss.png", ScreenshotImageFormat.Png);


                System.Console.WriteLine(ex);
                throw;
            }
            finally
            {
                driver.Close();
            }
        }
    }
}