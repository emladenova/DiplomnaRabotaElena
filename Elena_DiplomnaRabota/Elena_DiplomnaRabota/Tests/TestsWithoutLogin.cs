using OpenQA.Selenium.Support.UI;

namespace Elena_DiplomnaRabota.Tests
{
    public class TestsWithoutLogin:StartAndQuitBrowser
    {
       [Test]
        public void HandCreamQuantityAndPrice()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            Functionality.Scroll.ScrollToElement(driver, Elements.ScrollHandCream(wait)); 
   
            Elements.PlusButtonHandCream(wait).Click();
            Thread.Sleep(2000);

            Elements.AddToCartHandCream(wait).Click();
            Thread.Sleep(2000);

            driver.SwitchTo().Frame(Elements.iframe(wait));

            Assert.That(Elements.HandCreamItem(wait).Text, Is.EqualTo("Hand Cream"));

            string QuantityValue = Elements.HandCreamQuantity(wait).GetAttribute("value");
            Assert.That(QuantityValue, Is.EqualTo("2"));

            Assert.That(Elements.HandCreamSubtotal(wait).Text, Is.EqualTo("$5.98"));

            driver.SwitchTo().DefaultContent();


        }

        [Test]
        public void MilkInput()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            Elements.SearchInput(wait).Click();
            string Input = "milk";
            Elements.SearchInput(wait).SendKeys(Input);
            
            Thread.Sleep(2000);

            Elements.SearchButton(wait).Click();

            Assert.That(Elements.MilkItems(wait).Text, Is.EqualTo("7 items found for \"milk\""));
         
        }

        [Test]
        public void MostPopularPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            Elements.MostPopularButton(wait).Click();

            Thread.Sleep(2000);

            Assert.That(Elements.MostPopular(wait).Text, Is.EqualTo("Most Popular"));
           
        }

        [Test]
        public void WinePage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            Functionality.Scroll.ScrollToElement(driver, Elements.ScrollWineRow(wait)); 

            Elements.WineSectionButton(wait).Click();

            Thread.Sleep(2000);

            Assert.That(Elements.Wine(wait).Text, Is.EqualTo("Wine"));
           
        }

        [Test]
        public void ShopNowPrice()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            Elements.ShopNow(wait).Click();

            Elements.SortByButton(wait).Click();
            Thread.Sleep(3000);

            Elements.PriceLowToHighOption(wait).Click();
            Thread.Sleep(2000);

            Functionality.Scroll.ScrollToElement(driver, Elements.ScrollCucumber(wait)); 
            Thread.Sleep(2000);
            
            Assert.That(Elements.Price(wait).Text, Is.EqualTo("$0.99"));

          
        }

        [Test]
        public void PastasPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            Elements.PastasShopNow(wait).Click();

            Thread.Sleep(2000);

            Assert.That(Elements.Pastas(wait).Text, Is.EqualTo("Pastas"));
           
        }

        [Test]
        public void SupportPage() 
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            Elements.OnlineSupport(wait).Click();

            Thread.Sleep(3000);

            Assert.That(Elements.CustomerSupport(wait).Text, Is.EqualTo("Customer Support"));
          

        }
    }
}
