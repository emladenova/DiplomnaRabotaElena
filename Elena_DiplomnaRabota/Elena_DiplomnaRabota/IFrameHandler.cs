using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Elena_DiplomnaRabota
{
    public class IFrameHandler
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public IFrameHandler(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void SwitchToCorrectIFrameAndFillForm()
        {
            var iframes = driver.FindElements(By.TagName("iframe"));
            foreach (var frame in iframes)
            {
                driver.SwitchTo().Frame(frame);

                if (driver.FindElements(By.XPath("//input[@id='firstName-field']")).Count > 0)
                {
                    Elements.FirstNameInput(wait).SendKeys("Elena");
                    Elements.LastNameInput(wait).SendKeys("Mladenova");
                    Elements.CompanyNameInput(wait).SendKeys("Elena`s company");
                    Elements.AddAddressButton(wait).Click();

                    break;
                }
                driver.SwitchTo().DefaultContent();
            }

            driver.SwitchTo().DefaultContent();
        }


    }
}







