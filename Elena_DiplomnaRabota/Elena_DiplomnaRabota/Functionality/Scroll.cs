using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;

namespace Elena_DiplomnaRabota.Functionality
{
    public class Scroll
    {
        public static void ScrollToElement(IWebDriver driver, IWebElement element)
        {

            Actions scroll = new Actions(driver);
            scroll.MoveToElement(element);
            scroll.Perform();
        }
    }
}
