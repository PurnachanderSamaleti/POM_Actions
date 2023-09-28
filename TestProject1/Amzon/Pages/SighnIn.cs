using OpenQA.Selenium;
using NUnit.Framework;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Source.BaseClass;

namespace TestProject1.Source.Pages
{
    public class SighnIn
    {
        public IWebDriver driver;
        public SighnIn(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Sign in")]
        public IWebElement signinbutton;

        [FindsBy(How = How.Id, Using = "createAccountSubmit")]
        public IWebElement CreatAmazonAcct;

        [FindsBy(How = How.Id, Using = "ap_customer_name")]
        public IWebElement FirstName;

        [FindsBy(How = How.Id, Using = "ap_phone_number")]
        public IWebElement PhoneNmbr;

        [FindsBy(How = How.Name, Using = "secondaryLoginClaim")]
        public IWebElement Email;

        [FindsBy(How = How.Id, Using = "ap_password")]
        public IWebElement Password;

        [FindsBy(How = How.Id, Using = "continue")]
        public IWebElement Continue;

        
    }
}