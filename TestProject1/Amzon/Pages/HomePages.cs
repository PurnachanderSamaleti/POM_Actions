using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Source.BaseClass;

namespace TestProject1.Source.Pages
{
    public class HomePages
    {
        public IWebDriver _driver;
        public HomePages(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        public IWebElement searchtextbox;

        [FindsBy(How = How.Id, Using = "nav-search-submit-button")]
        public IWebElement searchbutton;

        [FindsBy(How = How.ClassName, Using = "icp-nav-flag")]
        public IWebElement Clickonlanguage;

        [FindsBy(How = How.XPath, Using = "(//span[@dir='ltr'])[7]")]
        public IWebElement SelectTelugulanguage;

        [FindsBy(How = How.ClassName, Using = "a-button-text")]
        public IWebElement Clickoncancel;

    }
}
