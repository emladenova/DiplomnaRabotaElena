using Newtonsoft.Json;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace Elena_DiplomnaRabota
{
    public class Data
    {
        public string? Url { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public Data(string url, string email, string password)
        {
            Url = url;
            Email = email;
            Password = password;
        }
        public static Data ReadFromFile(string filePath = "data.json")
        {
            Data? result = null;
            using (var sr = new StreamReader(filePath))
            {
                string configJson = sr.ReadToEnd();
                result = JsonConvert.DeserializeObject<Data>(configJson);
            }
            return result;
        }

        public static void Login(WebDriverWait wait)
        {
            var json = ReadFromFile("data.json");

            IWebElement LoginIcon = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()= 'Log In']//ancestor::div[@class = 'comp-kmxcw0yb nu84UJ']/button")));
            LoginIcon.Click();

            IWebElement LoginButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//button[@class='FhIHQq' and text()='Log In']")));
            LoginButton.Click();

            IWebElement LoginWithEmailButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[text() = 'Log in with Email']//ancestor::div[@class = 'FubTgk']/button")));
            LoginWithEmailButton.Click();

            Thread.Sleep(1000);

            var emailInput = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='MpKiNN wixui-text-input qzvPmW lPl_oN']//input[@type = 'email']")));
            emailInput.SendKeys(json.Email);

            var passwordInput = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='MpKiNN wixui-text-input qzvPmW lPl_oN']//input[@type = 'password']")));
            passwordInput.SendKeys(json.Password);

            IWebElement Login = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[text() = 'Log In']//ancestor::div[@class = 'FubTgk']/button")));
            Login.Click();
        }

        public static IWebDriver StartBrowserAndGoToUrl(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            var json = Data.ReadFromFile("data.json");

            driver.Navigate().GoToUrl(json.Url);

            return driver;
        
        }


    }
}

