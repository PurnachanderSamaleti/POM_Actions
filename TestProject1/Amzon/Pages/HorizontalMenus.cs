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
    public class HorizontalMenus
    {
       public IWebDriver driver;
        public HorizontalMenus(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.PartialLinkText, Using = "Home & Kitchen")]
        public IWebElement HomeandKitchen;

        [FindsBy(How = How.PartialLinkText, Using = "Living")]
        public IWebElement Livingroom;

        [FindsBy(How = How.XPath, Using = "//a[@aria-label='Coffee tables']")]
        public IWebElement coffeetable;

        [FindsBy(How = How.PartialLinkText, Using = "Top Brands")]
        public IWebElement TopBrands;
 }
}