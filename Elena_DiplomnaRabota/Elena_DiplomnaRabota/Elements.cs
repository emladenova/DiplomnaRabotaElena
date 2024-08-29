using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Elena_DiplomnaRabota
{
  

    public class Elements
    {
        //Tests With Login

        //CheckAccountName Test
        public static IWebElement Username(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@aria-label='test_777 account menu']/div/following-sibling::div[@class='MseJE2']")));

        //CheckTitle Test
        public static IWebElement LoginIcon(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//div[@aria-label='test_777 account menu' and @role='button']")));
        public static IWebElement MyWallet(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[text() = 'My Wallet']//ancestor::li")));
        
       //AddAddress Test
        public static IWebElement MyAddresses(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[text() = 'My Addresses']//ancestor::li")));
        public static IWebElement IFrame(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//iframe[@title = 'My Addresses']")));
        public static IWebElement AddNewAddress(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[@class = 'has-tooltip ']//ancestor::div[@class = '_10o0_ _26mkp hidden-mobile']//button")));
        public static IWebElement FirstNameInput(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='firstName-field']")));
        public static IWebElement LastNameInput(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='lastName-field']")));
        public static IWebElement CompanyNameInput(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='company-field']")));
        public static IWebElement AddAddressButton(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//button[@data-hook = 'submit-add-address']")));
        public static IWebElement RemoveButton(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//address[contains (text(), 'Elena Mladenova')]/ancestor::div[@class = '_37aSU' ]//button[text() = 'Remove']")));
        public static IWebElement Address(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//address[@data-hook='formatted-address']")));
        public static IWebElement YesButton(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//address[contains (text(), 'Elena Mladenova')]/ancestor::div[@class = '_37aSU _37vQq' ]//button[text() = 'Yes']")));
        public static IWebElement NoAddressMsg(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@data-hook='no-addresses']")));

        //AddToWishList Test
        public static IWebElement HoverBelerages(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//p[text() = 'Beverages']//ancestor::div[@class = 'yRj2ms']")));
        public static IWebElement DropdownCoffee(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//p[text() = 'Coffee']//ancestor::div[@class = 'yRj2ms']")));
        public static IWebElement ScrollColumbianCoffee(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//h3 [text() = 'Colombian, Ground Coffee']/ancestor::div[@data-hook = 'not-image-container']")));
        public static IWebElement GroundCoffee(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//h3[text() = 'Colombian, Ground Coffee']//ancestor::div[@class = 'ejYUwA t1Z_7C']")));
        public static IWebElement AddToWishList(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//button[@aria-label = 'Add to Wishlist']")));
        public static IWebElement MyWishlist(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[text() = 'My Wishlist']//ancestor::li")));
        public static IWebElement ScrollCoffee(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//p[text() = 'Colombian, Ground Coffee']//ancestor::li/div")));
        public static IWebElement ColombianCoffee(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//p[@data-hook = 'product-item-name' and text() = 'Colombian, Ground Coffee']")));

        //LogOut Test
        public static IWebElement LogOut(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[text() = 'Log Out']//ancestor::li")));
        public static IWebElement LogIn(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[text()= 'Log In']//ancestor::div[@class = 'comp-kmxcw0yb nu84UJ']/button")));


        //Testst Without Login

        //HandCreamQuantityAndPrice Test
        public static IWebElement ScrollHandCream(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//div[@data-hook='product-item-root' and @data-slug='hand-cream']")));
        public static IWebElement PlusButtonHandCream(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//div[@data-slug='hand-cream']//button[@aria-label='Add one item' and @data-hook='counter-plus-button']")));
        public static IWebElement AddToCartHandCream(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[text() = 'Add to Cart']/ancestor::div[@data-slug = 'hand-cream']//span[text() = 'Add to Cart']/..")));
        public static IWebElement HandCreamItem(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@data-hook = 'cart-widget-name' and text() = ' Hand Cream ']")));
        public static IWebElement iframe(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//iframe[@class = 'U73P_q']")));
        public static IWebElement HandCreamQuantity(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='item-info']//div[@class='item-name' and contains(text(), 'Hand Cream')]/following-sibling::div[@class='product-quantity']//input[@data-hook='product-quantity-input']")));
        public static IWebElement HandCreamSubtotal(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//section[@class='cart-widget-subtotal']//div[@data-hook='cart-widget-total']")));

        //MilkInput Test
        public static IWebElement SearchInput(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//input[@name= 'q']")));
        public static IWebElement SearchButton(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//button[@aria-label = 'Search a product e.g. milk']")));
        public static IWebElement MilkItems(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//p[@data-hook = 'total-results']")));

        //MostPopularPage Test
        public static IWebElement MostPopularButton(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//p[text() = 'Most Popular']/ancestor::li")));
        public static IWebElement MostPopular(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@id = 'comp-kowlx8h5']")));

        //WinePage Test
        public static IWebElement ScrollWineRow(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//section[@id='comp-kmxou1m8']//div[@data-testid='columns']")));
        public static IWebElement WineSectionButton(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//div[@id = 'comp-kmxounw4']")));
        public static IWebElement Wine(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@id = 'comp-kowoke9b']")));

        //ShopNowPrice Test
        public static IWebElement ShopNow(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//div[@id='comp-kmxa7l8r']//a[@class='uDW_Qe wixui-button PlZyDq']//span[text()='Shop Now']")));
        public static IWebElement SortByButton(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//button[@data-hook = 'dropdown-base']")));
        public static IWebElement PriceLowToHighOption(WebDriverWait wait) => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@data-hook='option' and @title='Price (low to high)']")));
        public static IWebElement ScrollCucumber(WebDriverWait wait) => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h3[text() = 'Greenhouse Cucumber - 1lb']//ancestor::div[@data-hook = 'not-image-container']")));
        public static IWebElement Price(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//h3[text()='Greenhouse Cucumber - 1lb']/ancestor::a//span[@data-hook='product-item-price-to-pay']")));

        //PastasPage Test
        public static IWebElement PastasShopNow(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//div[@id='comp-kmxqvkaj' and .//span[contains(text(), 'Pastas')]]//a[@class='uDW_Qe wixui-button PlZyDq']//span[text()='Shop Now']")));
        public static IWebElement Pastas(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@id = 'comp-kp1afilm']")));

        //SupportPage Test
        public static IWebElement OnlineSupport(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//div[@id='comp-knd00woz2']//a[contains(text(), 'Online Support')]")));
        public static IWebElement CustomerSupport(WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@id='comp-kou161oh']//span[contains(text(), 'Customer Support')]")));
    }
}
