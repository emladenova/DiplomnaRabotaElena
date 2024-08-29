using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;

namespace Elena_DiplomnaRabota.Functionality
{
   public class Hover
    {
        public static void HoverElement(IWebDriver driver, IWebElement element)
        {
            Actions hover = new Actions(driver);
            hover.MoveToElement(element).Perform();
        }
    }
}
