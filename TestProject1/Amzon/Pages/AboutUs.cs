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
    public class AboutUs
    {
     public   IWebDriver driver;
        public AboutUs(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        
        [FindsBy(How = How.PartialLinkText, Using = "About Us")]
        public IWebElement Aboutus;
        [FindsBy(How = How.PartialLinkText, Using = "Who We Are")]
        public IWebElement whoweare;
        [FindsBy(How = How.PartialLinkText, Using = "What We Do")]
        public IWebElement Whatwedo;
       
    }
        
}
