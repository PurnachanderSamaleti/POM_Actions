using NUnit.Framework;
using TestProject1.Source.BaseClass;
using TestProject1.Source.Pages;

namespace TestProject1.Source.Amzontest
{
    public class tests : Base
    {
        [Test]
        public void Test1()
        {
            AboutUs abt = new AboutUs(driver);
            abt.Aboutus.Click();
            abt.whoweare.Click();
            abt.Whatwedo.Click();
        }

        [Test]
        public void hpges()
        {
            HomePages Hpg = new HomePages(driver);
            Hpg.searchtextbox.SendKeys("WebDriver");
            Hpg.searchbutton.Click();
            Hpg.Clickonlanguage.Click();
            Hpg.SelectTelugulanguage.Click();
            Hpg.Clickoncancel.Click();
        }
        [Test]
        public void horzontalmenu()
        {
            HorizontalMenus hrzmn = new HorizontalMenus(driver);
            hrzmn.HomeandKitchen.Click();
            hrzmn.Livingroom.Click();
            hrzmn.coffeetable.Click();
            hrzmn.TopBrands.Click();
        }
        [Test]
        public void credentials()
        {
            SighnIn sgn = new SighnIn(driver);
            sgn.signinbutton.Click();
            sgn.CreatAmazonAcct.Click();
            sgn.FirstName.SendKeys("Samaleti");
            sgn.PhoneNmbr.SendKeys("8186916653");
            sgn.Email.SendKeys("Chandu@Amazon");
            sgn.Password.SendKeys("12345678");
            sgn.Continue.Click();
        }
    }
}
