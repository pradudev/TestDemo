using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo
{
    public class TestPageObject
    {
        [FindsBy(How = How.TagName, Using = "h3")]
        public IWebElement H1TitleElem { get; set; }

        [FindsBy(How = How.TagName, Using = "h2")]
        public IWebElement H2TitleElem { get; set; }

        [FindsBy(How= How.Name, Using ="name")]
        public IWebElement InputElem { get; set; }

        public TestPageObject(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
