using OpenQA.Selenium.Support.UI;


namespace Elena_DiplomnaRabota.Tests
{
    public class TeststWithLogin : StartAndQuitBrowser
    {


        [Test]
        public void CheckAccountName()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            Data.Login(wait);

            Assert.That(Elements.Username(wait).Text, Is.EqualTo("test_777"));

        }


        [Test]
        public void CheckTitle()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            Data.Login(wait);

            string expectedTitle = "Home | Grocery";
            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));

            Elements.LoginIcon(wait).Click();
            Thread.Sleep(1000);

            Elements.MyWallet(wait).Click();
            Thread.Sleep(3000);

            string eTitle = "My Wallet";
            string aTitle = driver.Title;
            Assert.That(aTitle, Is.EqualTo(eTitle));
        }

        [Test]
        public void AddAddress()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            Data.Login(wait);

            Elements.LoginIcon(wait).Click();
            Thread.Sleep(1000);

            Elements.MyAddresses(wait).Click();
            Thread.Sleep(5000);

            driver.SwitchTo().Frame(Elements.IFrame(wait));

            Elements.AddNewAddress(wait).Click();

            driver.SwitchTo().DefaultContent();

            Thread.Sleep(2000);

            IFrameHandler iframeHandler = new IFrameHandler(driver, wait);
            iframeHandler.SwitchToCorrectIFrameAndFillForm();

            Thread.Sleep(3000);

            driver.SwitchTo().Frame(Elements.IFrame(wait));

            Assert.That(Elements.Address(wait).Text, Is.EqualTo("Elena Mladenova\r\nElena`s company\r\nBulgaria"));

            Elements.RemoveButton(wait).Click();
            Thread.Sleep(1000);

            Elements.YesButton(wait).Click();
            Thread.Sleep(3000);

            Assert.That(Elements.NoAddressMsg(wait).Text, Is.EqualTo("You haven't saved any addresses yet."));

            driver.SwitchTo().DefaultContent();


        }

        [Test]
        public void AddToWishList()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            Data.Login(wait);

            Functionality.Hover.HoverElement(driver, Elements.HoverBelerages(wait));
            Thread.Sleep(3000);

            Elements.DropdownCoffee(wait).Click();
            Thread.Sleep(2000);

            Functionality.Scroll.ScrollToElement(driver, Elements.ScrollColumbianCoffee(wait));

            Elements.GroundCoffee(wait).Click();
            Thread.Sleep(2000);

            Elements.AddToWishList(wait).Click();
            Thread.Sleep(1000);

            Elements.LoginIcon(wait).Click();
            Thread.Sleep(1000);

            Elements.MyWishlist(wait).Click();
            Thread.Sleep(3000);

            Functionality.Scroll.ScrollToElement(driver, Elements.ScrollCoffee(wait));
            Thread.Sleep(2000);

            Assert.That(Elements.ColombianCoffee(wait).Text, Is.EqualTo("Colombian, Ground Coffee"));


        }

        [Test]
        public void LogOut()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            Data.Login(wait);

            Elements.LoginIcon(wait).Click();
            Thread.Sleep(1000);

            Elements.LogOut(wait).Click();
            Thread.Sleep(2000);

            Assert.That(Elements.LogIn(wait).Text, Is.EqualTo("Log In"));


        }
    }
}
